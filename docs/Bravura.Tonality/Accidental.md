# Accidental Struct

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents an alteration to a note or scale tone by 0, 1, or 2 semitones in either direction.

```csharp
public struct Accidental : IBaseTonality
```

Inheritance: Object -> ValueType -> Accidental
Implements: [IBaseTonality](./IBaseTonality.md)

## Constructors
| Constructor | Description |
| --- | --- |
| Accidental(Int16, String, String, String) | Initializes a new instance of the [Accidental](./Accidental.md) struct. This constructor is `internal` so Bravura consumers cannot initialize new instances. * |

## Fields
| Field | Type | Description |
| --- | --- | --- |
| SemitonesAwayFromNatural | Int16 | The number of semitones away from Natural. |
| Name | String | The name for this instance. |
| Symbol | String | The symbol for this instance. |
| AsciiSymbol | String | The ASCII symbol for this instance. |

## Methods
| Method | Return Type | Description |
| --- | --- | --- |
| DisplayValue(Boolean) | String | Returns the Accidental's display value as a string. Optionally limited to only ASCII characters. |

\* See the static class [Accidentals](./Accidentals.md) for all instances.
