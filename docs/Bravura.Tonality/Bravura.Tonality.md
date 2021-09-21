# Bravura.Tonality Namespace

The [Bravura.Tonality](./Bravura.Tonality.md) namespace contains fundamental classes that provide the harmonic building blocks of music.

## Classes
| Class | Description |
| --- | --- |
| [Accidentals](./Accidentals.md) | Static class that exposes each [Accidental](./Accidental.md), as well as a read-only list of all accidentals. |
| [BravuraTonalityException](./BravuraTonalityException.md) | The base exception class for all [Bravura.Tonality](./Bravura.Tonality.md) exceptions. |
| [Chord](./Chord.md) | Represents the combination of a [Pitch](./Pitch.md) and a [ChordQuality](./ChordQuality.md). |
| [ChordException](./ChordException.md) | The exception that is thrown when trying to instantiate an invalid [Chord](./Chord.md). |
| [ChordQualities](./ChordQualities.md) | Static class that exposes each [ChordQuality](./ChordQuality.md), as well as a read-only list of all chord qualities. |
| [ChordQuality](./ChordQuality.md) | Represents the quality of a [Chord](./Chord.md) and the [Intervals](./Interval.md) that it consists of. |
| [ChordQualityException](./ChordQualityException.md) | The exception that is thrown when trying to instantiate an invalid [ChordQuality](./ChordQuality.md). |
| [ChromaticScale](./ChromaticScale.md) | Represents a chromatic [Scale](./Scale.md) starting from a given root [Pitch](./Pitch.md). |
| [Interval](./Interval.md) | Represents the distance between two [Pitches](./Pitch.md). |
| [IntervalException](./IntervalException.md) | The exception that is thrown when trying to instantiate an invalid [Interval](./Interval.md). |
| [Intervals](./Intervals.md) | Static class that exposes each [Interval](./Interval.md), as well as a read-only list of all intervals. |
| [Key](./Key.md) | Represents the combination of a [Pitch](./Pitch.md) and a [Modality](./Modality.md). |
| [Keys](./Keys.md) | Static class that exposes each [Key](./Key.md), as well as read-only lists of keys. |
| [Mode](./Mode.md) | Represents a musical mode and the [Intervals](./Interval.md) that it consists of. |
| [ModeException](./ModeException.md) | The exception that is thrown when trying to instantiate an invalid [Mode](./Mode.md). |
| [Modes](./Modes.md) | Static class that exposes each [Mode](./Mode.md), as well as a read-only list of all modes. |
| [Notes](./Notes.md) | Static class that exposes all 7 notes, as well as the musical alphabet. |
| [Pitch](./Pitch.md) | Represents the combination of a [Note](./Note.md) and an [Accidental](./Accidental.md). |
| [Pitches](./Pitches.md) | Static class that exposes each [Pitch](./Pitch.md), as well as several read-only lists of pitches grouped by commonalities. |
| [Scale](./Scale) | Represents a musical scale and the root [Pitch](./Pitch.md) and [Mode](./Mode.md) that it consists of. |
| [ScaleException](./ScaleException.md) | The exception that is thrown when trying to instantiate an invalid [Scale](./Scale.md). |

## Structs
| Struct | Description |
| --- | --- |
| [Accidental](./Accidental.md) | Represents an alteration to a [Note](./Notes.md) or [Scale](./Scale.md) degree by 0, 1, or 2 semitones in either direction. |
| [Note](./Note.md) | Represents one letter of the musical alphabet. |

## Enums
| Enum | Description |
| --- | --- |
| [EnharmonicPreference](./EnharmonicPreference.md) | Specifies a preference for flat or sharp when expressing [Pitches](./Pitch.md) enharmonically. |
| [Modality](./Modality.md) | Specifies the modality of a [Key](./Key.md). |
