# Note Struct

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents one letter of the musical alphabet.

```csharp
public struct Note : IBaseTonality
```

Inheritance: Object -> ValueType -> Note
Implements: [IBaseTonality](./IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Note(Char, Int16) | Initializes a new instance of the [Note](./Note.md) struct. This constructor is `internal` so Bravura consumers cannot initialize new instances. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Letter | Char | The note letter. |
| SemitonesAboveC | Int16 | The number of semitones above C. |
| KeyValuePair | KeyValuePair<Char, Int16> | The key/value pair, where the key is `Letter` and the value is `SemitonesAboveC`. |
| Index | Int32 | The index of this instance's `Letter` from `Notes.MusicalAlphabet`. |
| PreviousIndex | Int32 | The index of the previous note in `Notes.MusicalAlphabet`. |
| NextIndex | Int32 | The index of the next note in `Notes.MusicalAlphabet`. |
| PreviousNote | [Note](./Note.md) | The previous note in `Notes.MusicalAlphabet`. |
| NextNote | [Note](./Note.md) | The next note in `Notes.MusicalAlphabet`. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| IsPreviousNoteOneSemitoneAway() | Boolean | Indicates whether the previous note in `Notes.MusicalAlphabet` is only one semitone away. |
| IsNextNoteOneSemitoneAway() | Boolean | Indicates whether the next note in `Notes.MusicalAlphabet` is only one semitone away. |
| GetNoteByIndex(Int32) | [Note](./Note.md) | Gets the note at the specified index of `Notes.MusicalAlphabet` |
| DisplayValue(Boolean) | String | Returns the note letter, optionally limited to only ASCII characters. |

\* See the static class [Notes](./Notes.md) for all instances.
