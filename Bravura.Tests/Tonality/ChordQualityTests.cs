using System.Collections.Generic;
using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ChordQualityTests
    {
        [Fact]
        public void Constructor_WhenProvidedNullSymbol_Throws()
        {
            var intervals = new List<Interval> { Intervals.PerfectUnison, Intervals.PerfectFifth };

            var exception = Record.Exception(() => new ChordQuality(null, "", intervals));

            Assert.NotNull(exception);
            Assert.IsType<ChordQualityException>(exception);
        }

        [Fact]
        public void Constructor_WhenProvidedNullAsciiSymbol_Throws()
        {
            var intervals = new List<Interval> { Intervals.PerfectUnison, Intervals.PerfectFifth };

            var exception = Record.Exception(() => new ChordQuality("", null, intervals));

            Assert.NotNull(exception);
            Assert.IsType<ChordQualityException>(exception);
        }

        public static IEnumerable<object[]> InvalidIntervalsData()
        {
            yield return new object[] { null };
            yield return new object[] { new List<Interval>() };
            yield return new object[] { new List<Interval> { Intervals.PerfectUnison } };
            yield return new object[] { new List<Interval> { Intervals.MajorThird, Intervals.PerfectFifth } };
            yield return new object[] { new List<Interval> { Intervals.PerfectUnison, Intervals.PerfectUnison } };
        }

        [Theory]
        [MemberData(nameof(InvalidIntervalsData))]
        public void Constructor_WhenProvidedInvalidIntervals_Throws(List<Interval> intervals)
        {
            var exception = Record.Exception(() => new ChordQuality("", "", intervals));

            Assert.NotNull(exception);
            Assert.IsType<ChordQualityException>(exception);
        }

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
        public void ChordQualityEquals_Test()
        {
            var minor = new ChordQuality("m", "m", new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
            });

            Assert.True(minor.Equals(ChordQualities.Min));
            Assert.False(minor.Equals(ChordQualities.Maj));
            Assert.False(minor.Equals(null as ChordQuality));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(ChordQualities.Maj.Equals((object)ChordQualities.Maj));
            Assert.False(ChordQualities.Maj.Equals((object)ChordQualities.Min));
            Assert.False(ChordQualities.Maj.Equals((object)null));
            Assert.False(ChordQualities.Maj.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            var minor = new ChordQuality("m", "m", new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
            });

            Assert.Equal(minor.GetHashCode(), ChordQualities.Min.GetHashCode());
            Assert.NotEqual(minor.GetHashCode(), ChordQualities.Maj.GetHashCode());
        }

        // TODO : TryParse_Test()
    }
}