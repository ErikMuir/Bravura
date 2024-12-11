# Indexable Class

Namespace: [Bravura.Common](./Bravura.Common.md)

### A generic iterable collection with internal indexing capabilities.

```csharp
public class Indexable
```

Inheritance: Object -> Indexable

## Remarks
The methods in this class provide an implementation of `IEnumerable<T>`.

## Constructors
| Constructor                      | Description                                                                                                                                          |
|----------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------|
| Indexable\<T\>(IEnumerable\<T\>) | Initializes a new instance of the [Indexable](./Bravura.Common.Types.Indexable.md) class with the provided value, defaulting to an empty collection. |

## Properties
| Property | Return Value | Description                                                  |
|----------|:------------:|--------------------------------------------------------------|
| Count    |    Int32     | The number of items contained in the List.                   |
| Index    |    Int32     | The current index used for iterating through the collection. |
| Current  |      T       | The collection item at the current index.                    |
| IsLast   |   Boolean    | Whether the current item is the last item in the collection. |

## Methods
| Method                | Return Type | Description                                                                                                     |
|-----------------------|:-----------:|-----------------------------------------------------------------------------------------------------------------|
| MoveNext()            |    void     | Increments the index. Will throw `IndexOutOfRangeException` if the current index is already at its upper limit. |
| Reset()               |    void     | Sets the index to 0.                                                                                            |
| MoveNextOrReset()     |    void     | Increments the index, or sets it to 0 if it's already at its upper limit.                                       |
| DisplayValue(Boolean) |   String    | Returns the current item's display value as a string. Optionally limited to only ASCII characters.              |
