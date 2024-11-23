using Bravura.Tonality;
using Xunit;

namespace Bravura.Tests.Tonality;

public class ScaleTests
{
    private static readonly Scale _cSharpMinor = new Scale(Pitches.CSharp, Modes.NaturalMinor);
    private static readonly Scale _fSharpMinorPentatonic = new Scale(Pitches.FSharp, Modes.MinorPentatonic);
    private static readonly Scale _dFlatMinor = new Scale(Pitches.DFlat, Modes.NaturalMinor);
    private static readonly Scale _cMajor = new Scale(Pitches.CNatural, Modes.Major);

    [Fact]
    public void Pitches_Test()
    {
        Assert.Equal(7, _cSharpMinor.Pitches.Count);
        Assert.Equal(Pitches.CSharp, _cSharpMinor.Pitches[0]);
        Assert.Equal(Pitches.DSharp, _cSharpMinor.Pitches[1]);
        Assert.Equal(Pitches.ENatural, _cSharpMinor.Pitches[2]);
        Assert.Equal(Pitches.FSharp, _cSharpMinor.Pitches[3]);
        Assert.Equal(Pitches.GSharp, _cSharpMinor.Pitches[4]);
        Assert.Equal(Pitches.ANatural, _cSharpMinor.Pitches[5]);
        Assert.Equal(Pitches.BNatural, _cSharpMinor.Pitches[6]);

        Assert.Equal(5, _fSharpMinorPentatonic.Pitches.Count);
        Assert.Equal(Pitches.FSharp, _fSharpMinorPentatonic.Pitches[0]);
        Assert.Equal(Pitches.ANatural, _fSharpMinorPentatonic.Pitches[1]);
        Assert.Equal(Pitches.BNatural, _fSharpMinorPentatonic.Pitches[2]);
        Assert.Equal(Pitches.CSharp, _fSharpMinorPentatonic.Pitches[3]);
        Assert.Equal(Pitches.ENatural, _fSharpMinorPentatonic.Pitches[4]);
    }

    [Fact]
    public void EnharmonicallyEquals_Test()
    {
        Assert.True(_cSharpMinor.EnharmonicallyEquals(_dFlatMinor));
        Assert.False(_cSharpMinor.EnharmonicallyEquals(_cMajor));
    }

    [Fact]
    public void DisplayValue_Test()
    {
        Assert.Equal("C♯ Natural Minor", _cSharpMinor.DisplayValue());
        Assert.Equal("C♯ Natural Minor", _cSharpMinor.DisplayValue(false));
        Assert.Equal("C# Natural Minor", _cSharpMinor.DisplayValue(true));
    }

    [Fact]
    public void DisplayValueWithPitches_Test()
    {
        Assert.Equal("C♯ Natural Minor: C♯ D♯ E F♯ G♯ A B", _cSharpMinor.DisplayValueWithPitches());
        Assert.Equal("C♯ Natural Minor: C♯ D♯ E F♯ G♯ A B", _cSharpMinor.DisplayValueWithPitches(false));
        Assert.Equal("C# Natural Minor: C# D# E F# G# A B", _cSharpMinor.DisplayValueWithPitches(true));
    }
}
