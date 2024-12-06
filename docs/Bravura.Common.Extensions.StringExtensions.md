# StringExtensions Class

Namespace: [Bravura.Common.Extensions](./Bravura.Common.Extensions.md)

### Provides utility methods for working with strings.

```csharp
public static class StringExtensions
```

Inheritance: Object -> StringExtensions

## Methods
| Method | Return Type | Description |
| --- | :---: | --- |
| TrimToNull() | String | Returns null if the current string is null or only whitespace. Otherwise, removes all leading and trailing white-space characters from the current string. |
| SafeTrim() | String | Removes all leading and trailing white-space characters from the current string. When null, returns null. |
