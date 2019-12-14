using System.Collections.Generic;
using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ModeTests
    {
        #region -- Member Data --

        public static IEnumerable<object[]> ModeWorksData()
        {
            yield return new object[] {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            yield return new object[]
            {
                "Natural Minor",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MinorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MinorSixth,
                    Intervals.MinorSeventh,
                },
            };
        }

        public static IEnumerable<object[]> ModeThrowsData()
        {
            // name == null
            yield return new object[] {
                null,
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            // noteIndices == null
            yield return new object[]
            {
                "Major",
                null,
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            // noteIndices.Count < 5
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            // noteIndices.Count > 12
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            //  noteIndices < 0
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, -1 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            // noteIndices > 6
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 7 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            // intervals == null
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                null,
            };
            // Count < 5
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                },
            };
            // Count > 12
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
            // Count != noteIndices.Count
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4 },
                new List<Interval>
                {
                    Intervals.PerfectUnison,
                    Intervals.MajorSecond,
                    Intervals.MajorThird,
                    Intervals.PerfectFourth,
                    Intervals.PerfectFifth,
                    Intervals.MajorSixth,
                    Intervals.MajorSeventh,
                },
            };
        }

        #endregion 

        [Theory(Skip = "Figure this out")]
        [MemberData(nameof(ModeWorksData))]
        public void Mode_Works_Test(string name, List<int> noteIndices, List<Interval> intervals)
        {
            var mode = new Mode(name, noteIndices, intervals);
            Assert.IsType<Mode>(mode);
            Assert.Equal(name, mode.Name);
            for (var i = 0; i < noteIndices.Count; i++)
            {
                Assert.Equal(noteIndices[i], mode.NoteIndices[i]);
                Assert.Equal(intervals[i], mode.ModeIntervals[i]);
            }
        }

        [Theory(Skip = "Figure this out")]
        [MemberData(nameof(ModeThrowsData))]
        public void Mode_Throws_Test(string name, List<int> noteIndices, List<Interval> intervals)
        {
            var exception = Record.Exception(() => new Mode(name, noteIndices, intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraTonalityException>(exception);
        }
    }
}
