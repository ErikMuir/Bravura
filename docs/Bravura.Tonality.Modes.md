# Modes Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Static class that exposes each mode, as well as a read-only list of all modes.

```csharp
public static class Modes
```

Inheritance: Object -> Modes

## Properties
| Property        |                          Type                          | Description                                                        |
|-----------------|:------------------------------------------------------:|--------------------------------------------------------------------|
| Major           |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 3 4 5 6 7]                |
| NaturalMinor    |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 b3 4 5 b6 b7]             |
| HarmonicMinor   |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 b3 4 5 b6 7]              |
| MelodicMinor    |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 b3 4 5 6 7]               |
| MajorPentatonic |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 3 5 6]                    |
| MinorPentatonic |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 b3 4 5 b7]                  |
| Ionian          |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 3 4 5 6 7]                |
| Dorian          |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 b3 4 5 6 b7]              |
| Phrygian        |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 b2 b3 4 5 b6 b7]            |
| Lydian          |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 3 #4 5 6 7]               |
| Mixolydian      |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 3 4 5 6 b7]               |
| Aeolian         |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 2 b3 4 5 b6 b7]             |
| Locrian         |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 b2 b3 4 b5 b6 b7]           |
| Chromatic       |           [Mode](./Bravura.Tonality.Mode.md)           | The mode consisting of scale tones: [1 b2 2 b3 3 4 b5 5 b6 6 b7 7] |
| AllModes        | ReadOnlyCollection<[Mode](./Bravura.Tonality.Mode.md)> | A read-only collection that holds all defined modes.               |
| ModesDict       | Dictionary<string, [Mode](./Bravura.Tonality.Mode.md)> | A dictionary of all modes keyed by their names                     |
