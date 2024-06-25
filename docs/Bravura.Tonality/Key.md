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
| Key([Pitch](./Pitch.md), [Modality](./Modality.md)) | Initializes a new instance of the [Key](./Key.md) record. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Pitch.md) | The tonal center of the key. |
| Modality | [Modality](./Modality.md) | The modality of the key. |
| Scale | [Scale](./Scale.md) | The scale that the key is built around. |
| KeySignature | List<[Pitch](./Pitch.md)> | The list of accidentals that are found in the key. |
| Relative | [Key](./Key.md) | The relative key of the opposite modality. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| Transpose([Direction](./Direction.md), [Interval](./Interval.md)) | [Key](./Key.md) | Returns the key transposed by the provided interval in the provided direction. |

\* See the static class [Keys](./Keys.md) for all instances.
