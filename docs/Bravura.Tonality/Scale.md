# Scale Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical scale and the root and mode that it consists of.

```csharp
public record Scale : IBaseTonality
```

Inheritance: Object -> Scale
Implements: [IBaseTonality](./IBaseTonality.md)

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
| DisplayValue(Boolean) | String | Returns the string representation of the scale, optionally limited to only ASCII characters. |
| DisplayValueWithPitches() | String | Returns the string representation of the scale including its pitches, optionally limited to only ASCII characters. |
