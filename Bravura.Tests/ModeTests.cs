using System.Collections.Generic;
using Bravura.Exceptions;
using Xunit;

namespace Bravura.Tests
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
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            yield return new object[]
            {
                "Natural Minor",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MinorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MinorSixth,
                    Theory.MinorSeventh,
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
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            // noteIndices == null
            yield return new object[]
            {
                "Major",
                null,
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            // noteIndices.Count < 5
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            // noteIndices.Count > 12
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            //  noteIndices < 0
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, -1 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            // noteIndices > 6
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 7 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            // intervals == null
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                null,
            };
            // Theory.Count < 5
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                },
            };
            // Theory.Count > 12
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4, 5, 6 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
            // Theory.Count != noteIndices.Count
            yield return new object[]
            {
                "Major",
                new List<int> { 0, 1, 2, 3, 4 },
                new List<Interval>
                {
                    Theory.PerfectUnison,
                    Theory.MajorSecond,
                    Theory.MajorThird,
                    Theory.PerfectFourth,
                    Theory.PerfectFifth,
                    Theory.MajorSixth,
                    Theory.MajorSeventh,
                },
            };
        }

        #endregion 

        [Theory]
        [MemberData(nameof(ModeWorksData))]
        public void Mode_Works_Test(string name, List<int> noteIndices, List<Interval> intervals)
        {
            var mode = new Mode(name, noteIndices, intervals);
            Assert.IsType<Mode>(mode);
            Assert.Equal(name, mode.Name);
            for (var i = 0; i < noteIndices.Count; i++)
            {
                Assert.Equal(noteIndices[i], mode.NoteIndices[i]);
                Assert.Equal(intervals[i], mode.Intervals[i]);
            }
        }

        [Theory]
        [MemberData(nameof(ModeThrowsData))]
        public void Mode_Throws_Test(string name, List<int> noteIndices, List<Interval> intervals)
        {
            var exception = Record.Exception(() => new Mode(name, noteIndices, intervals));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }
    }
}
