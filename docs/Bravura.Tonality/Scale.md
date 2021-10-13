# Scale Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical scale and the root and mode that it consists of.

```csharp
public record Scale
```

Inheritance: Object -> Scale

## Constructors
| Constructor | Description |
| --- | --- |
| Scale([Pitch](./Pitch.md), [Mode](./Mode.md)) | Initializes a new instance of the [Scale](./Scale.md) record. |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Pitch.md) | The root for this instance. |
| Mode | [Mode](./Mode.md)> | The mode for this instance. |
| Pitches | List<[Pitch](./Pitch.md)> | The pitches that make up this scale. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EnharmonicallyEquals([Scale](./Scale.md)) | Boolean | Determines whether the specified scale's root is enharmonically equal to the current scale, and the specified mode effectively equals the current scale. |
| ToString() | String | Returns the string representation of the scale. |
| ToAsciiString() | String | Returns the ASCII string representation of the scale. |
| ToStringWithPitches() | String | Returns the string representation of the scale including its pitches. |
| ToAsciiStringWithPitches() | String | Returns the ASCII string representation of the scale including its pitches. |
