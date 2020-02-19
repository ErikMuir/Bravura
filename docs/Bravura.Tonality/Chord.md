# Chord Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the combination of a Pitch and a ChordQuality.

```csharp
public class Chord
```

Inheritance: Object -> Chord

## Constructors
| Constructor | Description |
| --- | --- |
| Chord([Pitch](./Pitch.md), [ChordQuality](./ChordQuality.md)) | Initializes a new instance of the [Chord](./Chord.md) class. |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Pitch.md) | The root pitch of the chord. |
| Quality | [ChordQuality](./ChordQuality.md) | The quality of the chord. |
| Pitches | List<[Pitch](./Pitch.md)> | The list of pitches that make up the chord. |
| NoteSymbols | List\<String> | The list of note symbols that make up the chord. |
| AsciiNoteSymbols | List\<String> | The list of ASCII note symbols that make up the chord. |
| ChordTones | List\<String> | The list of chord tones that make up the chord. |
| AsciiChordTones | List\<String> | The list of ASCII chord tones that make up the chord. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| CommonTones([Chord](./Chord.md)) | List<[Pitch](./Pitch.md)> | Returns a list of pitches that the specified chord shares with the current chord. |
| HasSamePitches([Chord](./Chord.md)) | Boolean | Determines whether the specified chord has the same pitches as the current chord. |
| EnharmonicallyEquals([Chord](./Chord.md)) | Boolean | Determines whether the specified chord's root enharmonically equals the current chord's root and the specified chord's quality effectively equals the current chord's quality. |
| Equals([Chord](./Chord.md)) | Boolean | Determines whether the specified chord is equal to the current chord. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |
