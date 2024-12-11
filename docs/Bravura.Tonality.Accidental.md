# Accidental Struct

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents an alteration to a note or scale tone by 0, 1, or 2 semitones in either direction.

```csharp
public struct Accidental : ITonality
```

Inheritance: Object -> ValueType -> Accidental
Implements: [ITonality](./Bravura.Tonality.ITonality.md)

## Constructors
| Constructor                       | Description                                                                                                                                                                     |
|-----------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Accidental(Int16, String, String) | Initializes a new instance of the [Accidental](./Bravura.Tonality.Accidental.md) struct. This constructor is `internal` so Bravura consumers cannot initialize new instances. * |

## Fields
| Field                    |  Type  | Description                                |
|--------------------------|:------:|--------------------------------------------|
| SemitonesAwayFromNatural | Int16  | The number of semitones away from Natural. |
| Name                     | String | The name for this instance.                |
| Symbol                   | String | The symbol for this instance.              |

## Methods
| Method     | Return Type | Description                                         |
|------------|:-----------:|-----------------------------------------------------|
| ToString() |   String    | Returns the Accidental's display value as a string. |

\* See the static class [Accidentals](./Bravura.Tonality.Accidentals.md) for all instances.
