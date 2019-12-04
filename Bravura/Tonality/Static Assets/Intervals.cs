using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bravura.Constants;

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
}