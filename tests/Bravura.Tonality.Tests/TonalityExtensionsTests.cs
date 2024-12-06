namespace Bravura.Tonality.Tests;

public class TonalityExtensionsTests
{
    private static readonly Chord _cSharpMin7 = new(Pitches.CSharp, ChordQualities.Min7);

    [Fact]
    public void Intervals_ToString_Test()
    {
        Assert.Equal("♮1 ♭3 ♭5 ♭7", ChordQualities.Min7Flat5.Intervals.JoinToString());
    }

    [Fact]
    public void Pitches_ToString_Test()
    {
        Assert.Equal("C♯ E G♯ B", _cSharpMin7.Pitches.JoinToString());
    }
}
