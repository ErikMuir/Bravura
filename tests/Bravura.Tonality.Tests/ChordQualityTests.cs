namespace Bravura.Tonality.Tests;

public class ChordQualityTests
{
    [Fact]
    public void IsMajor_Test()
    {
        Assert.True(ChordQualities.Maj7.IsMajor);
        Assert.False(ChordQualities.Min7.IsMajor);
    }

    [Fact]
    public void IsMinor_Test()
    {
        Assert.True(ChordQualities.Min7.IsMinor);
        Assert.False(ChordQualities.Maj7.IsMinor);
    }

    [Fact]
    public void IsDiminished_Test()
    {
        Assert.True(ChordQualities.Dim7.IsDiminished);
        Assert.False(ChordQualities.Min7.IsDiminished);
    }

    [Fact]
    public void IsAugmented_Test()
    {
        Assert.True(ChordQualities.Aug.IsAugmented);
        Assert.False(ChordQualities.Maj7.IsAugmented);
    }

    [Fact]
    public void IsDominant_Test()
    {
        Assert.True(ChordQualities.Dom11.IsDominant);
        Assert.False(ChordQualities.Maj9.IsDominant);
    }

    [Fact]
    public void IsAltered_Test()
    {
        Assert.True(ChordQualities.Dom7Sharp9.IsAltered);
        Assert.False(ChordQualities.Dom13.IsAltered);
    }

    [Fact]
    public void IsSuspended_Test()
    {
        Assert.True(ChordQualities.Sus2.IsSuspended);
        Assert.True(ChordQualities.Sus4.IsSuspended);
        Assert.False(ChordQualities.Add11.IsSuspended);
    }

    [Fact]
    public void Contains_Test()
    {
        Assert.True(ChordQualities.Maj.Contains(Intervals.MajorThird));
        Assert.False(ChordQualities.Maj.Contains(Intervals.MinorThird));
    }

    [Fact]
    public void EffectivelyEquals_Test()
    {
        var differentMinor = new ChordQuality("-", [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
        ]);

        Assert.True(differentMinor.EffectivelyEquals(ChordQualities.Min));
        Assert.False(differentMinor.EffectivelyEquals(ChordQualities.Maj));
        Assert.False(differentMinor.EffectivelyEquals(null));
    }

    [Fact]
    public void ToString_Test()
    {
        Assert.Equal("7♯9", ChordQualities.Dom7Sharp9.ToString());
    }

    [Fact]
    public void TryParse_WhenValid_Test()
    {
        var result = ChordQuality.TryParse("Maj7", out var quality);
        Assert.True(result);
        Assert.Equal(ChordQualities.Maj7, quality);
    }

    [Fact]
    public void TryParse_WhenInvalid_Test()
    {
        var result = ChordQuality.TryParse("foobar", out var quality);
        Assert.False(result);
        Assert.Null(quality);
    }

    [Fact]
    public void TryParse_WhenNull_Test()
    {
        var result = ChordQuality.TryParse(null, out var quality);
        Assert.False(result);
        Assert.Null(quality);
    }
}
