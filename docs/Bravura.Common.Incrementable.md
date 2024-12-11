# Incrementable Class

Namespace: [Bravura.Common](./Bravura.Common.md)

### A class for storing and updating an integer value.

```csharp
public class Incrementable
```

Inheritance: Object -> Incrementable

## Constructors
| Constructor          | Description                                                                                                                                                         |
|----------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Incrementable(Int32) | Initializes a new instance of the [Incrementable](./Bravura.Common.Types.Incrementable.md) class and initializes the weight with the provided value, defaults to 0. |

## Properties
| Property | Return Value | Description         |
|----------|:------------:|---------------------|
| Weight   |    Int32     | The current weight. |

## Methods
| Method                      | Return Type | Description                                                                                                                                      |
|-----------------------------|:-----------:|--------------------------------------------------------------------------------------------------------------------------------------------------|
| Increment(Int32)            |    Int32    | Adds the provided integer (defaults to 1) to the current weight and returns the result.                                                          |
| IncrementIf(Boolean, Int32) |    Int32    | Adds the provided integer (defaults to 1) to the current weight if the boolean expression evaluates to `true`, and then returns the result.      |
| Decrement(Int32)            |    Int32    | Subtracts the provided integer (defaults to 1) to the current weight and returns the result.                                                     |
| DecrementIf(Boolean, Int32) |    Int32    | Subtracts the provided integer (defaults to 1) to the current weight if the boolean expression evaluates to `true`, and then returns the result. |
