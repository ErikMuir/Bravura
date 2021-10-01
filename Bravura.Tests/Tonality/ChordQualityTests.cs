using System.Collections.Generic;
using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ChordQualityTests
    {
        [Fact]
        public void EffectivelyEquals_Test()
        {
            var differentMinor = new ChordQuality("-", "-", new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
            });

            Assert.True(differentMinor.EffectivelyEquals(ChordQualities.Min));
            Assert.False(differentMinor.EffectivelyEquals(ChordQualities.Maj));
            Assert.False(differentMinor.EffectivelyEquals(null));
        }

        [Fact]
        public void ToString_Override_Test()
        {
            Assert.Equal("7♯9", ChordQualities.Dom7Sharp9.ToString());
        }

        [Fact]
        public void ToAsciiString_Test()
        {
            Assert.Equal("7#9", ChordQualities.Dom7Sharp9.ToAsciiString());
        }

        [Fact]
        public void ToStringWithIntervals_Test()
        {
            Assert.Equal("m7♭5 { ♮1 ♭3 ♭5 ♭7 }", ChordQualities.Min7Flat5.ToStringWithIntervals());
        }

        [Fact]
        public void ToAsciiStringWithIntervals_Test()
        {
            Assert.Equal("m7b5 { 1 b3 b5 b7 }", ChordQualities.Min7Flat5.ToAsciiStringWithIntervals());
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
}
