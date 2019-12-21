using System.Collections.Generic;

namespace Bravura.Tonality
{
    /// <inheritdoc />
    /// <summary>
    /// Represents an ordered collection of key/value pairs that are accessible by the key or index.
    /// </summary>
    /// <typeparam name="TKey">The type of keys</typeparam>
    /// <typeparam name="TValue">The type of values</typeparam>
    public interface IReadOnlyOrderedDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
        /// <summary>
        /// The value of the element at the given index.
        /// </summary>
        TValue this[int index] { get; }

        /// <summary>
        /// The value of the element with the given key.
        /// </summary>
        new TValue this[TKey key] { get; }

        /// <summary>
        /// Find the position of an element by key. Returns -1 if the dictionary does not contain an element with the given key.
        /// </summary>
        int IndexOf(TKey key);
    }
}
