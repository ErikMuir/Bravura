using System.Collections.Generic;
using Bravura.Constants;

namespace Bravura.Tonality
{
    public static class Modes
    {
        static Modes()
        {
            Major = new Mode(
                ModeNames.Major,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                });

            NaturalMinor = new Mode(
                ModeNames.NaturalMinor,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MinorSixth,
                    Intervals.MinorSeventh,
                });

            HarmonicMinor = new Mode(
                ModeNames.HarmonicMinor,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MinorSixth,
                    Intervals.MajorSeventh,
                });

            MelodicMinor = new Mode(
                ModeNames.MelodicMinor,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                });

            MajorPentatonic = new Mode(
                ModeNames.MajorPentatonic,
                new List<int> { 0, 1, 2, 4, 5 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                });

            MinorPentatonic = new Mode(
                ModeNames.MinorPentatonic,
                new List<int> { 0, 2, 3, 4, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MinorSeventh,
                });

            Ionian = new Mode(
                ModeNames.Ionian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                });

            Dorian = new Mode(
                ModeNames.Dorian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MinorSeventh,
                });

            Phrygian = new Mode(
                ModeNames.Phrygian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MinorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MinorSixth,
                    Intervals.MinorSeventh,
                });

            Lydian = new Mode(
                ModeNames.Lydian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.AugmentedFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                });

            Mixolydian = new Mode(
                ModeNames.Mixolydian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MinorSeventh,
                });

            Aeolian = new Mode(
                ModeNames.Aeolian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MinorSixth,
                    Intervals.MinorSeventh,
                });

            Locrian = new Mode(
                ModeNames.Locrian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MinorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.DiminishedFifth,
                    Intervals.MinorSixth,
                    Intervals.MinorSeventh,
                });

            AllModes = new List<Mode>
            {
                Major,
                NaturalMinor,
                HarmonicMinor,
                MelodicMinor,
                MajorPentatonic,
                MinorPentatonic,
                Ionian,
                Dorian,
                Phrygian,
                Lydian,
                Mixolydian,
                Aeolian,
                Locrian,
            };
        }

        public static readonly Mode Major;
        public static readonly Mode NaturalMinor;
        public static readonly Mode HarmonicMinor;
        public static readonly Mode MelodicMinor;
        public static readonly Mode MajorPentatonic;
        public static readonly Mode MinorPentatonic;
        public static readonly Mode Ionian;
        public static readonly Mode Dorian;
        public static readonly Mode Phrygian;
        public static readonly Mode Lydian;
        public static readonly Mode Mixolydian;
        public static readonly Mode Aeolian;
        public static readonly Mode Locrian;
        public static readonly List<Mode> AllModes;
    }
}