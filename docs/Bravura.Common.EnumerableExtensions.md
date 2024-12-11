# EnumerableExtensions Class

Namespace: [Bravura.Common](./Bravura.Common.md)

### Provides utility methods for working with Enumerable types.

```csharp
public static class EnumerableExtensions
```

Inheritance: Object -> EnumerableExtensions

## Methods
| Method                                  |   Return Type    | Description                                                                                                |
|-----------------------------------------|:----------------:|------------------------------------------------------------------------------------------------------------|
| ToJoinedString()                        |      String      | A Fluent wrapper around `string.Join()`.                                                                   |
| WhereIf\<T\>(Boolean, IEnumerable\<T\>) | IEnumerable\<T\> | A wrapper around `IEnumerable<T>.Where()` to optionally apply the predicate based on a Boolean expression. |
