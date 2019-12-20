# Note Struct

Namespace: Bravura.Tonality<br/>
Represents a letter of the musical alphabet.

```
public struct Note
```

## Constructors
| Constructor | Description |
| --- | --- |
| Note(Char, Int16) | Initializes a new instance of the `Note` struct. This constructor is `internal` so Bravura consumers cannot initialize new instances. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Letter | Char | Gets the letter for this instance. |
| SemitonesAboveC | Int16 | Gets the number of semitones above C. |
| KeyValuePair | KeyValuePair<Char, Int16> | Gets the key/value pair, where the key is `Letter` and the value is `SemitonesAboveC`. |
| Index | Int32 | Gets the index of this instance's `Letter` from `Notes.MusicalAlphabet`. |
| PreviousIndex | Int32 | Gets the index of the previous note in `Notes.MusicalAlphabet`. |
| NextIndex | Int32 | Gets the index of the next note in `Notes.MusicalAlphabet`. |
| PreviousNote | Note | Gets the previous note in `Notes.MusicalAlphabet`. |
| NextNote | Note | Gets the next note in `Notes.MusicalAlphabet`. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| IsPreviousNoteOneSemitoneAway() | Boolean | Indicates whether the previous note in `Notes.MusicalAlphabet` is only one semitone away. |
| IsNextNoteOneSemitoneAway() | Boolean | Indicates whether the next note in `Notes.MusicalAlphabet` is only one semitone away. |
| GetNoteByIndex(Int32) | Note | Gets the note at the specified index of `Notes.MusicalAlphabet` |
| Equals(Note) | Boolean | Determines whether the specified `Note` is equal to the current `Note`. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |

\* See the static class [Notes](/docs/Notes.md) for all instances.
