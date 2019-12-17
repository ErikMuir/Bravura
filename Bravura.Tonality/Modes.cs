using System.Collections.Generic;

namespace Bravura.Tonality
{
    public static class Modes
    {
        static Modes()
        {
            Major = new Mode(ModeNames.Major, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            });

            NaturalMinor = new Mode(ModeNames.NaturalMinor, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MinorSeventh,
            });

            HarmonicMinor = new Mode(ModeNames.HarmonicMinor, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MajorSeventh,
            });

            MelodicMinor = new Mode(ModeNames.MelodicMinor, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            });

            MajorPentatonic = new Mode(ModeNames.MajorPentatonic, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
            });

            MinorPentatonic = new Mode(ModeNames.MinorPentatonic, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
            });

            Ionian = new Mode(ModeNames.Ionian, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            });

            Dorian = new Mode(ModeNames.Dorian, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MinorSeventh,
            });

            Phrygian = new Mode(ModeNames.Phrygian, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MinorSeventh,
            });

            Lydian = new Mode(ModeNames.Lydian, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.AugmentedFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            });

            Mixolydian = new Mode(ModeNames.Mixolydian, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MinorSeventh,
            });

            Aeolian = new Mode(ModeNames.Aeolian, new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MinorSeventh,
            });

            Locrian = new Mode(ModeNames.Locrian, new List<Interval>
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

        public static Mode Major { get; }
        public static Mode NaturalMinor { get; }
        public static Mode HarmonicMinor { get; }
        public static Mode MelodicMinor { get; }
        public static Mode MajorPentatonic { get; }
        public static Mode MinorPentatonic { get; }
        public static Mode Ionian { get; }
        public static Mode Dorian { get; }
        public static Mode Phrygian { get; }
        public static Mode Lydian { get; }
        public static Mode Mixolydian { get; }
        public static Mode Aeolian { get; }
        public static Mode Locrian { get; }
        public static List<Mode> AllModes { get; }
    }

    public static class ModeNames
    {
        public const string Major = "Major";
        public const string NaturalMinor = "Natural Minor";
        public const string HarmonicMinor = "Harmonic Minor";
        public const string MelodicMinor = "Melodic Minor";
        public const string MajorPentatonic = "Major Pentatonic";
        public const string MinorPentatonic = "Minor Pentatonic";
        public const string Ionian = "Ionian";
        public const string Dorian = "Dorian";
        public const string Phrygian = "Phrygian";
        public const string Lydian = "Lydian";
        public const string Mixolydian = "Mixolydian";
        public const string Aeolian = "Aeolian";
        public const string Locrian = "Locrian";
    }
}