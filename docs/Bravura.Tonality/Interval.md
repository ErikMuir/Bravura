# Interval Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the distance between two pitches.

```csharp
public class Interval
```

Inheritance: Object -> Interval

## Constructors
| Constructor | Description |
| --- | --- |
| Interval(Int32, [Accidental](./Accidental.md), Int32, String, String) | Initializes a new instance of the [Interval](./Interval.md) class. * |

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
| ToString() | String | Returns the string representation of the interval. |
| ToAsciiString() | String | Returns the ASCII string representation of the interval. |
| EffectivelyEquals([Interval](./Interval.md)) | Boolean | Determines whether the specified interval has the same semitones as the current interval. |
| Equals([Interval](./Interval.md)) | Boolean | Determines whether the specified interval is equal to the current interval. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |

\* See the static class [Intervals](./Intervals.md) for all instances.
