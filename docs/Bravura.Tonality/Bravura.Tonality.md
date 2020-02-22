# Bravura.Tonality Namespace

The [Bravura.Tonality](./Bravura.Tonality.md) namespace contains fundamental classes that provide the harmonic building blocks of music.

## Classes
| Class | Description |
| --- | --- |
| [Accidentals](./Accidentals.md) | Static class that exposes each accidental, as well as a read-only list of all accidentals. |
| [BravuraTonalityException](./BravuraTonalityException.md) | The base exception class for all Bravura.Tonality exceptions. |
| [Chord](./Chord.md) | Represents the combination of a [Pitch](./Pitch.md) and a [ChordQuality](./ChordQuality.md). |
| [ChordException](./ChordException.md) | The exception that is thrown when trying to instantiate an invalid Chord. |
| [ChordQualities](./ChordQualities.md) | Static class that exposes each chord quality, as well as a read-only list of all chord qualities. |
| [ChordQuality](./ChordQuality.md) | Represents the quality of a chord and the intervals that it consists of. |
| [ChordQualityException](./ChordQualityException.md) | The exception that is thrown when trying to instantiate an invalid ChordQuality. |
| [Interval](./Interval.md) | Represents the distance between two pitches. |
| [IntervalException](./IntervalException.md) | The exception that is thrown when trying to instantiate an invalid Interval. |
| [Intervals](./Intervals.md) | Static class that exposes each interval, as well as a read-only list of all intervals. |
| [Key](./Key.md) | Represents the combination of a [Pitch](./Pitch.md) and a [Tonality](./Tonality.md). |
| [Keys](./Keys.md) | Static class that exposes each key, as well as read-only lists of keys. |
| [Mode](./Mode.md) | Represents a musical mode and the intervals that it consists of. |
| [ModeException](./ModeException.md) | The exception that is thrown when trying to instantiate an invalid Mode. |
| [Modes](./Modes.md) | Static class that exposes each mode, as well as a read-only list of all modes. |
| [Notes](./Notes.md) | Static class that exposes all 7 notes, as well as the musical alphabet. |
| [Pitch](./Pitch.md) | Represents the combination of a [Note](./Note.md) and an [Accidental](./Accidental.md). |
| [Pitches](./Pitches.md) | Static class that exposes each pitch, as well as several read-only lists of pitches grouped by commonalities. |
| [Scale](./Scale) | |
| [ScaleException](./ScaleException.md) | The exception that is thrown when trying to instantiate an invalid Scale. |

## Structs
| Struct | Description |
| --- | --- |
| [Accidental](./Accidental.md) | Represents an alteration to a note or scale tone by 0, 1, or 2 semitones in either direction. |
| [Note](./Note.md) | Represents one letter of the musical alphabet. |

## Enums
| Enum | Description |
| --- | --- |
| [Tonality](./Tonality.md) | Specifies the tonality of a Key. |
