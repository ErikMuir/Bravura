# BravuraTonalityException Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### The base exception class for all Bravura.Tonality exceptions.

```csharp
public class BravuraTonalityException : Bravura.Common.BravuraException
```

Inheritance: Object -> Exception -> [BravuraException](../Bravura.Common/BravuraException.md) -> BravuraTonalityException

Derived
* [ChordException](./ChordException.md)
* [ChordQualityException](./ChordQualityException.md)
* [IntervalException](./IntervalException.md)
* [ModeException](./ModeException.md)
* [ScaleException](./ScaleException.md)

## Constructors
| Constructor | Description |
| --- | --- |
| BravuraTonalityException() | Initializes a new instance of the [BravurTonalityaException](./BravuraTonalityException.md) class. |
| BravuraTonalityException(String) | Initializes a new instance of the [BravuraTonalityException](./BravuraTonalityException.md) class with a specified error message. |
| BravuraTonalityException(List\<String>) | Initializes a new instance of the [BravuraTonalityException](./BravuraTonalityException.md) class with a message concatenated from a specified list of error messages. |
| BravuraTonalityException(String, Exception) | Initializes a new instance of the [BravuraTonalityException](./BravuraTonalityException.md) class with a specified error message and a reference to the inner exception that is the cause of this exception. |
