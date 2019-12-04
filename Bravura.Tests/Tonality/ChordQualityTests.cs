using System.Collections.Generic;
using Bravura.Tonality.Exceptions;
using Xunit;

namespace Bravura.Tonality.Tests
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
            Assert.Equal(intervals.Count, chordQuality.ChordQualityIntervals.Count);
            for (var i = 0; i < intervals.Count; i++)
            {
                Assert.True(intervals[i] == chordQuality.ChordQualityIntervals[i]);
            }
        }

        [Theory]
        [MemberData(nameof(ChordQualityThrowsData))]
        public void ChordQuality_Throws_Test(string symbol, List<Interval> intervals)
        {
            var exception = Record.Exception(() => new ChordQuality(symbol, symbol, intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraTonalityException>(exception);
        }

        //[Fact(Skip = "Need to figure out equality overrides")]
        //public void ChordQuality_Equality_Test()
        //{
        //    var fakeMinor = new ChordQuality("m", "m", new List<Interval>
        //    {
        //        Intervals.PerfectUnison,
        //        Intervals.MinorThird,
        //        Intervals.PerfectFifth,
        //    });
        //    Assert.True(fakeMinor == Min);
        //    Assert.True(fakeMinor.Equals(Min));
        //    Assert.Equal(fakeMinor.GetHashCode(), Min.GetHashCode());
        //}

        //[Fact(Skip = "Need to figure out equality overrides")]
        //public void ChordQuality_NonEquality_Test()
        //{
        //    var fakeMinor = new ChordQuality("M", "M", new List<Interval>
        //    {
        //        Intervals.PerfectUnison,
        //        Intervals.MinorThird,
        //        Intervals.PerfectFifth,
        //    });
        //    Assert.False(fakeMinor == Maj);
        //    Assert.False(fakeMinor.Equals(Maj));
        //    Assert.NotEqual(fakeMinor.GetHashCode(), Maj.GetHashCode());
        //}
    }
}