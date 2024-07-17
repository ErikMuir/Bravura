using Bravura.Tonality;
using Bravura.Tonality.Analysis;
using Xunit;

namespace Bravura.Tests.Tonality.Analysis;

public class AnalyzedChordProgressionTests
{
    private static readonly Chord _dMin = new(Pitches.DNatural, ChordQualities.Min);
    private static readonly Chord _bFlatMaj7 = new(Pitches.BFlat, ChordQualities.Maj7);
    private static readonly Chord _eMin7Flat5 = new(Pitches.ENatural, ChordQualities.Min7Flat5);
    private static readonly Chord _aDom7 = new(Pitches.ANatural, ChordQualities.Dom7);

    [Fact]
    public void Relationships_Test()
    {
        var testObject = new AnalyzedChordProgression([_dMin, _bFlatMaj7, _eMin7Flat5, _aDom7]);
        Assert.Equal(3, testObject.Relationships.Count);
        Assert.Equal(_dMin, testObject.Relationships[0].Chord1);
        Assert.Equal(_bFlatMaj7, testObject.Relationships[0].Chord2);
        Assert.Equal(_bFlatMaj7, testObject.Relationships[1].Chord1);
        Assert.Equal(_eMin7Flat5, testObject.Relationships[1].Chord2);
        Assert.Equal(_eMin7Flat5, testObject.Relationships[2].Chord1);
        Assert.Equal(_aDom7, testObject.Relationships[2].Chord2);
    }

    [Fact]
    public void KeyCounts_Test()
    {
        var testObject = new AnalyzedChordProgression([_dMin, _bFlatMaj7, _eMin7Flat5, _aDom7]);
        Assert.Equal(8, testObject.KeyCounts.Keys.Count);
        Assert.Equal(1, testObject.KeyCounts[Keys.CMajor]);
        Assert.Equal(3, testObject.KeyCounts[Keys.FMajor]);
        Assert.Equal(2, testObject.KeyCounts[Keys.BFlatMajor]);
        Assert.Equal(3, testObject.KeyCounts[Keys.DMinor]);
        Assert.Equal(2, testObject.KeyCounts[Keys.GMinor]);
        Assert.Equal(1, testObject.KeyCounts[Keys.AMinor]);
        Assert.Equal(1, testObject.KeyCounts[Keys.DMajor]);
        Assert.Equal(1, testObject.KeyCounts[Keys.BMinor]);
    }

    [Fact]
    public void BestKeys_Test()
    {
        var testObject = new AnalyzedChordProgression([_dMin, _bFlatMaj7, _eMin7Flat5, _aDom7]);
        Assert.Equal(2, testObject.BestKeys.Count);
        Assert.Contains(Keys.FMajor, testObject.BestKeys);
        Assert.Contains(Keys.DMinor, testObject.BestKeys);
    }
}
