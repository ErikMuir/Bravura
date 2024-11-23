using System.Linq;
using Bravura.Tonality;
using Bravura.Tonality.Analysis;
using Xunit;

namespace Bravura.Tests.Tonality.Analysis;

public class ChordProgressionTests
{
    private static readonly Chord _dMin = new(Pitches.DNatural, ChordQualities.Min);
    private static readonly Chord _bFlatMaj7 = new(Pitches.BFlat, ChordQualities.Maj7);
    private static readonly Chord _eMin7Flat5 = new(Pitches.ENatural, ChordQualities.Min7Flat5);
    private static readonly Chord _aDom7 = new(Pitches.ANatural, ChordQualities.Dom7);

    // [Fact]
    // public void Relationships_Test()
    // {
    //     var testObject = new ChordProgression([_dMin, _bFlatMaj7, _eMin7Flat5, _aDom7]);
    //     Assert.Equal(3, testObject.Analysis.Count);

    //     var analysis1 = testObject.Analysis[0];
    //     Assert.Equal(_dMin, analysis1.AnalyzedChords[0].Chord);
    //     Assert.Equal(_bFlatMaj7, analysis1.AnalyzedChords[1].Chord);

    //     var analysis2 = testObject.Analysis[1];
    //     Assert.Equal(_bFlatMaj7, analysis2.AnalyzedChords[0].Chord);
    //     Assert.Equal(_eMin7Flat5, analysis2.AnalyzedChords[1].Chord);

    //     var analysis3 = testObject.Analysis[2];
    //     Assert.Equal(_eMin7Flat5, analysis3.AnalyzedChords[0].Chord);
    //     Assert.Equal(_aDom7, analysis3.AnalyzedChords[1].Chord);
    // }

    // [Fact]
    // public void Analysis_Test()
    // {
    //     var testObject = new ChordProgression([_dMin, _bFlatMaj7, _eMin7Flat5, _aDom7]);
    //     Assert.Single(testObject.Analysis);

    //     var analysis = testObject.Analysis.Single();
    //     Assert.Equal(0, analysis.Weight);
    //     Assert.True(analysis.AnalyzedChords.All(analyzedChord => analyzedChord.Key == Keys.DMinor));
    //     Assert.Equal(Keys.DMinor, analysis.AnalyzedChords[0].Key);
    // }
}
