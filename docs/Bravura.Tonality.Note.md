# Note Struct

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents one letter of the musical alphabet.

```csharp
public struct Note : ITonality
```

Inheritance: Object -> ValueType -> Note
Implements: [ITonality](./Bravura.Tonality.ITonality.md)

## Constructors
| Constructor       | Description                                                                                                                                                         |
|-------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Note(Char, Int16) | Initializes a new instance of the [Note](./Bravura.Tonality.Note.md) struct. This constructor is `internal` so Bravura consumers cannot initialize new instances. * |

## Fields
| Field           |                Type                | Description                                                                       |
|-----------------|:----------------------------------:|-----------------------------------------------------------------------------------|
| Letter          |                Char                | The note letter.                                                                  |
| SemitonesAboveC |               Int16                | The number of semitones above C.                                                  |
| KeyValuePair    |     KeyValuePair<Char, Int16>      | The key/value pair, where the key is `Letter` and the value is `SemitonesAboveC`. |
| Index           |               Int32                | The index of this instance's `Letter` from `Notes.MusicalAlphabet`.               |
| PreviousIndex   |               Int32                | The index of the previous note in `Notes.MusicalAlphabet`.                        |
| NextIndex       |               Int32                | The index of the next note in `Notes.MusicalAlphabet`.                            |
| PreviousNote    | [Note](./Bravura.Tonality.Note.md) | The previous note in `Notes.MusicalAlphabet`.                                     |
| NextNote        | [Note](./Bravura.Tonality.Note.md) | The next note in `Notes.MusicalAlphabet`.                                         |

## Methods
| Method                          |            Return Type             | Description                                                                               |
|---------------------------------|:----------------------------------:|-------------------------------------------------------------------------------------------|
| IsPreviousNoteOneSemitoneAway() |              Boolean               | Indicates whether the previous note in `Notes.MusicalAlphabet` is only one semitone away. |
| IsNextNoteOneSemitoneAway()     |              Boolean               | Indicates whether the next note in `Notes.MusicalAlphabet` is only one semitone away.     |
| GetNoteByIndex(Int32)           | [Note](./Bravura.Tonality.Note.md) | Gets the note at the specified index of `Notes.MusicalAlphabet`                           |
| ToString()                      |               String               | Returns the note letter.                                                                  |

\* See the static class [Notes](./Bravura.Tonality.Notes.md) for all instances.
