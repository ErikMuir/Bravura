# Intervals Class

Namespace: [Bravura.Tonality](./Bravura.Tonality.md)

### Static class that exposes each interval, as well as a read-only list of all intervals.

```csharp
public static class Intervals
```

Inheritance: Object -> Intervals

## Properties
| Property | Type | Description |
| --- | --- | --- |
| PerfectUnison | [Interval](./Interval.md) | The interval made by two instances of the same pitch. (i.e. C and C) |
| AugmentedUnison | [Interval](./Interval.md) | The interval made by two pitches that share the same note letter and whose accidentals make them 1 semitone apart. (i.e. C and C#) |
| DiminishedSecond | [Interval](./Interval.md) | The interval made by two enharmonically equal pitches having neighboring note letters. (i.e. C and Dbb) |
| MinorSecond | [Interval](./Interval.md) | The interval made by two pitches with neighboring note letters and whose accidentals make them 1 semitone apart. (i.e. C and Db) |
| MajorSecond | [Interval](./Interval.md) | The interval made by two pitches with neighboring note letters and whose accidentals make them 2 semitones apart. (i.e. C and D) |
| AugmentedSecond | [Interval](./Interval.md) | The interval made by two pitches with neighboring note letters and whose accidentals make them 3 semitones apart. (i.e. C and D#) |
| DiminishedThird | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 3 indices and whose accidentals make them 2 semitones apart. (i.e. C and Ebb) |
| MinorThird | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 3 indices and whose accidentals make them 3 semitones apart. (i.e. C and Eb) |
| MajorThird | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 3 indices and whose accidentals make them 4 semitones apart. (i.e. C and E) |
| AugmentedThird | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 3 indices and whose accidentals make them 5 semitones apart. (i.e. C and E#) |
| DiminishedFourth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 4 indices and whose accidentals make them 4 semitones apart. (i.e. C and Fb) |
| PerfectFourth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 4 indices and whose accidentals make them 5 semitones apart. (i.e. C and F) |
| AugmentedFourth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 4 indices and whose accidentals make them 6 semitones apart. (i.e. C and F#) |
| Tritone | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 4 or 5 indices and whose accidentals make them 6 semitones apart. (i.e. C and F# or C and Gb) |
| DiminishedFifth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 5 indices and whose accidentals make them 6 semitones apart. (i.e. C and Gb) |
| PerfectFifth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 5 indices and whose accidentals make them 7 semitones apart. (i.e. C and G) |
| AugmentedFifth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 5 indices and whose accidentals make them 8 semitones apart. (i.e. C and G#) |
| DiminishedSixth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 6 indices and whose accidentals make them 7 semitones apart. (i.e. C and Abb) |
| MinorSixth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 6 indices and whose accidentals make them 8 semitones apart. (i.e. C and Ab) |
| MajorSixth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 6 indices and whose accidentals make them 9 semitones apart. (i.e. C and A) |
| AugmentedSixth | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 6 indices and whose accidentals make them 10 semitones apart. (i.e. C and A#) |
| DiminishedSeventh | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 7 indices and whose accidentals make them 9 semitones apart. (i.e. C and Bbb) |
| MinorSeventh | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 7 indices and whose accidentals make them 10 semitones apart. (i.e. C and Bb) |
| MajorSeventh | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 7 indices and whose accidentals make them 11 semitones apart. (i.e. C and B) |
| AugmentedSeventh | [Interval](./Interval.md) | The interval made by two pitches with note letters spanning 7 indices and whose accidentals make them 12 semitones apart. (i.e. C and B#) |
| DiminishedOctave | [Interval](./Interval.md) | The interval made by two pitches with the same note letter and whose accidentals make them 11 semitones apart. (i.e. C and Cb) |
| PerfectOctave | [Interval](./Interval.md) | The interval made by two pitches with the same note letter and accidental but separated by 12 semitones. (i.e. C and C) |
| AllIntervals | ReadOnlyCollection<[Interval](./Interval.md)> | A read-only collection that holds all 27 intervals. |
