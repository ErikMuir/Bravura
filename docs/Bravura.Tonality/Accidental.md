# Accidental Struct

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Represents an alteration to a note or scale tone by 0, 1, or 2 semitones in either direction.

```csharp
public struct Accidental
```

Inheritance: Object -> ValueType -> Accidental

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
| Equals([Accidental](./Accidental.md)) | Boolean | Determines whether the specified accidental is equal to the current accidental. |
| Equals(Object) | Boolean | Determines whether the specified object is equal to the current object. (Inherited from Object) |
| GetHashCode() | Int32 | Serves as the default hash function. (Inherited from Object) |

\* See the static class [Accidentals](./Accidentals.md) for all instances.

