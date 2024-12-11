# ChromaticScale Record

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a chromatic scale starting from a given root pitch.

```csharp
public record ChromaticScale
```

Inheritance: Object -> ChromaticScale

## Constructors
| Constructor                                          | Description                                                                                      |
|------------------------------------------------------|--------------------------------------------------------------------------------------------------|
| ChromaticScale([Pitch](./Bravura.Tonality.Pitch.md)) | Initializes a new instance of the [ChromaticScale](./Bravura.Tonality.ChromaticScale.md) record. |

## Fields
| Field   |                    Type                    | Description                          |
|---------|:------------------------------------------:|--------------------------------------|
| Root    |    [Pitch](./Bravura.Tonality.Pitch.md)    | The root for this instance.          |
| Mode    |     [Mode](./Bravura.Tonality.Mode.md)     | The mode for this instance.          |
| Pitches | List<[Pitch](./Bravura.Tonality.Pitch.md)> | The pitches that make up this scale. |

## Methods
| Method                                                                       | Return Type | Description                                                                                                                                              |
|------------------------------------------------------------------------------|:-----------:|----------------------------------------------------------------------------------------------------------------------------------------------------------|
| EnharmonicallyEquals([ChromaticScale](./Bravura.Tonality.ChromaticScale.md)) |   Boolean   | Determines whether the specified scale's root is enharmonically equal to the current scale, and the specified mode effectively equals the current scale. |
