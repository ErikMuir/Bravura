# Pitch Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the combination of a Note and an Accidental.

```csharp
public class Pitch
```

Inheritance: Object -> Pitch

## Constructors
| Constructor | Description |
| --- | --- |
| Pitch([Note](./Note.md), [Accidental](./Accidental.md)) | Initializes a new instance of the [Pitch](./Pitch.md) class. |

## Properties
| Property | Type | Description |
| --- | --- | --- |
| Note | [Note](./Note.md) | The note. |
| Accidental | [Accidental](./Accidental.md) | The accidental. |
| SemitonesAboveC | Int32 | The distance (in semitones) above C natural. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| Logical() | [Pitch](./Pitch.md) | The enharmonically equal pitch whose accidental is closest to natural if one exists, otherwise returns itself. |
| GetPitchByIntervalAbove([Interval](./Interval.md)) | [Pitch](./Pitch.md) | The pitch found when moving up by the specified interval. |
| GetPitchByIntervalBelow([Interval](./Interval.md)) | [Pitch](./Pitch.md) | The pitch found when moving down by the specified interval. |
| ToString() | String | Returns the string representation of the pitch. |
| ToAsciiString() | String | Returns the ASCII string representation of the pitch. |
| EnharmonicallyEquals([Pitch](./Pitch.md)) | Boolean | Indicates whether the specified pitch is enharmonically equal to the current pitch. (Two pitches are considered to be enharmonically equal when their distance (in semitones) above C natural are the same.) |
| Equals([Pitch](./Pitch.md)) | Boolean | Determines whether the specified pitch is equal to the current pitch. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |

\* See the static class [Pitches](./Pitches.md) for all instances.
