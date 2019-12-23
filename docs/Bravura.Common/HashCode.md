# HashCode Struct

Namespace: [Bravura.Common](./Bravura.Common.md)

### Calculates the hash code of one or more values.

```csharp
public struct HashCode
```

Inheritance: Object -> ValueType -> HashCode

## Constructors
| Constructor | Description |
| --- | --- |
| HashCode(Int32) | Initializes a new instance of the [HashCode](./HashCode.md) struct with the specified integer value. |

## Properties
| Property | Type | Description |
| --- | --- | --- |
| Start | [HashCode](./HashCode.md) | Static property that returns a new instance of [HashCode](./HashCode.md) initialized with 17. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| Hash\<T>(T) | [HashCode](./HashCode.md) | Returns a new [HashCode](./HashCode.md) with the hashed value of T added to the initial hash value. |
| GetHashCode() | Int32 | Returns the hashed value of the instance. |

## Operators
| Operator | Return Type | Description |
| --- | --- | --- |
| implicit operator int([HashCode](./HashCode.md)) | Int32 | Returns the hashed value of the instance. |
