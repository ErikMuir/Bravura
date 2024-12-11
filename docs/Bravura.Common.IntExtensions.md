# IntExtensions Class

Namespace: [Bravura.Common](./Bravura.Common.md)

### Provides utility methods for working with integers.

```csharp
public static class IntExtensions
```

Inheritance: Object -> IntExtensions

## Methods
| Method                     | Return Type | Description                                                                                                                                                                                                                      |
|----------------------------|:-----------:|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| RollingRange(Int32, Int32) |    Int32    | Returns the current integer when inclusively within the range defined by the specified low and high. Otherwise it will roll over the other end of the range one or mote times until the resulting value is within the range.     |
| RollingRange(Int32)        |    Int32    | Returns the current integer when inclusively within the range defined by 0 and the specified high value. Otherwise it will roll over the other end of the range one or mote times until the resulting value is within the range. |

## Examples
```csharp
var value_A = 3;
var result_A = value_A.RollingRange(1, 7);

var value_B = -1;
var result_B = value_B.RollingRange(1, 7);

var value_C = 9;
var result_C = value_C.RollingRange(1, 7);

Console.WriteLine("result_A: " + result_A);
Console.WriteLine("result_B: " + result_B);
Console.WriteLine("result_C: " + result_C);

// This should produce the following output:
//      result_A: 3
//      result_B: 6
//      result_C: 2
```
