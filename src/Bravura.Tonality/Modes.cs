using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public static class Modes
{
    public static readonly Mode Major = new(
        "Major",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MajorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
            Intervals.MajorSeventh,
        ]);
    public static readonly Mode NaturalMinor = new(
        "Natural Minor",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MinorSixth,
            Intervals.MinorSeventh,
        ]);
    public static readonly Mode HarmonicMinor = new(
        "Harmonic Minor",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MinorSixth,
            Intervals.MajorSeventh,
        ]);
    public static readonly Mode MelodicMinor = new(
        "Melodic Minor",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
            Intervals.MajorSeventh,
        ]);
    public static readonly Mode MajorPentatonic = new(
        "Major Pentatonic",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
        ]);
    public static readonly Mode MinorPentatonic = new(
        "Minor Pentatonic",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
        ]);
    public static readonly Mode Ionian = new(
        "Ionian",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MajorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
            Intervals.MajorSeventh,
        ]);
    public static readonly Mode Dorian = new(
        "Dorian",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
            Intervals.MinorSeventh,
        ]);
    public static readonly Mode Phrygian = new(
        "Phrygian",
        [
            Intervals.PerfectUnison,
            Intervals.MinorSecond,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MinorSixth,
            Intervals.MinorSeventh,
        ]);
    public static readonly Mode Lydian = new(
        "Lydian",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MajorThird,
            Intervals.AugmentedFourth,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
            Intervals.MajorSeventh,
        ]);
    public static readonly Mode Mixolydian = new(
        "Mixolydian",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MajorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
            Intervals.MinorSeventh,
        ]);
    public static readonly Mode Aeolian = new(
        "Aeolian",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MinorSixth,
            Intervals.MinorSeventh,
        ]);
    public static readonly Mode Locrian = new(
        "Locrian",
        [
            Intervals.PerfectUnison,
            Intervals.MinorSecond,
            Intervals.MinorThird,
            Intervals.PerfectFourth,
            Intervals.DiminishedFifth,
            Intervals.MinorSixth,
            Intervals.MinorSeventh,
        ]);
    public static readonly Mode Chromatic = new(
        "Chromatic",
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
    public static readonly List<Mode> AllModes = [
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
    public static readonly Dictionary<string, Mode> ModesDict = AllModes
        .Select((mode) => new { key = mode.Name.ToLower(), value = mode })
        .ToDictionary(pair => pair.key, pair => pair.value);
}
