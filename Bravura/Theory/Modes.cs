using System.Collections.Generic;
using Bravura.Constants;

namespace Bravura
{
    public static class Modes
    {
        public static readonly Mode Major = new Mode(
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

        public static readonly Mode NaturalMinor = new Mode(
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

        public static readonly Mode HarmonicMinor = new Mode(
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

        public static readonly Mode MelodicMinor = new Mode(
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

        public static readonly Mode MajorPentatonic = new Mode(
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

        public static readonly Mode MinorPentatonic = new Mode(
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

        public static readonly Mode Ionian = new Mode(
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

        public static readonly Mode Dorian = new Mode(
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

        public static readonly Mode Phrygian = new Mode(
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

        public static readonly Mode Lydian = new Mode(
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

        public static readonly Mode Mixolydian = new Mode(
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

        public static readonly Mode Aeolian = new Mode(
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

        public static readonly Mode Locrian = new Mode(
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

        public static List<Mode> AllModes = 
            new List<Mode>
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