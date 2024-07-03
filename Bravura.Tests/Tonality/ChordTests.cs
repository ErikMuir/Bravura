using Xunit;

namespace Bravura.Tonality.Tests;

public class ChordTests
{
    private readonly Chord _cMajor = new(Pitches.CNatural, ChordQualities.Maj);
    private readonly Chord _aMinor = new(Pitches.ANatural, ChordQualities.Min);
    private readonly Chord _cSharpMin7 = new(Pitches.CSharp, ChordQualities.Min7);
    private readonly Chord _cMaj9 = new(Pitches.CNatural, ChordQualities.Maj9);
    private readonly Chord _cDim7 = new(Pitches.CNatural, ChordQualities.Dim7);
    private readonly Chord _cAug = new(Pitches.CNatural, ChordQualities.Aug);
    private readonly Chord _cDom13 = new(Pitches.CNatural, ChordQualities.Dom13);
    private readonly Chord _cDom7Sharp9 = new(Pitches.CNatural, ChordQualities.Dom7Sharp9);
    private readonly Chord _cSus4 = new(Pitches.CNatural, ChordQualities.Sus4);

    [Fact]
    public void CommonTones_Test()
    {
        var commonTones = _cMajor.CommonTones(_aMinor);
        Assert.Equal(2, commonTones.Count);
        Assert.Contains(Pitches.CNatural, commonTones);
        Assert.Contains(Pitches.ENatural, commonTones);
        Assert.DoesNotContain(Pitches.ANatural, commonTones);
        Assert.DoesNotContain(Pitches.GNatural, commonTones);
    }

    [Fact]
    public void HasSamePitches_Test()
    {
        var eSus4 = new Chord(Pitches.ENatural, ChordQualities.Sus4);
        var aSus2 = new Chord(Pitches.ANatural, ChordQualities.Sus2);
        Assert.True(eSus4.HasSamePitches(aSus2));
        Assert.False(_cMajor.HasSamePitches(_aMinor));
    }

    [Fact]
    public void EnharmonicallyEquals_Test()
    {
        var bSharpMajor = new Chord(Pitches.BSharp, ChordQualities.Maj);

        Assert.True(bSharpMajor.EnharmonicallyEquals(_cMajor));
        Assert.False(_aMinor.EnharmonicallyEquals(_cMajor));
    }

    [Fact]
    public void DisplayValue_Test()
    {
        Assert.Equal("C♯m7", _cSharpMin7.DisplayValue());
        Assert.Equal("C♯m7", _cSharpMin7.DisplayValue(false));
        Assert.Equal("C#m7", _cSharpMin7.DisplayValue(true));
    }

    [Fact]
    public void DisplayValueWithPitches_Test()
    {
        Assert.Equal("C♯m7 { C♯ E G♯ B }", _cSharpMin7.DisplayValueWithPitches());
        Assert.Equal("C♯m7 { C♯ E G♯ B }", _cSharpMin7.DisplayValueWithPitches(false));
        Assert.Equal("C#m7 { C# E G# B }", _cSharpMin7.DisplayValueWithPitches(true));
    }

    [Fact]
    public void TryParse_WhenValid_Test()
    {
        var result = Chord.TryParse("C#m7", out var chord);
        Assert.True(result);
        Assert.Equal(_cSharpMin7, chord);
    }

    [Fact]
    public void TryParse_WhenInvalid_Test()
    {
        var result = Chord.TryParse("foobar", out var chord);
        Assert.False(result);
        Assert.Null(chord);
    }

    [Fact]
    public void TryParse_WhenNull_Test()
    {
        var result = Chord.TryParse(null, out var chord);
        Assert.False(result);
        Assert.Null(chord);
    }

    [Fact]
    public void IsMajor_Test()
    {
        Assert.True(_cMaj9.IsMajor);
        Assert.False(_cSharpMin7.IsMajor);
    }

    [Fact]
    public void IsMinor_Test()
    {
        Assert.True(_cSharpMin7.IsMinor);
        Assert.False(_cMaj9.IsMinor);
    }

    [Fact]
    public void IsDiminished_Test()
    {
        Assert.True(_cDim7.IsDiminished);
        Assert.False(_cSharpMin7.IsDiminished);
    }

    [Fact]
    public void IsAugmented_Test()
    {
        Assert.True(_cAug.IsAugmented);
        Assert.False(_cMaj9.IsAugmented);
    }

    [Fact]
    public void IsDominant_Test()
    {
        Assert.True(_cDom13.IsDominant);
        Assert.False(_cMaj9.IsDominant);
    }

    [Fact]
    public void IsAltered_Test()
    {
        Assert.True(_cDom7Sharp9.IsAltered);
        Assert.False(_cDom13.IsAltered);
    }

    [Fact]
    public void IsSuspended_Test()
    {
        Assert.True(_cSus4.IsSuspended);
        Assert.False(_cMaj9.IsSuspended);
    }

    [Fact]
    public void Contains_Test()
    {
        Assert.True(_cMaj9.Contains(Intervals.MajorThird));
        Assert.False(_cMaj9.Contains(Intervals.MinorThird));
    }
}
