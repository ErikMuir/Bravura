using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality;

public static class Intervals
{
    public static readonly Interval PerfectUnison = new(0, Accidentals.Natural, 1, "Perfect Unison", "P1");
    public static readonly Interval AugmentedUnison = new(1, Accidentals.Sharp, 1, "Augmented Unison", "A1");
    public static readonly Interval DiminishedSecond = new(0, Accidentals.DoubleFlat, 2, "Diminished Second", "d2");
    public static readonly Interval MinorSecond = new(1, Accidentals.Flat, 2, "Minor Second", "m2");
    public static readonly Interval MajorSecond = new(2, Accidentals.Natural, 2, "Major Second", "M2");
    public static readonly Interval AugmentedSecond = new(3, Accidentals.Sharp, 2, "Augmented Second", "A2");
    public static readonly Interval DiminishedThird = new(2, Accidentals.DoubleFlat, 3, "Diminished Third", "d3");
    public static readonly Interval MinorThird = new(3, Accidentals.Flat, 3, "Minor Third", "m3");
    public static readonly Interval MajorThird = new(4, Accidentals.Natural, 3, "Major Third", "M3");
    public static readonly Interval AugmentedThird = new(5, Accidentals.Sharp, 3, "Augmented Third", "A3");
    public static readonly Interval DiminishedFourth = new(4, Accidentals.Flat, 4, "Diminished Fourth", "d4");
    public static readonly Interval PerfectFourth = new(5, Accidentals.Natural, 4, "Perfect Fourth", "P4");
    public static readonly Interval AugmentedFourth = new(6, Accidentals.Sharp, 4, "Augmented Fourth", "A4");
    public static readonly Interval Tritone = new(6, Accidentals.Sharp, 4, "Tritone", "TT");
    public static readonly Interval DiminishedFifth = new(6, Accidentals.Flat, 5, "Diminished Fifth", "d3");
    public static readonly Interval PerfectFifth = new(7, Accidentals.Natural, 5, "Perfect Fifth", "P5");
    public static readonly Interval AugmentedFifth = new(8, Accidentals.Sharp, 5, "Augmented Fifth", "A5");
    public static readonly Interval DiminishedSixth = new(7, Accidentals.DoubleFlat, 6, "Diminished Sixth", "d6");
    public static readonly Interval MinorSixth = new(8, Accidentals.Flat, 6, "Minor Sixth", "m6");
    public static readonly Interval MajorSixth = new(9, Accidentals.Natural, 6, "Major Sixth", "M6");
    public static readonly Interval AugmentedSixth = new(10, Accidentals.Sharp, 6, "Augmented Sixth", "A6");
    public static readonly Interval DiminishedSeventh = new(9, Accidentals.DoubleFlat, 7, "Diminished Seventh", "d7");
    public static readonly Interval MinorSeventh = new(10, Accidentals.Flat, 7, "Minor Seventh", "m7");
    public static readonly Interval MajorSeventh = new(11, Accidentals.Natural, 7, "Major Seventh", "M7");
    public static readonly Interval AugmentedSeventh = new(12, Accidentals.Sharp, 7, "Augmented Seventh", "A7");
    public static readonly Interval DiminishedOctave = new(11, Accidentals.Flat, 8, "Diminished Octave", "d8");
    public static readonly Interval PerfectOctave = new(12, Accidentals.Natural, 8, "Perfect Octave", "P8");
    public static readonly ReadOnlyCollection<Interval> Diatonic = new List<Interval>
    {
        PerfectUnison,
        MinorSecond,
        MajorSecond,
        MinorThird,
        MajorThird,
        PerfectFourth,
        AugmentedFourth,
        DiminishedFifth,
        PerfectFifth,
        MinorSixth,
        MajorSixth,
        DiminishedSeventh,
        MinorSeventh,
        MajorSeventh,
    }.AsReadOnly();
    public static readonly ReadOnlyCollection<Interval> AllIntervals = new List<Interval>
    {
        PerfectUnison,
        AugmentedUnison,
        DiminishedSecond,
        MinorSecond,
        MajorSecond,
        AugmentedSecond,
        DiminishedThird,
        MinorThird,
        MajorThird,
        AugmentedThird,
        DiminishedFourth,
        PerfectFourth,
        AugmentedFourth,
        Tritone,
        DiminishedFifth,
        PerfectFifth,
        AugmentedFifth,
        DiminishedSixth,
        MinorSixth,
        MajorSixth,
        AugmentedSixth,
        DiminishedSeventh,
        MinorSeventh,
        MajorSeventh,
        AugmentedSeventh,
        DiminishedOctave,
        PerfectOctave,
    }.AsReadOnly();
}
