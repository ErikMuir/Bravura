# Chord Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the combination of a Pitch and a ChordQuality.

```csharp
public record Chord : IBaseTonality
```

Inheritance: Object -> Chord
Implements: [IBaseTonality](./IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Chord([Pitch](./Pitch.md), [ChordQuality](./ChordQuality.md)) | Initializes a new instance of the [Chord](./Chord.md) record. |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Pitch.md) | The root pitch of the chord. |
| Quality | [ChordQuality](./ChordQuality.md) | The quality of the chord. |
| Pitches | List<[Pitch](./Pitch.md)> | The list of pitches that make up the chord. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| CommonTones([Chord](./Chord.md)) | List<[Pitch](./Pitch.md)> | Returns a list of pitches that the specified chord shares with the current chord. |
| HasSamePitches([Chord](./Chord.md)) | Boolean | Determines whether the specified chord has the same pitches as the current chord. |
| EnharmonicallyEquals([Chord](./Chord.md)) | Boolean | Determines whether the specified chord's root enharmonically equals the current chord's root and the specified chord's quality effectively equals the current chord's quality. |
| DisplayValue(Boolean) | String | Returns the string representation of the chord, optionally limited to only ASCII characters. |
| DisplayValueWithPitches(Boolean) | String | Returns the string representation of the chord including its pitches, optionally limited to only ASCII characters. |
| Transpose([Direction](./Direction.md), [Interval](./Interval.md)) | [Chord](./Chord.md) | Returns the chord transposed by the provided interval in the provided direction. |
| TryParse(String, out [Chord](./Chord.md)) | Boolean | Converts the string representation of a chord to an instance of a [Chord](./Chord.md). A return value indicates whether the conversion succeeded. |
