# StringExtensions Class

Namespace: [Bravura.Common](./Bravura.Common.md)

### Provides utility methods for working with strings.

```csharp
public static class StringExtensions
```

Inheritance: Object -> StringExtensions

## Methods
| Method               | Return Type | Description                                                                                                                                                |
|----------------------|:-----------:|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| IsNullOrWhiteSpace() |   Boolean   | Returns true if the value is null or only white-space, otherwise false.                                                                                    |
| TrimToNull()         |   String    | Returns null if the current string is null or only whitespace. Otherwise, removes all leading and trailing white-space characters from the current string. |
| SafeTrim()           |   String    | Removes all leading and trailing white-space characters from the current string. When null, returns null.                                                  |
| ToAscii()            |   String    | Converts specific musical Unicode characters into their ASCII equivalent.                                                                                  |
| FromAscii()          |   String    | Converts specific musical ASCII characters into their Unicode equivalent.                                                                                  |
