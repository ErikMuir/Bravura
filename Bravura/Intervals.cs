using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bravura.Constants;
using Bravura.Theory;

namespace Bravura
{
    public static class Intervals
    {
        public static readonly Interval PerfectUnison = new Interval(0, Accidentals.Natural, 1,
            IntervalNames.PerfectUnison, IntervalSymbols.PerfectUnison);

        public static readonly Interval AugmentedUnison = new Interval(1, Accidentals.Sharp, 1,
            IntervalNames.AugmentedUnison, IntervalSymbols.AugmentedUnison);

        public static readonly Interval DiminishedSecond = new Interval(0, Accidentals.DoubleFlat, 2,
            IntervalNames.DiminishedSecond, IntervalSymbols.DiminishedSecond);

        public static readonly Interval MinorSecond = new Interval(1, Accidentals.Flat, 2,
            IntervalNames.MinorSecond, IntervalSymbols.MinorSecond);

        public static readonly Interval MajorSecond = new Interval(2, Accidentals.Natural, 2,
            IntervalNames.MajorSecond, IntervalSymbols.MajorSecond);

        public static readonly Interval AugmentedSecond = new Interval(3, Accidentals.Sharp, 2,
            IntervalNames.AugmentedSecond, IntervalSymbols.AugmentedSecond);

        public static readonly Interval DiminishedThird = new Interval(2, Accidentals.DoubleFlat, 3,
            IntervalNames.DiminishedThird, IntervalSymbols.DiminishedThird);

        public static readonly Interval MinorThird = new Interval(3, Accidentals.Flat, 3,
            IntervalNames.MinorThird, IntervalSymbols.MinorThird);

        public static readonly Interval MajorThird = new Interval(4, Accidentals.Natural, 3,
            IntervalNames.MajorThird, IntervalSymbols.MajorThird);

        public static readonly Interval AugmentedThird = new Interval(5, Accidentals.Sharp, 3,
            IntervalNames.AugmentedThird, IntervalSymbols.AugmentedThird);

        public static readonly Interval DiminishedFourth = new Interval(4, Accidentals.Flat, 4,
            IntervalNames.DiminishedFourth, IntervalSymbols.DiminishedFourth);

        public static readonly Interval PerfectFourth = new Interval(5, Accidentals.Natural, 4,
            IntervalNames.PerfectFourth, IntervalSymbols.PerfectFourth);

        public static readonly Interval AugmentedFourth = new Interval(6, Accidentals.Sharp, 4,
            IntervalNames.AugmentedFourth, IntervalSymbols.AugmentedFourth);

        public static readonly Interval Tritone = new Interval(6, Accidentals.Sharp, 4,
            IntervalNames.Tritone, IntervalSymbols.Tritone);

        public static readonly Interval DiminishedFifth = new Interval(6, Accidentals.Flat, 5,
            IntervalNames.DiminishedFifth, IntervalSymbols.DiminishedFifth);

        public static readonly Interval PerfectFifth = new Interval(7, Accidentals.Natural, 5,
            IntervalNames.PerfectFifth, IntervalSymbols.PerfectFifth);

        public static readonly Interval AugmentedFifth = new Interval(8, Accidentals.Sharp, 5,
            IntervalNames.AugmentedFifth, IntervalSymbols.AugmentedFifth);

        public static readonly Interval DiminishedSixth = new Interval(7, Accidentals.DoubleFlat, 6,
            IntervalNames.DiminishedSixth, IntervalSymbols.DiminishedSixth);

        public static readonly Interval MinorSixth = new Interval(8, Accidentals.Flat, 6,
            IntervalNames.MinorSixth, IntervalSymbols.MinorSixth);

        public static readonly Interval MajorSixth = new Interval(9, Accidentals.Natural, 6,
            IntervalNames.MajorSixth, IntervalSymbols.MajorSixth);

        public static readonly Interval AugmentedSixth = new Interval(10, Accidentals.Sharp, 6,
            IntervalNames.AugmentedSixth, IntervalSymbols.AugmentedSixth);

        public static readonly Interval DiminishedSeventh = new Interval(9, Accidentals.DoubleFlat, 7,
            IntervalNames.DiminishedSeventh, IntervalSymbols.DiminishedSeventh);

        public static readonly Interval MinorSeventh = new Interval(10, Accidentals.Flat, 7,
            IntervalNames.MinorSeventh, IntervalSymbols.MinorSeventh);

        public static readonly Interval MajorSeventh = new Interval(11, Accidentals.Natural, 7,
            IntervalNames.MajorSeventh, IntervalSymbols.MajorSeventh);

        public static readonly Interval AugmentedSeventh = new Interval(12, Accidentals.Sharp, 7,
            IntervalNames.AugmentedSeventh, IntervalSymbols.AugmentedSeventh);

        public static readonly Interval DiminishedOctave = new Interval(11, Accidentals.Flat, 8,
            IntervalNames.DiminishedOctave, IntervalSymbols.DiminishedOctave);

        public static readonly Interval PerfectOctave = new Interval(12, Accidentals.Natural, 8,
            IntervalNames.PerfectOctave, IntervalSymbols.PerfectOctave);

        public static ReadOnlyCollection<Interval> AllIntervals =
            new List<Interval>
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
}