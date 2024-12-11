# ReadOnlyOrderedDictionary<TKey, TValue> Class

Namespace: [Bravura.Common](./Bravura.Common.md)

### Represents an ordered collection of key/value pairs that are accessible by the key or index.

```csharp
public class ReadOnlyOrderedDictionary<TKey, TValue>
```

#### Type Parameters
`TKey`<br/>
The type of keys in the dictionary.

`TValue`<br/>
The type of values in the dictionary.

## Constructors
| Constructor                                                               | Description                                                                                                                             |
|---------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------|
| ReadOnlyOrderedDictionary(ReadOnlyCollection<KeyValuePair<TKey, TValue>>) | Initializes a new instance of the [ReadOnlyOrderedDictionary<TKey, TValue>](./Bravura.Common.Types.ReadOnlyOrderedDictionary.md) class. |

## Properties
| Property    |       Return Value        | Description                               |
|-------------|:-------------------------:|-------------------------------------------|
| Count       |           Int32           | The number of elements in the dictionary. |
| Keys        |    IEnumerable\<TKey>     | The keys of the dictionary, in order.     |
| KeysList    | ReadOnlyCollection\<TKey> | The keys of the dictionary, in order.     |
| Values      |   IEnumerable\<TValue>    | The values in the dictionary, in order.   |
| Item[Int32] |          TValue           | The value at the given index.             |
| Item[TKey]  |          TValue           | The value under the given key.            |


## Methods
| Method                        | Return Type | Description                                                                                                          |
|-------------------------------|:-----------:|----------------------------------------------------------------------------------------------------------------------|
| IndexOf(TKey)                 |    Int32    | Find the position of an element by key. Returns -1 if the dictionary does not contain an element with the given key. |
| ContainsKey(TKey)             |   Boolean   | Returns whether there is an element with the given key.                                                              |
| TryGetValue(TKey, out TValue) |   Boolean   | Try to get a value from the dictionary, by key. Returns false if there is no element with the given key.             |

## Remarks
Trying to instantiate this class with an Integer-like key will throw a `NotSupportedException`. Integer-like types are not appropriate for keys in an ordered dictionary because accessing values by key or index would be confusing.
