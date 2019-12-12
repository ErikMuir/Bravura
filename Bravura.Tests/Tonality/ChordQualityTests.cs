using System.Collections.Generic;
using Bravura.Tonality.Exceptions;
using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ChordQualityTests
    {
        public static IEnumerable<object[]> InvalidIntervalsData()
        {
            yield return new object[] { null };
            yield return new object[] { new List<Interval>() };
            yield return new object[] { new List<Interval> { Intervals.PerfectUnison } };
            yield return new object[] { new List<Interval> { Intervals.MajorThird, Intervals.PerfectFifth } };
            yield return new object[] { new List<Interval> { Intervals.PerfectUnison, Intervals.PerfectUnison } };
        }

        [Fact]
        public void Constructor_WhenProvidedNullSymbol_Throws()
        {
            var intervals = new List<Interval> { Intervals.PerfectUnison, Intervals.PerfectFifth };
            var exception = Record.Exception(() => new ChordQuality(null, "", intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraTonalityException>(exception);
        }

        [Fact]
        public void Constructor_WhenProvidedNullAsciiSymbol_Throws()
        {
            var intervals = new List<Interval> { Intervals.PerfectUnison, Intervals.PerfectFifth };
            var exception = Record.Exception(() => new ChordQuality("", null, intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraTonalityException>(exception);
        }

        [Theory]
        [MemberData(nameof(InvalidIntervalsData))]
        public void Constructor_WhenProvidedInvalidIntervals_Throws(List<Interval> intervals)
        {
            var exception = Record.Exception(() => new ChordQuality("", "", intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraTonalityException>(exception);
        }

        [Fact]
        public void QualityEquals_Test()
        {
            var differentMinor = new ChordQuality("-", "-", new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
            });
            Assert.True(differentMinor.QualityEquals(ChordQualities.Min));
            Assert.False(differentMinor.QualityEquals(ChordQualities.Maj));
            Assert.False(differentMinor.QualityEquals(null));
        }

        [Fact]
        public void Equals_Test()
        {
            var minor = new ChordQuality("m", "m", new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
            });
            Assert.True(minor.Equals(ChordQualities.Min));
            Assert.False(minor.Equals(ChordQualities.Maj));
            Assert.False(minor.Equals(null));
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
    }
}