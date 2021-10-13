# ChordQuality Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the quality of a chord and the intervals that it consists of.

```csharp
public record ChordQuality
```

Inheritance: Object -> ChordQuality

## Constructors
| Constructor | Description |
| --- | --- |
| ChordQuality(String, String, List<[Interval](./Interval.md)>) | Initializes a new instance of the [ChordQuality](./ChordQuality.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Symbol | String | The symbol for this instance. |
| AsciiSymbol | String | The ASCII symbol for this instance. |
| Intervals | List<[Interval](./Interval.md)> | The intervals that make up this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([ChordQuality](./ChordQuality.md)) | Boolean | Determines whether the specified chord quality has the same semitones as the current chord quality. |
| ToString() | String | Returns the string representation of the chord quality. |
| ToAsciiString() | String | Returns the ASCII string representation of the chord quality. |
| ToStringWithIntervals() | String | Returns the string representation of the chord quality, including its intervals. |
| ToAsciiStringWithIntervals() | String | Returns the ASCII string representation of the chord quality, including its intervals. |
| TryParse(String, [ChordQuality](./ChordQuality.md)) | Boolean | Converts the string representation of a chord quality to an instance of a [ChordQuality](./ChordQuality.md). A return value indicates whether the conversion succeeded.

\* See the static class [ChordQualities](./ChordQualities.md) for all instances.
