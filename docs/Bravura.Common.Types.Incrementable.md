# Incrementable Class

Namespace: [Bravura.Common.Types](./Bravura.Common.Types.md)

### A class for storing and updating an integer value.

```csharp
public class Incrementable
```

Inheritance: Object -> Incrementable

## Constructors
| Constructor | Description |
| --- | --- |
| Incrementable(Int32) | Initializes a new instance of the [Incrementable](./Bravura.Common.Types.Incrementable.md) class and initializes the weight with the provided value, defaults to 0. |

## Properties
| Property | Return Value | Description |
| --- | --- | -- |
| Weight | Int32 | The current weight. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| Apply(Int32) | Int32 | Adds the provided integer (defaults to 1) to the current weight and returns the result. |
| ApplyIf(Boolean, Int32) | Int32 | Adds the provided integer (defaults to 1) to the current weight if the boolean expression evaluates to `true`, and then returns the result. |
