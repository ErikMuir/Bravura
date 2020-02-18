# ChordQuality Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the quality of a chord and the intervals that it consists of.

```csharp
public class ChordQuality
```

Inheritance: Object -> ChordQuality

## Constructors
| Constructor | Description |
| --- | --- |
| ChordQuality(String, String, List<[Interval](./Interval.md)>) | Initializes a new instance of the [ChordQuality](./ChordQuality.md) class. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Symbol | String | The symbol for this instance. |
| AsciiSymbol | String | The ASCII symbol for this instance. |
| Intervals | List<[Interval](./Interval.md)> | The intervals that make up this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([ChordQuality](./ChordQuality.md)) | Boolean | Determines whether the specified chord quality has the same semitones as the current chord quality. |
| Equals([ChordQuality](./ChordQuality.md)) | Boolean | Determines whether the specified chord quality is equal to the current chord quality. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |

\* See the static class [ChordQualities](./ChordQualities.md) for all instances.
