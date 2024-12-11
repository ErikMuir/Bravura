# Interval Record

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the distance between two pitches.

```csharp
public record Interval : ITonality
```

Inheritance: Object -> Interval
Implements: [ITonality](./Bravura.Tonality.ITonality.md)

## Constructors
| Constructor                                                                            | Description                                                                            |
|----------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------|
| Interval(Int32, [Accidental](./Bravura.Tonality.Accidental.md), Int32, String, String) | Initializes a new instance of the [Interval](./Bravura.Tonality.Interval.md) record. * |

## Fields
| Field      |                      Type                      | Description                                        |
|------------|:----------------------------------------------:|----------------------------------------------------|
| Semitones  |                     Int32                      | The size of the interval in semitones.             |
| Accidental | [Accidental](./Bravura.Tonality.Accidental.md) |                                                    |
| Degree     |                     Int32                      | The count of note indices that the interval spans. |
| Name       |                     String                     | The name for this instance.                        |
| Symbol     |                     String                     | The symbol for this instance.                      |

## Methods
| Method                                                           | Return Type | Description                                                                                                                                                                   |
|------------------------------------------------------------------|:-----------:|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| EffectivelyEquals([Interval](./Bravura.Tonality.Interval.md))    |   Boolean   | Determines whether the specified interval has the same semitones as the current interval.                                                                                     |
| ToString()                                                       |   String    | Returns the string representation of the interval.                                                                                                                            |
| TryParse(String, out [Interval](./Bravura.Tonality.Interval.md)) |   Boolean   | Converts the string representation of an interval to an instance of an [Interval](./Bravura.Tonality.Interval.md). A return value indicates whether the conversion succeeded. |

\* See the static class [Intervals](./Bravura.Tonality.Intervals.md) for all instances.
