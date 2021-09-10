# Scale Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical scale and the root and mode that it consists of.

```csharp
public class Scale
```

Inheritance: Object -> Scale

## Constructors
| Constructor | Description |
| --- | --- |
| Scale([Pitch](./Pitch.md), [Mode](./Mode.md)) | Initializes a new instance of the [Scale](./Scale.md) class. |

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
| Equals([Scale](./Scale.md)) | Boolean | Determines whether the specified scale is equal to the current scale. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |
