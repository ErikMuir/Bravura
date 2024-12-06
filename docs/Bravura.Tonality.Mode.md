# Mode Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical mode and the intervals that it consists of.

```csharp
public record Mode : IBaseTonality
```

Inheritance: Object -> Mode
Implements: [IBaseTonality](./Bravura.Tonality.IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Mode(String, List<[Interval](./Bravura.Tonality.Interval.md)>) | Initializes a new instance of the [Mode](./Bravura.Tonality.Mode.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Name | String | The name for this instance. |
| Intervals | List<[Interval](./Bravura.Tonality.Interval.md)> | The intervals that make up this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([Mode](./Bravura.Tonality.Mode.md)) | Boolean | Determines whether the specified mode has the same intervals as the current mode. |
| DisplayValue(Boolean) | String | Returns the name of the mode, optionally limited to only ASCII characters. |
| DisplayValueWithIntervals(Boolean) | String | Returns the string representation of the mode including its intervals, optionally limited to only ASCII characters. |

\* See the static class [Modes](./Bravura.Tonality.Modes.md) for all instances.
