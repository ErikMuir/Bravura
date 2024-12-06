# ChordQuality Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the quality of a chord and the intervals that it consists of.

```csharp
public record ChordQuality : IBaseTonality
```

Inheritance: Object -> ChordQuality
Implements: [IBaseTonality](./IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| ChordQuality(String, String, List<[Interval](./Bravura.Tonality.Interval.md)>) | Initializes a new instance of the [ChordQuality](./Bravura.Tonality.ChordQuality.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Symbol | String | The symbol for this instance. |
| AsciiSymbol | String | The ASCII symbol for this instance. |
| Intervals | List<[Interval](./Bravura.Tonality.Interval.md)> | The intervals that make up this instance. |
| IsMajor | Boolean | Indicates whether the chord is major. |
| IsMinor | Boolean | Indicates whether the chord is minor. |
| IsDiminished | Boolean | Indicates whether the chord is diminished. |
| IsAugmented | Boolean | Indicates whether the chord is augmented. |
| IsDominant | Boolean | Indcates whether the chord is dominant. |
| IsAltered | Boolean | Indicates whether the chord is altered. |
| IsSuspended | Boolean | Indicates whether the chord is suspended. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([ChordQuality](./Bravura.Tonality.ChordQuality.md)) | Boolean | Determines whether the specified chord quality has the same semitones as the current chord quality. |
| Contains([Interval](./Bravura.Tonality.Interval.md)) | Boolean | Determines whether the specified interval is contained in the current chord quality's intervals. |
| DisplayValue(Boolean) | String | Returns the string representation of the chord quality, optionally limited to only ASCII characters. |
| DisplayValueWithIntervals(Boolean) | String | Returns the string representation of the chord quality including its intervals, optionally limited to only ASCII characters. |
| TryParse(String, out [ChordQuality](./Bravura.Tonality.ChordQuality.md)) | Boolean | Converts the string representation of a chord quality to an instance of a [ChordQuality](./Bravura.Tonality.ChordQuality.md). A return value indicates whether the conversion succeeded. |

\* See the static class [ChordQualities](./Bravura.Tonality.ChordQualities.md) for all instances.
