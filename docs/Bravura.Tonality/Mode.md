# Mode Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical mode and the intervals that it consists of.

```csharp
public record Mode : IBaseTonality
```

Inheritance: Object -> Mode
Implements: [IBaseTonality](./IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Mode(String, List<[Interval](./Interval.md)>) | Initializes a new instance of the [Mode](./Mode.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Name | String | The name for this instance. |
| Intervals | List<[Interval](./Interval.md)> | The intervals that make up this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([Mode](./Mode.md)) | Boolean | Determines whether the specified mode has the same intervals as the current mode. |
| DisplayValue(Boolean) | String | Returns the name of the mode, optionally limited to only ASCII characters. |
| DisplayValueWithIntervals(Boolean) | String | Returns the string representation of the mode including its intervals, optionally limited to only ASCII characters. |

\* See the static class [Modes](./Modes.md) for all instances.
