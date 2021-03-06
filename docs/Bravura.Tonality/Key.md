# Key Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents the combination of a pitch and a tonality.

```csharp
public class Key
```

Inheritance: Object -> Key

## Constructors
| Constructor | Description |
| --- | --- |
| Key([Pitch](./Pitch.md), [Tonality](./Tonality.md)) | Initializes a new instance of the [Key](./Key.md) class. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Pitch.md) | The tonal center of the key. |
| Tonality | [Tonality](./Tonality.md) | The tonality of the key. |
| Scale | [Scale](./Scale.md) | The scale that the key is built around. |
| KeySignature | List<[Pitch](./Pitch.md)> | The list of accidentals that are found in the key. |
| Relative | [Key](./Key.md) | The relative key of the opposite tonality. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| Equals([Key](./Key.md)) | Boolean | Determines whether the specified key is equal to the current key. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |

\* See the static class [Keys](./Keys.md) for all instances.
