using System.Collections.Generic;
using Bravura.Constants;

namespace Bravura
{
    public static partial class Theory
    {
        public static readonly Mode Major = new Mode(
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

        public static readonly Mode NaturalMinor = new Mode(
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

        public static readonly Mode HarmonicMinor = new Mode(
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

        public static readonly Mode MelodicMinor = new Mode(
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

        public static readonly Mode MajorPentatonic = new Mode(
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

        public static readonly Mode MinorPentatonic = new Mode(
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

        public static readonly Mode Ionian = new Mode(
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

        public static readonly Mode Dorian = new Mode(
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

        public static readonly Mode Phrygian = new Mode(
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

        public static readonly Mode Lydian = new Mode(
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

        public static readonly Mode Mixolydian = new Mode(
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

        public static readonly Mode Aeolian = new Mode(
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

        public static readonly Mode Locrian = new Mode(
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

        public static List<Mode> Modes = 
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