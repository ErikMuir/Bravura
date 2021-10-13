# Mode Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical mode and the intervals that it consists of.

```csharp
public record Mode
```

Inheritance: Object -> Mode

## Constructors
| Constructor | Description |
| --- | --- |
| Mode(String, List<[Interval](./Interval.md)>) | Initializes a new instance of the [Mode](./Mode.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Name | String | The name for this instance. |
| Intervals | List<[Interval](./Interval.md)> | The intervals that make up this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EffectivelyEquals([Mode](./Mode.md)) | Boolean | Determines whether the specified mode has the same intervals as the current mode. |
| ToString() | String | Returns the name of the mode. |
| ToStringWithIntervals() | String | Returns the string representation of the mode, including its intervals. |
| ToAsciiStringWithIntervals() | String | Returns the ASCII string representation of the mode, including its intervals. |

\* See the static class [Modes](./Modes.md) for all instances.
