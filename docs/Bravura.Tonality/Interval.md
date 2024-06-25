# Interval Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the distance between two pitches.

```csharp
public record Interval : IBaseTonality
```

Inheritance: Object -> Interval
Implements: [IBaseTonality](./IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Interval(Int32, [Accidental](./Accidental.md), Int32, String, String) | Initializes a new instance of the [Interval](./Interval.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Semitones | Int32 | The size of the interval in semitones. |
| Accidental | [Accidental](./Accidental.md) | |
| Degree | Int32 | The count of note indices that the interval spans. |
| Name | String | The name for this instance. |
| Symbol | String | The symbol for this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([Interval](./Interval.md)) | Boolean | Determines whether the specified interval has the same semitones as the current interval. |
| DisplayValue(Boolean) | String | Returns the string representation of the interval, optionally limited to only ASCII characters. |
| TryParse(String, out [Interval](./Interval.md)) | Boolean | Converts the string representation of an interval to an instance of an [Interval](./Interval.md). A return value indicates whether the conversion succeeded. |

\* See the static class [Intervals](./Intervals.md) for all instances.
