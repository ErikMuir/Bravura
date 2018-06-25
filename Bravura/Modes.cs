using System.Collections.Generic;

namespace Bravura
{
    public struct Modes
    {
        public static readonly Mode Major = new Mode(
            "Major",
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

        public static readonly Mode NaturalMinor = new Mode(
            "Natural Minor",
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

        public static readonly Mode HarmonicMinor = new Mode(
            "Harmonic Minor",
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

        public static readonly Mode MelodicMinor = new Mode(
            "Melodic Minor",
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

        public static readonly Mode MajorPentatonic = new Mode(
            "Major Pentatonic",
            new List<int> { 0, 1, 2, 4, 5 },
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
            });

        public static readonly Mode MinorPentatonic = new Mode(
            "Minor Pentatonic",
            new List<int> { 0, 2, 3, 4, 6 },
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
            });

        public static readonly Mode Ionian = new Mode(
            "Ionian",
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

        public static readonly Mode Dorian = new Mode(
            "Dorian",
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

        public static readonly Mode Phrygian = new Mode(
            "Phrygian",
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

        public static readonly Mode Lydian = new Mode(
            "Lydian",
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

        public static readonly Mode Mixolydian = new Mode(
            "Mixolydian",
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

        public static readonly Mode Aeolian = new Mode(
            "Aeolian",
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

        public static readonly Mode Locrian = new Mode(
            "Locrian",
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

        public static List<Mode> AllModes = new List<Mode>
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