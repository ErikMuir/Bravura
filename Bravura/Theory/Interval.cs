using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bravura.Constants;

namespace Bravura
{
    public static partial class Theory
    {
        public class Interval
        {
            #region -- Constructor --

            internal Interval(
                int semitones,
                Accidental accidental,
                int noteIndex,
                string name,
                string symbol)
            {
                Semitones = semitones;
                Accidental = accidental;
                NoteIndex = noteIndex;
                Name = name;
                Symbol = symbol;
            }

            #endregion

            #region -- Properties --

            public int Semitones { get; }
            public Accidental Accidental { get; }
            public int NoteIndex { get; }
            public string Name { get; }
            public string Symbol { get; }

            #endregion

            #region -- Methods --

            public override string ToString()
                => $"{Accidental.Symbol}{NoteIndex}";

            public string ToAsciiString()
                => $"{Accidental.AsciiSymbol}{NoteIndex}";

            #endregion
        }

        #region -- Intervals --

        public static Interval PerfectUnison { get; private set; }
        public static Interval AugmentedUnison { get; private set; }
        public static Interval DiminishedSecond { get; private set; }
        public static Interval MinorSecond { get; private set; }
        public static Interval MajorSecond { get; private set; }
        public static Interval AugmentedSecond { get; private set; }
        public static Interval DiminishedThird { get; private set; }
        public static Interval MinorThird { get; private set; }
        public static Interval MajorThird { get; private set; }
        public static Interval AugmentedThird { get; private set; }
        public static Interval DiminishedFourth { get; private set; }
        public static Interval PerfectFourth { get; private set; }
        public static Interval AugmentedFourth { get; private set; }
        public static Interval Tritone { get; private set; }
        public static Interval DiminishedFifth { get; private set; }
        public static Interval PerfectFifth { get; private set; }
        public static Interval AugmentedFifth { get; private set; }
        public static Interval DiminishedSixth { get; private set; }
        public static Interval MinorSixth { get; private set; }
        public static Interval MajorSixth { get; private set; }
        public static Interval AugmentedSixth { get; private set; }
        public static Interval DiminishedSeventh { get; private set; }
        public static Interval MinorSeventh { get; private set; }
        public static Interval MajorSeventh { get; private set; }
        public static Interval AugmentedSeventh { get; private set; }
        public static Interval DiminishedOctave { get; private set; }
        public static Interval PerfectOctave { get; private set; }
        public static ReadOnlyCollection<Interval> Intervals { get; private set; }

        #endregion 

        static partial void SetIntervals()
        {
            PerfectUnison = new Interval(0, Natural, 1, IntervalNames.PerfectUnison, IntervalSymbols.PerfectUnison);
            AugmentedUnison = new Interval(1, Sharp, 1, IntervalNames.AugmentedUnison, IntervalSymbols.AugmentedUnison);
            DiminishedSecond = new Interval(0, DoubleFlat, 2, IntervalNames.DiminishedSecond, IntervalSymbols.DiminishedSecond);
            MinorSecond = new Interval(1, Flat, 2, IntervalNames.MinorSecond, IntervalSymbols.MinorSecond);
            MajorSecond = new Interval(2, Natural, 2, IntervalNames.MajorSecond, IntervalSymbols.MajorSecond);
            AugmentedSecond = new Interval(3, Sharp, 2, IntervalNames.AugmentedSecond, IntervalSymbols.AugmentedSecond);
            DiminishedThird = new Interval(2, DoubleFlat, 3, IntervalNames.DiminishedThird, IntervalSymbols.DiminishedThird);
            MinorThird = new Interval(3, Flat, 3, IntervalNames.MinorThird, IntervalSymbols.MinorThird);
            MajorThird = new Interval(4, Natural, 3, IntervalNames.MajorThird, IntervalSymbols.MajorThird);
            AugmentedThird = new Interval(5, Sharp, 3, IntervalNames.AugmentedThird, IntervalSymbols.AugmentedThird);
            DiminishedFourth = new Interval(4, Flat, 4, IntervalNames.DiminishedFourth, IntervalSymbols.DiminishedFourth);
            PerfectFourth = new Interval(5, Natural, 4, IntervalNames.PerfectFourth, IntervalSymbols.PerfectFourth);
            AugmentedFourth = new Interval(6, Sharp, 4, IntervalNames.AugmentedFourth, IntervalSymbols.AugmentedFourth);
            Tritone = new Interval(6, Sharp, 4, IntervalNames.Tritone, IntervalSymbols.Tritone);
            DiminishedFifth = new Interval(6, Flat, 5, IntervalNames.DiminishedFifth, IntervalSymbols.DiminishedFifth);
            PerfectFifth = new Interval(7, Natural, 5, IntervalNames.PerfectFifth, IntervalSymbols.PerfectFifth);
            AugmentedFifth = new Interval(8, Sharp, 5, IntervalNames.AugmentedFifth, IntervalSymbols.AugmentedFifth);
            DiminishedSixth = new Interval(7, DoubleFlat, 6, IntervalNames.DiminishedSixth, IntervalSymbols.DiminishedSixth);
            MinorSixth = new Interval(8, Flat, 6, IntervalNames.MinorSixth, IntervalSymbols.MinorSixth);
            MajorSixth = new Interval(9, Natural, 6, IntervalNames.MajorSixth, IntervalSymbols.MajorSixth);
            AugmentedSixth = new Interval(10, Sharp, 6, IntervalNames.AugmentedSixth, IntervalSymbols.AugmentedSixth);
            DiminishedSeventh = new Interval(9, DoubleFlat, 7, IntervalNames.DiminishedSeventh, IntervalSymbols.DiminishedSeventh);
            MinorSeventh = new Interval(10, Flat, 7, IntervalNames.MinorSeventh, IntervalSymbols.MinorSeventh);
            MajorSeventh = new Interval(11, Natural, 7, IntervalNames.MajorSeventh, IntervalSymbols.MajorSeventh);
            AugmentedSeventh = new Interval(12, Sharp, 7, IntervalNames.AugmentedSeventh, IntervalSymbols.AugmentedSeventh);
            DiminishedOctave = new Interval(11, Flat, 8, IntervalNames.DiminishedOctave, IntervalSymbols.DiminishedOctave);
            PerfectOctave = new Interval(12, Natural, 8, IntervalNames.PerfectOctave, IntervalSymbols.PerfectOctave);

            Intervals = new List<Interval>
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
}