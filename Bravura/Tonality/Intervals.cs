using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality
{
    public static class Intervals
    {
        static Intervals()
        {
            PerfectUnison = new Interval(0, Accidentals.Natural, 1, IntervalNames.PerfectUnison, IntervalSymbols.PerfectUnison);
            AugmentedUnison = new Interval(1, Accidentals.Sharp, 1, IntervalNames.AugmentedUnison, IntervalSymbols.AugmentedUnison);
            DiminishedSecond = new Interval(0, Accidentals.DoubleFlat, 2, IntervalNames.DiminishedSecond, IntervalSymbols.DiminishedSecond);
            MinorSecond = new Interval(1, Accidentals.Flat, 2, IntervalNames.MinorSecond, IntervalSymbols.MinorSecond);
            MajorSecond = new Interval(2, Accidentals.Natural, 2, IntervalNames.MajorSecond, IntervalSymbols.MajorSecond);
            AugmentedSecond = new Interval(3, Accidentals.Sharp, 2, IntervalNames.AugmentedSecond, IntervalSymbols.AugmentedSecond);
            DiminishedThird = new Interval(2, Accidentals.DoubleFlat, 3, IntervalNames.DiminishedThird, IntervalSymbols.DiminishedThird);
            MinorThird = new Interval(3, Accidentals.Flat, 3, IntervalNames.MinorThird, IntervalSymbols.MinorThird);
            MajorThird = new Interval(4, Accidentals.Natural, 3, IntervalNames.MajorThird, IntervalSymbols.MajorThird);
            AugmentedThird = new Interval(5, Accidentals.Sharp, 3, IntervalNames.AugmentedThird, IntervalSymbols.AugmentedThird);
            DiminishedFourth = new Interval(4, Accidentals.Flat, 4, IntervalNames.DiminishedFourth, IntervalSymbols.DiminishedFourth);
            PerfectFourth = new Interval(5, Accidentals.Natural, 4, IntervalNames.PerfectFourth, IntervalSymbols.PerfectFourth);
            AugmentedFourth = new Interval(6, Accidentals.Sharp, 4, IntervalNames.AugmentedFourth, IntervalSymbols.AugmentedFourth);
            Tritone = new Interval(6, Accidentals.Sharp, 4, IntervalNames.Tritone, IntervalSymbols.Tritone);
            DiminishedFifth = new Interval(6, Accidentals.Flat, 5, IntervalNames.DiminishedFifth, IntervalSymbols.DiminishedFifth);
            PerfectFifth = new Interval(7, Accidentals.Natural, 5, IntervalNames.PerfectFifth, IntervalSymbols.PerfectFifth);
            AugmentedFifth = new Interval(8, Accidentals.Sharp, 5, IntervalNames.AugmentedFifth, IntervalSymbols.AugmentedFifth);
            DiminishedSixth = new Interval(7, Accidentals.DoubleFlat, 6, IntervalNames.DiminishedSixth, IntervalSymbols.DiminishedSixth);
            MinorSixth = new Interval(8, Accidentals.Flat, 6, IntervalNames.MinorSixth, IntervalSymbols.MinorSixth);
            MajorSixth = new Interval(9, Accidentals.Natural, 6, IntervalNames.MajorSixth, IntervalSymbols.MajorSixth);
            AugmentedSixth = new Interval(10, Accidentals.Sharp, 6, IntervalNames.AugmentedSixth, IntervalSymbols.AugmentedSixth);
            DiminishedSeventh = new Interval(9, Accidentals.DoubleFlat, 7, IntervalNames.DiminishedSeventh, IntervalSymbols.DiminishedSeventh);
            MinorSeventh = new Interval(10, Accidentals.Flat, 7, IntervalNames.MinorSeventh, IntervalSymbols.MinorSeventh);
            MajorSeventh = new Interval(11, Accidentals.Natural, 7, IntervalNames.MajorSeventh, IntervalSymbols.MajorSeventh);
            AugmentedSeventh = new Interval(12, Accidentals.Sharp, 7, IntervalNames.AugmentedSeventh, IntervalSymbols.AugmentedSeventh);
            DiminishedOctave = new Interval(11, Accidentals.Flat, 8, IntervalNames.DiminishedOctave, IntervalSymbols.DiminishedOctave);
            PerfectOctave = new Interval(12, Accidentals.Natural, 8, IntervalNames.PerfectOctave, IntervalSymbols.PerfectOctave);

            AllIntervals = new List<Interval>
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

        public static readonly Interval PerfectUnison;
        public static readonly Interval AugmentedUnison;
        public static readonly Interval DiminishedSecond;
        public static readonly Interval MinorSecond;
        public static readonly Interval MajorSecond;
        public static readonly Interval AugmentedSecond;
        public static readonly Interval DiminishedThird;
        public static readonly Interval MinorThird;
        public static readonly Interval MajorThird;
        public static readonly Interval AugmentedThird;
        public static readonly Interval DiminishedFourth;
        public static readonly Interval PerfectFourth;
        public static readonly Interval AugmentedFourth;
        public static readonly Interval Tritone;
        public static readonly Interval DiminishedFifth;
        public static readonly Interval PerfectFifth;
        public static readonly Interval AugmentedFifth;
        public static readonly Interval DiminishedSixth;
        public static readonly Interval MinorSixth;
        public static readonly Interval MajorSixth;
        public static readonly Interval AugmentedSixth;
        public static readonly Interval DiminishedSeventh;
        public static readonly Interval MinorSeventh;
        public static readonly Interval MajorSeventh;
        public static readonly Interval AugmentedSeventh;
        public static readonly Interval DiminishedOctave;
        public static readonly Interval PerfectOctave;
        public static readonly ReadOnlyCollection<Interval> AllIntervals;
    }

    public static class IntervalNames
    {
        public const string PerfectUnison = "Perfect Unison";
        public const string DiminishedSecond = "Diminished Second";
        public const string MinorSecond = "Minor Second";
        public const string AugmentedUnison = "Augmented Unison";
        public const string MajorSecond = "Major Second";
        public const string DiminishedThird = "Diminished Third";
        public const string MinorThird = "Minor Third";
        public const string AugmentedSecond = "Augmented Second";
        public const string MajorThird = "Major Third";
        public const string DiminishedFourth = "Diminished Fourth";
        public const string PerfectFourth = "Perfect Fourth";
        public const string AugmentedThird = "Augmented Third";
        public const string AugmentedFourth = "Augmented Fourth";
        public const string DiminishedFifth = "Diminished Fifth";
        public const string Tritone = "Tritone";
        public const string PerfectFifth = "Perfect Fifth";
        public const string DiminishedSixth = "Diminished Sixth";
        public const string MinorSixth = "Minor Sixth";
        public const string AugmentedFifth = "Augmented Fifth";
        public const string MajorSixth = "Major Sixth";
        public const string DiminishedSeventh = "Diminished Seventh";
        public const string MinorSeventh = "Minor Seventh";
        public const string AugmentedSixth = "Augmented Sixth";
        public const string MajorSeventh = "Major Seventh";
        public const string DiminishedOctave = "Diminished Octave";
        public const string PerfectOctave = "Perfect Octave";
        public const string AugmentedSeventh = "Augmented Seventh";
    }

    public static class IntervalSymbols
    {
        public const string PerfectUnison = "P1";
        public const string DiminishedSecond = "d2";
        public const string MinorSecond = "m2";
        public const string AugmentedUnison = "A1";
        public const string MajorSecond = "M2";
        public const string DiminishedThird = "d3";
        public const string MinorThird = "m3";
        public const string AugmentedSecond = "A2";
        public const string MajorThird = "M3";
        public const string DiminishedFourth = "d4";
        public const string PerfectFourth = "P4";
        public const string AugmentedThird = "A3";
        public const string AugmentedFourth = "A4";
        public const string DiminishedFifth = "d5";
        public const string Tritone = "TT";
        public const string PerfectFifth = "P5";
        public const string DiminishedSixth = "d6";
        public const string MinorSixth = "m6";
        public const string AugmentedFifth = "A5";
        public const string MajorSixth = "M6";
        public const string DiminishedSeventh = "d7";
        public const string MinorSeventh = "m7";
        public const string AugmentedSixth = "A6";
        public const string MajorSeventh = "M7";
        public const string DiminishedOctave = "d8";
        public const string PerfectOctave = "P8";
        public const string AugmentedSeventh = "A7";
    }
}