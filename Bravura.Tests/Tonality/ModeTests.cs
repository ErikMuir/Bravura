using System.Collections.Generic;
using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ModeTests
    {
        private static readonly List<Interval> _ionianIntervals = new List<Interval>
        {
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.MajorThird,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
            Intervals.MajorSeventh,
        };

        private readonly Mode _ionian = new Mode(ModeNames.Ionian, _ionianIntervals);

        private readonly Mode _foobarIonian = new Mode("foobar", _ionianIntervals);

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   \n \r \t   ")]
        public void Constructor_WhenNameIsNullOrWhiteSpace_ThenThrows(string name)
        {
            var exception = Record.Exception(() => new Mode(name, _ionianIntervals));

            Assert.NotNull(exception);
            Assert.IsType<ModeException>(exception);
        }

        // [Fact]
        // public void Constructor_WhenNoteIndicesAndModeIntervalsAreNotTheSameLength_ThenThrows()
        // {
        //     var noteIndices = new List<int> { 0, 1, 2, 3, 4 };

        //     var exception = Record.Exception(() => new Mode(ModeNames.Ionian, noteIndices, _ionianIntervals));

        //     Assert.NotNull(exception);
        //     Assert.IsType<ModeException>(exception);
        // }

        // [Fact]
        // public void Constructor_WhenNoteIndicesIsNull_ThenThrows()
        // {
        //     var exception = Record.Exception(() => new Mode(ModeNames.Ionian, null, _ionianIntervals));

        //     Assert.NotNull(exception);
        //     Assert.IsType<ModeException>(exception);
        // }

        // [Fact]
        // public void Constructor_WhenNoteIndicesLengthIsLessThanFive_ThenThrows()
        // {
        //     var notEnoughNoteIndices = new List<int> { 0, 1, 2, 3 };

        //     var exception = Record.Exception(() => new Mode(ModeNames.Ionian, notEnoughNoteIndices, _ionianIntervals));

        //     Assert.NotNull(exception);
        //     Assert.IsType<ModeException>(exception);
        // }

        // [Fact]
        // public void Constructor_WhenNoteIndicesLengthIsMoreThanTwelve_ThenThrows()
        // {
        //     var tooManyNoteIndices = new List<int> { 0, 1, 2, 3, 4, 5, 6, 0, 1, 2, 3, 4, 5, 6 };

        //     var exception = Record.Exception(() => new Mode(ModeNames.Ionian, tooManyNoteIndices, _ionianIntervals));

        //     Assert.NotNull(exception);
        //     Assert.IsType<ModeException>(exception);
        // }

        // [Fact]
        // public void Constructor_WhenANoteIndexIsLessThanZero_ThenThrows()
        // {
        //     var noteIndicesWithLessThanZero = new List<int> { 0, 1, 2, 3, 4, 5, -1 };

        //     var exception = Record.Exception(() => new Mode(ModeNames.Ionian, noteIndicesWithLessThanZero, _ionianIntervals));

        //     Assert.NotNull(exception);
        //     Assert.IsType<ModeException>(exception);
        // }

        // [Fact]
        // public void Constructor_WhenANoteIndexIsGreaterThanSix_ThenThrows()
        // {
        //     var noteIndicesWithGreaterThanSix = new List<int> { 0, 1, 2, 3, 4, 5, 7 };

        //     var exception = Record.Exception(() => new Mode(ModeNames.Ionian, noteIndicesWithGreaterThanSix, _ionianIntervals));

        //     Assert.NotNull(exception);
        //     Assert.IsType<ModeException>(exception);
        // }

        [Fact]
        public void Constructor_WhenModeIntervalsIsNull_ThenThrows()
        {
            var exception = Record.Exception(() => new Mode(ModeNames.Ionian, null));

            Assert.NotNull(exception);
            Assert.IsType<ModeException>(exception);
        }

        [Fact]
        public void Constructor_WhenModeIntervalsLengthIsLessThanFive_ThenThrows()
        {
            var notEnoughModeIntervals = new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.MajorThird,
                Intervals.PerfectFourth,
            };

            var exception = Record.Exception(() => new Mode(ModeNames.Ionian, notEnoughModeIntervals));

            Assert.NotNull(exception);
            Assert.IsType<ModeException>(exception);
        }

        [Fact]
        public void Constructor_WhenModeIntervalsLengthIsMoreThanTwelve_ThenThrows()
        {
            var tooManyModeIntervals = new List<Interval>
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
            };

            var exception = Record.Exception(() => new Mode(ModeNames.Ionian, tooManyModeIntervals));

            Assert.NotNull(exception);
            Assert.IsType<ModeException>(exception);
        }

        [Fact]
        public void EffectivelyEquals_Test()
        {
            Assert.True(_foobarIonian.EffectivelyEquals(Modes.Ionian));
            Assert.False(Modes.Ionian.EffectivelyEquals(Modes.Aeolian));
        }

        [Fact]
        public void ModeEquals_Test()
        {
            Assert.True(_ionian.Equals(Modes.Ionian));
            Assert.False(_foobarIonian.Equals(Modes.Ionian));
            Assert.False(Modes.Ionian.Equals(Modes.Aeolian));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(Modes.Ionian.Equals((object)_ionian));
            Assert.False(Modes.Ionian.Equals((object)Modes.Aeolian));
            Assert.False(Modes.Ionian.Equals((object)null));
            Assert.False(Modes.Ionian.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            Assert.Equal(Modes.Ionian.GetHashCode(), _ionian.GetHashCode());
            Assert.NotEqual(Modes.Ionian.GetHashCode(), Modes.Aeolian.GetHashCode());
        }
    }
}
