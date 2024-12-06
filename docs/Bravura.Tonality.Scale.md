# Scale Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical scale and the root and mode that it consists of.

```csharp
public record Scale : IBaseTonality
```

Inheritance: Object -> Scale
Implements: [IBaseTonality](./Bravura.Tonality.IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Scale([Pitch](./Bravura.Tonality.Pitch.md), [Mode](./Bravura.Tonality.Mode.md)) | Initializes a new instance of the [Scale](./Bravura.Tonality.Scale.md) record. |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Bravura.Tonality.Pitch.md) | The root for this instance. |
| Mode | [Mode](./Bravura.Tonality.Mode.md)> | The mode for this instance. |
| Pitches | List<[Pitch](./Bravura.Tonality.Pitch.md)> | The pitches that make up this scale. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EnharmonicallyEquals([Scale](./Bravura.Tonality.Scale.md)) | Boolean | Determines whether the specified scale's root is enharmonically equal to the current scale, and the specified mode effectively equals the current scale. |
| DisplayValue(Boolean) | String | Returns the string representation of the scale, optionally limited to only ASCII characters. |
| DisplayValueWithPitches() | String | Returns the string representation of the scale including its pitches, optionally limited to only ASCII characters. |
