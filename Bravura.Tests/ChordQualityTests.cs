using System.Collections.Generic;
using Xunit;

namespace Bravura.Tests
{
    public class ChordQualityTests
    {
        [Theory]
        [MemberData(nameof(ChordQualityWorksData))]
        public void ChordQuality_Works_Test(string symbol, List<Interval> intervals)
        {
            var chordQuality = new ChordQuality(symbol, intervals);
            Assert.IsType<ChordQuality>(chordQuality);
            Assert.Equal(symbol, chordQuality.Symbol);
            Assert.Equal(intervals.Count, chordQuality.Intervals.Count);
            for (var i = 0; i < intervals.Count; i++)
            {
                Assert.True(intervals[i] == chordQuality.Intervals[i]);
            }
        }

        [Theory]
        [MemberData(nameof(ChordQualityThrowsData))]
        public void ChordQuality_Throws_Test(string symbol, List<Interval> intervals)
        {
            var exception = Record.Exception(() => new ChordQuality(symbol, intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        private static readonly List<Interval> ZeroIntervals = new List<Interval>();

        private static readonly List<Interval> OneInterval = new List<Interval>
        {
            Intervals.PerfectFifth,
        };

        private static readonly List<Interval> TwoIntervals = new List<Interval>
        {
            Intervals.MajorThird,
            Intervals.PerfectFifth,
        };

        public static IEnumerable<object[]> ChordQualityWorksData()
        {
            yield return new object[] { "", TwoIntervals };
        }

        public static IEnumerable<object[]> ChordQualityThrowsData()
        {
            yield return new object[] { null, TwoIntervals };
            yield return new object[] { "", null };
            yield return new object[] { "", ZeroIntervals };
            yield return new object[] { "", OneInterval };
        }
    }
}