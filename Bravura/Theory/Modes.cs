using Bravura.Constants;
using System.Collections.Generic;

namespace Bravura
{
    public static partial class Theory
    {
        public static Mode Major { get; private set; }
        public static Mode NaturalMinor { get; private set; }
        public static Mode HarmonicMinor { get; private set; }
        public static Mode MelodicMinor { get; private set; }
        public static Mode MajorPentatonic { get; private set; }
        public static Mode MinorPentatonic { get; private set; }
        public static Mode Ionian { get; private set; }
        public static Mode Dorian { get; private set; }
        public static Mode Phrygian { get; private set; }
        public static Mode Lydian { get; private set; }
        public static Mode Mixolydian { get; private set; }
        public static Mode Aeolian { get; private set; }
        public static Mode Locrian { get; private set; }
        public static List<Mode> Modes { get; private set; }

        static partial void SetModes()
        {
            Major = new Mode(
                ModeNames.Major,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MajorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MajorSixth,
                    MajorSeventh,
                });

            NaturalMinor = new Mode(
                ModeNames.NaturalMinor,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MinorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MinorSixth,
                    MinorSeventh,
                });

            HarmonicMinor = new Mode(
                ModeNames.HarmonicMinor,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MinorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MinorSixth,
                    MajorSeventh,
                });

            MelodicMinor = new Mode(
                ModeNames.MelodicMinor,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MinorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MajorSixth,
                    MajorSeventh,
                });

            MajorPentatonic = new Mode(
                ModeNames.MajorPentatonic,
                new List<int> { 0, 1, 2, 4, 5 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MajorThird,
                    PerfectFifth,
                    MajorSixth,
                });

            MinorPentatonic = new Mode(
                ModeNames.MinorPentatonic,
                new List<int> { 0, 2, 3, 4, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MinorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MinorSeventh,
                });

            Ionian = new Mode(
                ModeNames.Ionian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MajorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MajorSixth,
                    MajorSeventh,
                });

            Dorian = new Mode(
                ModeNames.Dorian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MinorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MajorSixth,
                    MinorSeventh,
                });

            Phrygian = new Mode(
                ModeNames.Phrygian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MinorSecond,
                    MinorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MinorSixth,
                    MinorSeventh,
                });

            Lydian = new Mode(
                ModeNames.Lydian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MajorThird,
                    AugmentedFourth,
                    PerfectFifth,
                    MajorSixth,
                    MajorSeventh,
                });

            Mixolydian = new Mode(
                ModeNames.Mixolydian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MajorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MajorSixth,
                    MinorSeventh,
                });

            Aeolian = new Mode(
                ModeNames.Aeolian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MajorSecond,
                    MinorThird,
                    PerfectFourth,
                    PerfectFifth,
                    MinorSixth,
                    MinorSeventh,
                });

            Locrian = new Mode(
                ModeNames.Locrian,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    PerfectUnison,
                    MinorSecond,
                    MinorThird,
                    PerfectFourth,
                    DiminishedFifth,
                    MinorSixth,
                    MinorSeventh,
                });

            Modes = new List<Mode>
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
    }
}