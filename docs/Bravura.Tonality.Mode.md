# Mode Record

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents a musical mode and the intervals that it consists of.

```csharp
public record Mode : ITonality
```

Inheritance: Object -> Mode
Implements: [ITonality](./Bravura.Tonality.ITonality.md)

## Constructors
| Constructor                                                    | Description                                                                    |
|----------------------------------------------------------------|--------------------------------------------------------------------------------|
| Mode(String, List<[Interval](./Bravura.Tonality.Interval.md)>) | Initializes a new instance of the [Mode](./Bravura.Tonality.Mode.md) record. * |

## Fields
| Field     |                       Type                       | Description                               |
|-----------|:------------------------------------------------:|-------------------------------------------|
| Name      |                      String                      | The name for this instance.               |
| Intervals | List<[Interval](./Bravura.Tonality.Interval.md)> | The intervals that make up this instance. |

## Methods
| Method                                                | Return Type | Description                                                                       |
|-------------------------------------------------------|:-----------:|-----------------------------------------------------------------------------------|
| EffectivelyEquals([Mode](./Bravura.Tonality.Mode.md)) |   Boolean   | Determines whether the specified mode has the same intervals as the current mode. |
| ToString()                                            |   String    | Returns the name of the mode.                                                     |

\* See the static class [Modes](./Bravura.Tonality.Modes.md) for all instances.
