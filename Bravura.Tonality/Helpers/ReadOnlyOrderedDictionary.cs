using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Bravura.Tonality
{
    /// <inheritdoc />
    /// <summary>
    /// A dictionary that remembers the order that keys were first inserted. If a new entry overwrites an existing entry, the original insertion position is left unchanged. Deleting an entry and reinserting it will move it to the end.
    /// </summary>
    /// <typeparam name="TKey">The type of keys</typeparam>
    /// <typeparam name="TValue">The type of values</typeparam>
    public interface IReadOnlyOrderedDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
        /// <summary>
        /// The value of the element at the given index.
        /// </summary>
        TValue this[int index] { get; set; }

        /// <summary>
        /// The value of the element with the given key.
        /// </summary>
        new TValue this[TKey key] { get; set; }

        /// <summary>
        /// Find the position of an element by key. Returns -1 if the dictionary does not contain an element with the given key.
        /// </summary>
        int IndexOf(TKey key);
    }

    /// <inheritdoc />
    /// <summary>
    /// A dictionary that remembers the order that keys were first inserted. If a new entry overwrites an existing entry, the original insertion position is left unchanged. Deleting an entry and reinserting it will move it to the end.
    /// </summary>
    /// <typeparam name="TKey">The type of keys. Musn't be <see cref="T:System.Int32" /></typeparam>
    /// <typeparam name="TValue">The type of values.</typeparam>
    public sealed class ReadOnlyOrderedDictionary<TKey, TValue> : IReadOnlyOrderedDictionary<TKey, TValue>
    {
        /// <summary>
        /// An unordered dictionary of key pairs.
        /// </summary>
        private readonly Dictionary<TKey, TValue> _fDictionary;

        /// <summary>
        /// The keys of the dictionary in the exposed order.
        /// </summary>
        private readonly List<TKey> _fKeys;

        /// <summary>
        /// A dictionary that remembers the order that keys were first inserted. If a new entry overwrites an existing entry, the original insertion position is left unchanged. Deleting an entry and reinserting it will move it to the end.
        /// </summary>
        public ReadOnlyOrderedDictionary()
        {
            if (typeof(TKey) == typeof(int))
                throw new NotSupportedException("Integer-like type is not appropriate for keys in an ordered dictionary - accessing values by key or index would be confusing.");

            _fDictionary = new Dictionary<TKey, TValue>();
            _fKeys = new List<TKey>();
        }

        /// <summary>
        /// The number of elements in the dictionary.
        /// </summary>
        public int Count => _fDictionary.Count;

        /// <summary>
        /// This dictionary is not read only.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// The keys of the dictionary, in order.
        /// </summary>
        public IEnumerable<TKey> Keys => _fKeys.AsReadOnly();

        public ReadOnlyCollection<TKey> KeysList => _fKeys.AsReadOnly();

        /// <summary>
        /// The values in the dictionary, in order.
        /// </summary>
        public IEnumerable<TValue> Values => _fKeys.Select(key => _fDictionary[key]).ToArray();

        /// <summary>
        /// The value at the given index.
        /// </summary>
        public TValue this[int index]
        {
            get
            {
                var key = _fKeys[index];
                return _fDictionary[key];
            }
            set
            {
                var key = _fKeys[index];
                _fDictionary[key] = value;
            }
        }

        /// <summary>
        /// The value under the given key. New entries are added at the end of the order. Updating an existing entry does not change its position.     
        /// </summary>
        public TValue this[TKey key]
        {
            get => _fDictionary[key];
            set
            {
                if (!_fDictionary.ContainsKey(key))
                {
                    // New entries are added at the end of the order.
                    _fKeys.Add(key);
                }

                _fDictionary[key] = value;
            }
        }

        /// <summary>
        ///  Find the position of an element by key. Returns -1 if the dictionary does not contain an element with the given key.
        /// </summary>
        public int IndexOf(TKey key) => _fKeys.IndexOf(key);

        /// <summary>
        /// Test whether there is an element with the given key.
        /// </summary>
        public bool ContainsKey(TKey key) => _fDictionary.ContainsKey(key);

        /// <summary>
        /// Try to get a value from the dictionary, by key. Returns false if there is no element with the given key.
        /// </summary>
        public bool TryGetValue(TKey key, out TValue value) => _fDictionary.TryGetValue(key, out value);

        /// <summary>
        /// Add an element to the dictionary.
        /// </summary>
        public void Add(TKey key, TValue value)
        {
            // Dictionary operation first, so exception thrown if key already exists.
            _fDictionary.Add(key, value);
            _fKeys.Add(key);
        }

        /// <summary>
        /// Add an element to the dictionary.
        /// </summary>
        public void Add(KeyValuePair<TKey, TValue> pair) => Add(pair.Key, pair.Value);

        /// <summary>
        /// Test whether the dictionary contains an element equal to that given.
        /// </summary>
        public bool Contains(KeyValuePair<TKey, TValue> pair) => _fDictionary.Contains(pair);

        /// <summary>
        /// Remove a key-value pair from the dictionary. Return true if pair was successfully removed. Otherwise, if the pair was not found, return false.
        /// </summary>
        public bool Remove(KeyValuePair<TKey, TValue> pair)
        {
            if (Contains(pair))
            {
                Remove(pair.Key);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Remove the element with the given key key. If there is no element with the key, no exception is thrown.
        /// </summary>
        public bool Remove(TKey key)
        {
            var wasInDictionary = _fDictionary.Remove(key);
            var wasInKeys = _fKeys.Remove(key);
            Contract.Assume(wasInDictionary == wasInKeys);
            return wasInDictionary;
        }

        /// <summary>
        /// Delete all elements from the dictionary.
        /// </summary>
        public void Clear()
        {
            _fDictionary.Clear();
            _fKeys.Clear();
        }

        /// <summary>
        /// Copy the elements of the dictionary to an array, starting at at the given index.
        /// </summary>
        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Must be greater than or equal to zero.");

            if (index + _fDictionary.Count > array.Length)
                throw new ArgumentException("Array is too small", nameof(array));

            foreach (var pair in this)
            {
                array[index] = pair;
                index++;
            }
        }

        private IEnumerable<KeyValuePair<TKey, TValue>> Enumerate()
        {
            foreach (var key in _fKeys)
            {
                var value = _fDictionary[key];
                yield return new KeyValuePair<TKey, TValue>(key, value);
            }
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => Enumerate().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Enumerate().GetEnumerator();

        /// <summary>
        /// Conditions that should be true at the end of every public method.
        /// </summary>
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_fDictionary.Count == _fKeys.Count, "Unordered dictionary and ordered key list should be the same length.");
        }
    }
}