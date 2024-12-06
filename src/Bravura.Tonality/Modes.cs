using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public static class Modes
{
    static Modes()
    {
        Major = new Mode(ModeNames.Major,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            ]);

        NaturalMinor = new Mode(ModeNames.NaturalMinor,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MinorSeventh,
            ]);

        HarmonicMinor = new Mode(ModeNames.HarmonicMinor,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MajorSeventh,
            ]);

        MelodicMinor = new Mode(ModeNames.MelodicMinor,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            ]);

        MajorPentatonic = new Mode(ModeNames.MajorPentatonic,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
            ]);

        MinorPentatonic = new Mode(ModeNames.MinorPentatonic,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
            ]);

        Ionian = new Mode(ModeNames.Ionian,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            ]);

        Dorian = new Mode(ModeNames.Dorian,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MinorSeventh,
            ]);

        Phrygian = new Mode(ModeNames.Phrygian,
            [
                Intervals.PerfectUnison,
                Intervals.MinorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MinorSeventh,
            ]);

        Lydian = new Mode(ModeNames.Lydian,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.AugmentedFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MajorSeventh,
            ]);

        Mixolydian = new Mode(ModeNames.Mixolydian,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
                Intervals.MinorSeventh,
            ]);

        Aeolian = new Mode(ModeNames.Aeolian,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MinorSeventh,
            ]);

        Locrian = new Mode(ModeNames.Locrian,
            [
                Intervals.PerfectUnison,
                Intervals.MinorSecond,
                Intervals.MinorThird,
                Intervals.PerfectFourth,
                Intervals.DiminishedFifth,
                Intervals.MinorSixth,
                Intervals.MinorSeventh,
            ]);

        Chromatic = new Mode(ModeNames.Chromatic,
            [
                Intervals.PerfectUnison,
                Intervals.MinorSecond,
                Intervals.MajorSecond,
                Intervals.MinorThird,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
                Intervals.Tritone,
                Intervals.PerfectFifth,
                Intervals.MinorSixth,
                Intervals.MajorSixth,
                Intervals.MinorSeventh,
                Intervals.MajorSeventh,
            ]);

        AllModes =
            [
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
                Chromatic,
            ];

        ModesDict = AllModes
            .Select((mode) => new { key = mode.Name.ToLower(), value = mode })
            .ToDictionary(pair => pair.key, pair => pair.value);
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
    public static Mode Chromatic { get; }
    public static List<Mode> AllModes { get; }
    public static Dictionary<string, Mode> ModesDict { get; }
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
    public const string Chromatic = "Chromatic";
}
