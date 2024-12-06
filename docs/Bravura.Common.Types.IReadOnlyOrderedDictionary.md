# IReadOnlyOrderedDictionary<TKey, TValue> Interface

Namespace: [Bravura.Common.Types](./Bravura.Common.Types.md)

### Represents an ordered collection of key/value pairs that are accessible by the key or index.

```csharp
public interface IReadOnlyOrderedDictionary<TKey, TValue> : System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>
```

#### Type Parameters
`TKey`<br/>
The type of keys in the dictionary.

`TValue`<br/>
The type of values in the dictionary.

Derived: [ReadOnlyOrderedDictionary<TKey, TValue>](./Bravura.Common.Types.ReadOnlyOrderedDictionary.md)

Implements: IReadOnlyDictionary<TKey, TValue>

## Properties
| Property | Return Value | Description |
| --- | :---: | --- |
| Item[Int32] | TValue | Gets the value of the element at the given index. |
| Item[TKey] | TValue | Gets the value of the element with the given key. |

## Methods
| Method | Return Type | Description |
| --- | :---: | --- |
| IndexOf(TKey) | Int32 | Find the position of an element by key. Returns -1 if the dictionary does not contain an element with the given key. |
