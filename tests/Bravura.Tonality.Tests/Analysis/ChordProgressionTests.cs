// ReSharper disable InconsistentNaming
using System.Linq;
using Bravura.Tonality.Analysis;

namespace Bravura.Tonality.Tests.Analysis;

public class ChordProgressionTests
{
    [Fact]
    public void Relationships_Test()
    {
        var dMin7 = new Chord(Pitches.DNatural, ChordQualities.Min7);
        var bFlatMaj7 = new Chord(Pitches.BFlat, ChordQualities.Maj7);
        var eMin7Flat5 = new Chord(Pitches.ENatural, ChordQualities.Min7Flat5);
        var aDom7b9 = new Chord(Pitches.ANatural, ChordQualities.Dom7Flat9);

        var testObject = new ChordProgression([dMin7, bFlatMaj7, eMin7Flat5, aDom7b9]);

        Assert.Equal(6, testObject.Analysis.Count);
        var bestAnalysis = testObject.Analysis.MaxBy(analysis => analysis.Weight);
        Assert.Equal(Keys.DMinor, bestAnalysis.Key);
        Assert.Equal(24, bestAnalysis.Weight);
        Assert.Equal("i7", bestAnalysis.AnalyzedChords[0].RomanNumeralAnalysis);
        Assert.Equal("♭VIMaj7", bestAnalysis.AnalyzedChords[1].RomanNumeralAnalysis);
        Assert.Equal("ii7♭5", bestAnalysis.AnalyzedChords[2].RomanNumeralAnalysis);
        Assert.Equal("V7♭9", bestAnalysis.AnalyzedChords[3].RomanNumeralAnalysis);
    }
}
