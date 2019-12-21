using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Bravura.Tonality
{
    /// <inheritdoc />
    /// <summary>
    /// Represents an ordered collection of key/value pairs that are accessible by the key or index.
    /// </summary>
    /// <typeparam name="TKey">The type of keys. Cannot be <see cref="T:System.Int32" /></typeparam>
    /// <typeparam name="TValue">The type of values.</typeparam>
    public sealed class ReadOnlyOrderedDictionary<TKey, TValue> : IReadOnlyOrderedDictionary<TKey, TValue>
    {
        /// <summary>
        /// An unordered dictionary of key pairs.
        /// </summary>
        private readonly ReadOnlyDictionary<TKey, TValue> _dictionary;

        /// <summary>
        /// The keys of the dictionary in the exposed order.
        /// </summary>
        private readonly List<TKey> _keys;

        /// <summary>
        /// A collection of key/value pairs that are accessible by the key or index.
        /// </summary>
        public ReadOnlyOrderedDictionary(ReadOnlyCollection<KeyValuePair<TKey, TValue>> orderedEntries)
        {
            if (typeof(TKey) == typeof(int))
                throw new NotSupportedException("Integer-like type is not appropriate for keys in an ordered dictionary - accessing values by key or index would be confusing.");

            var dictionary = new Dictionary<TKey, TValue>();
            foreach (var entry in orderedEntries)
            {
                dictionary.Add(entry.Key, entry.Value);
            }
            _dictionary = new ReadOnlyDictionary<TKey, TValue>(dictionary);
            _keys = orderedEntries.Select(entry => entry.Key).ToList();
        }

        /// <summary>
        /// The number of elements in the dictionary.
        /// </summary>
        public int Count => _dictionary.Count;

        /// <summary>
        /// The keys of the dictionary, in order.
        /// </summary>
        public IEnumerable<TKey> Keys => _keys.AsReadOnly();

        /// <summary>
        /// The keys of the dictionary, in order.
        /// </summary>
        public ReadOnlyCollection<TKey> KeysList => _keys.AsReadOnly();

        /// <summary>
        /// The values in the dictionary, in order.
        /// </summary>
        public IEnumerable<TValue> Values => _keys.Select(key => _dictionary[key]);

        /// <summary>
        /// The value at the given index.
        /// </summary>
        public TValue this[int index] => _dictionary[_keys[index]];

        /// <summary>
        /// The value under the given key. New entries are added at the end of the order. Updating an existing entry does not change its position.     
        /// </summary>
        public TValue this[TKey key] => _dictionary[key];

        /// <summary>
        ///  Find the position of an element by key. Returns -1 if the dictionary does not contain an element with the given key.
        /// </summary>
        public int IndexOf(TKey key) => _keys.IndexOf(key);

        /// <summary>
        /// Test whether there is an element with the given key.
        /// </summary>
        public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);

        /// <summary>
        /// Try to get a value from the dictionary, by key. Returns false if there is no element with the given key.
        /// </summary>
        public bool TryGetValue(TKey key, out TValue value) => _dictionary.TryGetValue(key, out value);

        private IEnumerable<KeyValuePair<TKey, TValue>> Enumerate()
        {
            foreach (var key in _keys)
            {
                var value = _dictionary[key];
                yield return new KeyValuePair<TKey, TValue>(key, value);
            }
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => Enumerate().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Enumerate().GetEnumerator();
    }
}