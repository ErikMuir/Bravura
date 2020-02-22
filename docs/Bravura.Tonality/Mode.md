# Mode Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical mode and the intervals that it consists of.

```csharp
public class Mode
```

Inheritance: Object -> Mode

## Constructors
| Constructor | Description |
| --- | --- |
| Mode(String, List<[Interval](./Interval.md)>) | Initializes a new instance of the [Mode](./Mode.md) class. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Name | String | The name for this instance. |
| Intervals | List<[Interval](./Interval.md)> | The intervals that make up this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([Mode](./Mode.md)) | Boolean | Determines whether the specified mode has the same semitones as the current mode. |
| Equals([Mode](./Mode.md)) | Boolean | Determines whether the specified mode is equal to the current mode. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |

\* See the static class [Modes](./Modes.md) for all instances.
