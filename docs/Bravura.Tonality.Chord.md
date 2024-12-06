# Chord Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the combination of a Pitch and a ChordQuality.

```csharp
public record Chord : IBaseTonality
```

Inheritance: Object -> Chord
Implements: [IBaseTonality](./Bravura.Tonality.IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Chord([Pitch](./Bravura.Tonality.Pitch.md), [ChordQuality](./Bravura.Tonality.ChordQuality.md)) | Initializes a new instance of the [Chord](./Bravura.Tonality.Chord.md) record. |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Bravura.Tonality.Pitch.md) | The root pitch of the chord. |
| Quality | [ChordQuality](./Bravura.Tonality.ChordQuality.md) | The quality of the chord. |
| Pitches | List<[Pitch](./Bravura.Tonality.Pitch.md)> | The list of pitches that make up the chord. |
| PotentialKeys | List<[Key](./Bravura.Tonality.Key.md)> | The list of keys that this chord fits into diatonically. |
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
| CommonTones([Chord](./Bravura.Tonality.Chord.md)) | List<[Pitch](./Bravura.Tonality.Pitch.md)> | Returns a list of pitches that the specified chord shares with the current chord. |
| HasSamePitches([Chord](./Bravura.Tonality.Chord.md)) | Boolean | Determines whether the specified chord has the same pitches as the current chord. |
| EnharmonicallyEquals([Chord](./Bravura.Tonality.Chord.md)) | Boolean | Determines whether the specified chord's root enharmonically equals the current chord's root and the specified chord's quality effectively equals the current chord's quality. |
| Contains([Interval](./Bravura.Tonality.Interval.md)) | Boolean | Determines whether the specified interval is contained in the current chord quality's intervals. |
| DisplayValue(Boolean) | String | Returns the string representation of the chord, optionally limited to only ASCII characters. |
| DisplayValueWithPitches(Boolean) | String | Returns the string representation of the chord including its pitches, optionally limited to only ASCII characters. |
| Transpose([Direction](./Bravura.Tonality.Direction.md), [Interval](./Bravura.Tonality.Interval.md)) | [Chord](./Bravura.Tonality.Chord.md) | Returns the chord transposed by the provided interval in the provided direction. |
| TryParse(String, out [Chord](./Bravura.Tonality.Chord.md)) | Boolean | Converts the string representation of a chord to an instance of a [Chord](./Bravura.Tonality.Chord.md). A return value indicates whether the conversion succeeded. |
