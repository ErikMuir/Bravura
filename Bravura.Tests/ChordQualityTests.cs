using System.Collections.Generic;
using Bravura.Exceptions;
using Bravura.Theory;
using Xunit;

namespace Bravura.Tests
{
    public class ChordQualityTests
    {
        #region -- Private Members --

        private static readonly List<Interval> ZeroIntervals = new List<Interval>();

        private static readonly List<Interval> OneInterval = new List<Interval>
        {
            Intervals.PerfectUnison,
        };

        private static readonly List<Interval> TwoIntervalsGood = new List<Interval>
        {
            Intervals.PerfectUnison,
            Intervals.PerfectFifth,
        };

        private static readonly List<Interval> TwoIntervalsBad = new List<Interval>
        {
            Intervals.MajorThird,
            Intervals.PerfectFifth,
        };

        #endregion 

        #region -- Member Data -- 

        public static IEnumerable<object[]> ChordQualityThrowsData()
        {
            yield return new object[] { null, TwoIntervalsGood };
            yield return new object[] { "", null };
            yield return new object[] { "", ZeroIntervals };
            yield return new object[] { "", OneInterval };
            yield return new object[] { "", TwoIntervalsBad };
        }

        #endregion 

        [Fact]
        public void ChordQuality_Works_Test()
        {
            const string symbol = "";
            var intervals = TwoIntervalsGood;
            var chordQuality = new ChordQuality(symbol, symbol, intervals);
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
            var exception = Record.Exception(() => new ChordQuality(symbol, symbol, intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        [Fact]
        public void ChordQuality_Equality_Test()
        {
            var fakeMajor = new ChordQuality("M", "M", new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
            });
            Assert.True(fakeMajor == ChordQualities.Maj);
            Assert.True(fakeMajor.Equals(ChordQualities.Maj));
            Assert.Equal(fakeMajor.GetHashCode(), ChordQualities.Maj.GetHashCode());
        }
    }
}