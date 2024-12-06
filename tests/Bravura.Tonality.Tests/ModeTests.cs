namespace Bravura.Tonality.Tests;

public class ModeTests
{
    private static readonly Mode _customAeolian = new Mode("foobar", Modes.Aeolian.Intervals);

    [Fact]
    public void EffectivelyEquals_Test()
    {
        Assert.True(_customAeolian.EffectivelyEquals(Modes.Aeolian));
        Assert.False(_customAeolian.EffectivelyEquals(Modes.Ionian));
    }

    [Fact]
    public void ToString_Test()
    {
        Assert.Equal("Aeolian", Modes.Aeolian.ToString());
    }
}
