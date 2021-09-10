# ChromaticScale Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a chromatic scale starting from a given root pitch.

```csharp
public class ChromaticScale
```

Inheritance: Object -> ChromaticScale

## Constructors
| Constructor | Description |
| --- | --- |
| ChromaticScale([Pitch](./Pitch.md)) | Initializes a new instance of the [ChromaticScale](./ChromaticScale.md) class. |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| Root | [Pitch](./Pitch.md) | The root for this instance. |
| Mode | [Mode](./Mode.md) | The mode for this instance. |
| Pref | [EnharmonicPreference](./EnharmonicPreference.md) | The enharmonic preference for this instance. |
| Pitches | List<[Pitch](./Pitch.md)> | The pitches that make up this scale. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| EnharmonicallyEquals([ChromaticScale](./ChromaticScale.md)) | Boolean | Determines whether the specified scale's root is enharmonically equal to the current scale, and the specified mode effectively equals the current scale. |
| Equals([ChromaticScale](./ChromaticScale.md)) | Boolean | Determines whether the specified scale is equal to the current scale. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |
