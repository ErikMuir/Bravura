# Scale Record

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical scale and the root and mode that it consists of.

```csharp
public record Scale : ITonality
```

Inheritance: Object -> Scale
Implements: [ITonality](./Bravura.Tonality.ITonality.md)

## Constructors
| Constructor                                                                     | Description                                                                    |
|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|
| Scale([Pitch](./Bravura.Tonality.Pitch.md), [Mode](./Bravura.Tonality.Mode.md)) | Initializes a new instance of the [Scale](./Bravura.Tonality.Scale.md) record. |

## Fields
| Field   |                    Type                    | Description                          |
|---------|:------------------------------------------:|--------------------------------------|
| Root    |    [Pitch](./Bravura.Tonality.Pitch.md)    | The root for this instance.          |
| Mode    |    [Mode](./Bravura.Tonality.Mode.md)>     | The mode for this instance.          |
| Pitches | List<[Pitch](./Bravura.Tonality.Pitch.md)> | The pitches that make up this scale. |

## Methods
| Method                                                     | Return Type | Description                                                                                                                                              |
|------------------------------------------------------------|:-----------:|----------------------------------------------------------------------------------------------------------------------------------------------------------|
| EnharmonicallyEquals([Scale](./Bravura.Tonality.Scale.md)) |   Boolean   | Determines whether the specified scale's root is enharmonically equal to the current scale, and the specified mode effectively equals the current scale. |
| ToString()                                                 |   String    | Returns the string representation of the scale.                                                                                                          |
