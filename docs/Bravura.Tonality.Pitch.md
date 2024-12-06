# Pitch Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the combination of a Note and an Accidental.

```csharp
public record Pitch : IBaseTonality
```

Inheritance: Object -> Pitch
Implements: [IBaseTonality](./Bravura.Tonality.IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Pitch([Note](./Bravura.Tonality.Note.md), [Accidental](./Bravura.Tonality.Accidental.md)) | Initializes a new instance of the [Pitch](./Bravura.Tonality.Pitch.md) record. |

## Properties
| Property | Type | Description |
| --- | --- | --- |
| Note | [Note](./Bravura.Tonality.Note.md) | The note. |
| Accidental | [Accidental](./Bravura.Tonality.Accidental.md) | The accidental. |
| SemitonesAboveC | Int32 | The distance (in semitones) above C natural. |
| IsFlat | Boolean | Describes whether or not the pitch's accidental is flat or double flat. |
| IsSharp | Boolean | Describes whether or not the pitch's accidental sharp or double sharp. |
| Logical | [Pitch](./Bravura.Tonality.Pitch.md) | The enharmonically equal pitch whose accidental is closest to natural if one exists, otherwise returns itself. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| Transpose([Direction](./Bravura.Tonality.Direction.md), [Interval](./Bravura.Tonality.Interval.md)) | [Pitch](./Bravura.Tonality.Pitch.md) | Returns the pitch transposed by the provided interval in the provided direction. |
| DisplayValue(Boolean) | String | Returns the string representation of the pitch, optionally limited to only ASCII characters. |
| DisplayValueWithNaturals() | String | Returns the string representation of the pitch including the natural symbol. |
| EnharmonicallyEquals([Pitch](./Bravura.Tonality.Pitch.md)) | Boolean | Indicates whether the specified pitch is enharmonically equal to the current pitch. (Two pitches are considered to be enharmonically equal when their distance (in semitones) above C natural are the same.) |
| TryParse(String, out [Pitch](./Bravura.Tonality.Pitch.md)) | Boolean | Converts the string representation of a pitch to an instance of a [Pitch](./Bravura.Tonality.Pitch.md). A return value indicates whether the conversion succeeded. |

\* See the static class [Pitches](./Bravura.Tonality.Pitches.md) for all instances.
