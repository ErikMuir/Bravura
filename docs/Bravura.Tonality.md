# Bravura.Tonality Namespace

The [Bravura.Tonality](./Bravura.Tonality.md) namespace contains fundamental classes that provide the harmonic building blocks of music.

## Classes
| Class | Description |
| --- | --- |
| [Accidentals](./Bravura.Tonality.Accidentals.md) | Static class that exposes each [Accidental](./Bravura.Tonality.Accidental.md), as well as a read-only list of all accidentals. |
| [Chord](./Bravura.Tonality.Chord.md) | Represents the combination of a [Pitch](./Bravura.Tonality.Pitch.md) and a [ChordQuality](./Bravura.Tonality.ChordQuality.md). |
| [ChordQualities](./Bravura.Tonality.ChordQualities.md) | Static class that exposes each [ChordQuality](./Bravura.Tonality.ChordQuality.md), as well as a read-only list of all chord qualities. |
| [ChordQuality](./Bravura.Tonality.ChordQuality.md) | Represents the quality of a [Chord](./Bravura.Tonality.Chord.md) and the [Intervals](./Bravura.Tonality.Interval.md) that it consists of. |
| [ChromaticScale](./Bravura.Tonality.ChromaticScale.md) | Represents a chromatic [Scale](./Bravura.Tonality.Scale.md) starting from a given root [Pitch](./Bravura.Tonality.Pitch.md). |
| [Interval](./Bravura.Tonality.Interval.md) | Represents the distance between two [Pitches](./Bravura.Tonality.Pitch.md). |
| [Intervals](./Bravura.Tonality.Intervals.md) | Static class that exposes each [Interval](./Bravura.Tonality.Interval.md), as well as a read-only list of all intervals. |
| [Key](./Bravura.Tonality.Key.md) | Represents the combination of a [Pitch](./Bravura.Tonality.Pitch.md) and a [Modality](./Bravura.Tonality.Modality.md). |
| [Keys](./Bravura.Tonality.Keys.md) | Static class that exposes each [Key](./Bravura.Tonality.Key.md), as well as read-only lists of keys. |
| [Mode](./Bravura.Tonality.Mode.md) | Represents a musical mode and the [Intervals](./Bravura.Tonality.Interval.md) that it consists of. |
| [Modes](./Bravura.Tonality.Modes.md) | Static class that exposes each [Mode](./Bravura.Tonality.Mode.md), as well as a read-only list of all modes. |
| [Notes](./Bravura.Tonality.Notes.md) | Static class that exposes all 7 notes, as well as the musical alphabet. |
| [Pitch](./Bravura.Tonality.Pitch.md) | Represents the combination of a [Note](./Bravura.Tonality.Note.md) and an [Accidental](./Bravura.Tonality.Accidental.md). |
| [Pitches](./Bravura.Tonality.Pitches.md) | Static class that exposes each [Pitch](./Bravura.Tonality.Pitch.md), as well as several read-only lists of pitches grouped by commonalities. |
| [RomanNumerals](./Bravura.Tonality.RomanNumerals.md) | todo |
| [Scale](./Bravura.Tonality.Scale) | Represents a musical scale and the root [Pitch](./Bravura.Tonality.Pitch.md) and [Mode](./Bravura.Tonality.Mode.md) that it consists of. |
| [TonalityExtensions](./Bravura.Tonality.TonalityExtensions.md) | todo |

## Structs
| Struct | Description |
| --- | --- |
| [Accidental](./Bravura.Tonality.Accidental.md) | Represents an alteration to a [Note](./Bravura.Tonality.Notes.md) or [Scale](./Bravura.Tonality.Scale.md) degree by 0, 1, or 2 semitones in either direction. |
| [Note](./Bravura.Tonality.Note.md) | Represents one letter of the musical alphabet. |

## Enums
| Enum | Description |
| --- | --- |
| [Modality](./Bravura.Tonality.Modality.md) | Specifies the modality of a [Key](./Bravura.Tonality.Key.md). |
