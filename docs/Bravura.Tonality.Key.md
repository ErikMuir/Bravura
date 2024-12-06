# Key Class

Namespace: [Bravura.modality](./Bravura.Tonality.md)

### Represents the combination of a pitch and a modality.

```csharp
public record Key
```

Inheritance: Object -> Key

## Constructors
| Constructor | Description |
| --- | --- |
| Key([Pitch](./Bravura.Tonality.Pitch.md), [Modality](./Bravura.Tonality.Modality.md)) | Initializes a new instance of the [Key](./Bravura.Tonality.Key.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Bravura.Tonality.Pitch.md) | The tonal center of the key. |
| Modality | [Modality](./Bravura.Tonality.Modality.md) | The modality of the key. |
| Scale | [Scale](./Bravura.Tonality.Scale.md) | The scale that the key is built around. |
| KeySignature | List<[Pitch](./Bravura.Tonality.Pitch.md)> | The list of accidentals that are found in the key. |
| Relative | [Key](./Bravura.Tonality.Key.md) | The relative key of the opposite modality. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| Transpose([Direction](./Bravura.Tonality.Direction.md), [Interval](./Bravura.Tonality.Interval.md)) | [Key](./Bravura.Tonality.Key.md) | Returns the key transposed by the provided interval in the provided direction. |

\* See the static class [Keys](./Bravura.Tonality.Keys.md) for all instances.
