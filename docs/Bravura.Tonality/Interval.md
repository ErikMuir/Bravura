# Interval Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the distance between two pitches.

```csharp
public record Interval
```

Inheritance: Object -> Interval

## Constructors
| Constructor | Description |
| --- | --- |
| Interval(Int32, [Accidental](./Accidental.md), Int32, String, String) | Initializes a new instance of the [Interval](./Interval.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Semitones | Int32 | The size of the interval in semitones. |
| Accidental | [Accidental](./Accidental.md) | |
| Degree | Int32 | The count of note indices that the interval spans. |
| Name | String | The name for this instance. |
| Symbol | String | The symbol for this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([Interval](./Interval.md)) | Boolean | Determines whether the specified interval has the same semitones as the current interval. |
| ToString() | String | Returns the string representation of the interval. |
| ToAsciiString() | String | Returns the ASCII string representation of the interval. |

\* See the static class [Intervals](./Intervals.md) for all instances.
