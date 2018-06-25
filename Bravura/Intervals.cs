using System.Collections.Generic;

namespace Bravura
{
    public struct Intervals
    {
        public static readonly Interval PerfectUnison = new Interval(0, Accidentals.Natural, 1, "Perfect Unison", "P1");
        public static readonly Interval DiminishedSecond = new Interval(0, Accidentals.DoubleFlat, 2, "Diminished Second", "d2");
        public static readonly Interval MinorSecond = new Interval(1, Accidentals.Flat, 2, "Minor Second", "m2");
        public static readonly Interval AugmentedUnison = new Interval(1, Accidentals.Sharp, 1, "Augmented Unison", "A1");
        public static readonly Interval MajorSecond = new Interval(2, Accidentals.Natural, 2, "Major Second", "M2");
        public static readonly Interval DiminishedThird = new Interval(2, Accidentals.DoubleFlat, 3, "Diminished Third", "d3");
        public static readonly Interval MinorThird = new Interval(3, Accidentals.Flat, 3, "Minor Third", "m3");
        public static readonly Interval AugmentedSecond = new Interval(3, Accidentals.DoubleSharp, 2, "Augmented Second", "A2");
        public static readonly Interval MajorThird = new Interval(4, Accidentals.Natural, 3, "Major Third", "M3");
        public static readonly Interval DiminishedFourth = new Interval(4, Accidentals.Flat, 4, "Diminished Fourth", "d4");
        public static readonly Interval PerfectFourth = new Interval(5, Accidentals.Natural, 4, "Perfect Fourth", "P4");
        public static readonly Interval AugmentedThird = new Interval(5, Accidentals.DoubleSharp, 3, "Augmented Third", "A3");
        public static readonly Interval AugmentedFourth = new Interval(6, Accidentals.Sharp, 4, "Augmented Fourth", "A4");
        public static readonly Interval DiminishedFifth = new Interval(6, Accidentals.Flat, 5, "Diminished Fifth", "d5");
        public static readonly Interval Tritone = new Interval(6, Accidentals.Natural, 0, "Tritone", "TT");
        public static readonly Interval PerfectFifth = new Interval(7, Accidentals.Natural, 5, "Perfect Fifth", "P5");
        public static readonly Interval DiminishedSixth = new Interval(7, Accidentals.DoubleFlat, 6, "Diminished Sixth", "d6");
        public static readonly Interval MinorSixth = new Interval(8, Accidentals.Flat, 6, "Minor Sixth", "m6");
        public static readonly Interval AugmentedFifth = new Interval(8, Accidentals.DoubleSharp, 5, "Augmented Fifth", "A5");
        public static readonly Interval MajorSixth = new Interval(9, Accidentals.Natural, 6, "Major Sixth", "M6");
        public static readonly Interval DiminishedSeventh = new Interval(9, Accidentals.DoubleFlat, 7, "Diminished Seventh", "d7");
        public static readonly Interval MinorSeventh = new Interval(10, Accidentals.Flat, 7, "Minor Seventh", "m7");
        public static readonly Interval AugmentedSixth = new Interval(10, Accidentals.DoubleSharp, 6, "Augmented Sixth", "A6");
        public static readonly Interval MajorSeventh = new Interval(11, Accidentals.Natural, 7, "Major Seventh", "M7");
        public static readonly Interval DiminishedOctave = new Interval(11, Accidentals.DoubleFlat, 8, "Diminished Octave", "d8");
        public static readonly Interval PerfectOctave = new Interval(12, Accidentals.Natural, 8, "Perfect Octave", "P8");
        public static readonly Interval AugmentedSeventh = new Interval(12, Accidentals.DoubleSharp, 7, "Augmented Seventh", "A7");

        public static List<Interval> AllIntervals = new List<Interval>
        {
            PerfectUnison, DiminishedSecond, MinorSecond, AugmentedUnison, MajorSecond, DiminishedThird, MinorThird, AugmentedSecond,
            MajorThird, DiminishedFourth, PerfectFourth, AugmentedThird, AugmentedFourth, DiminishedFifth, Tritone, PerfectFifth,
            DiminishedSixth, MinorSixth, AugmentedFifth, MajorSixth, DiminishedSeventh, MinorSeventh, AugmentedSixth, MajorSeventh,
            DiminishedOctave, PerfectOctave, AugmentedSeventh,
        };
    }
}