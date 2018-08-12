using System.Collections.Generic;
using Bravura.Exceptions;
using Xunit;

namespace Bravura.Tests
{
    public class ChordQualityTests
    {
        #region -- Private Members --

        private static readonly List<Interval> ZeroIntervals = new List<Interval>();

        private static readonly List<Interval> OneInterval = new List<Interval>
        {
            Theory.PerfectUnison,
        };

        private static readonly List<Interval> TwoIntervalsGood = new List<Interval>
        {
            Theory.PerfectUnison,
            Theory.PerfectFifth,
        };

        private static readonly List<Interval> TwoIntervalsBad = new List<Interval>
        {
            Theory.MajorThird,
            Theory.PerfectFifth,
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
                Theory.PerfectUnison,
                Theory.MajorThird,
                Theory.PerfectFifth,
            });
            Assert.True(fakeMajor == Theory.Maj);
            Assert.True(fakeMajor.Equals(Theory.Maj));
            Assert.Equal(fakeMajor.GetHashCode(), Theory.Maj.GetHashCode());
        }

        [Fact]
        public void ChordQuality_NonEquality_Test()
        {
            var fakeMinor = new ChordQuality("M", "M", new List<Interval>
            {
                Theory.PerfectUnison,
                Theory.MinorThird,
                Theory.PerfectFifth,
            });
            Assert.False(fakeMinor == Theory.Maj);
            Assert.False(fakeMinor.Equals(Theory.Maj));
            Assert.NotEqual(fakeMinor.GetHashCode(), Theory.Maj.GetHashCode());
        }
    }
}