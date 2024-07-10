using System.Collections.Generic;
using Bravura.Tonality;
using Bravura.Tonality.Analysis;
using Xunit;

namespace Bravura.Tests.Tonality.Analysis;

public class AnalyzedChordTestData
{
    public Chord Chord { get; set; }
    public Key Key { get; set; }
    public Interval ExpectedInterval { get; set; }
    public string ExpectedRomanNumeralAnalysis { get; set; }
}

public class AnalyzedChordTests
{
    private static readonly List<AnalyzedChordTestData> TestData =
    [
        new()
        {
            Chord = new Chord(Pitches.GNatural, ChordQualities.Maj7),
            Key = Keys.DMajor,
            ExpectedInterval = Intervals.PerfectFourth,
            ExpectedRomanNumeralAnalysis = "IVMaj7",
        },
        new()
        {
            Chord = new Chord(Pitches.BFlat, ChordQualities.Min7),
            Key = Keys.AMajor,
            ExpectedInterval = Intervals.MinorSecond,
            ExpectedRomanNumeralAnalysis = "♭ii7",
        },
    ];

    [Fact]
    public void Interval_Tests()
    {
        TestData.ForEach(data =>
        {
            var actual = new AnalyzedChord(data.Chord, data.Key);
            Assert.Equal(data.ExpectedInterval, actual.Interval);
        });
    }

    [Fact]
    public void RomanNumeralAnalysis_Tests()
    {
        TestData.ForEach(data =>
        {
            var actual = new AnalyzedChord(data.Chord, data.Key);
            Assert.Equal(data.ExpectedRomanNumeralAnalysis, actual.RomanNumeralAnalysis());
        });
    }
}
