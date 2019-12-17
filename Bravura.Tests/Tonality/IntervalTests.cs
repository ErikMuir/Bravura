using Xunit;

namespace Bravura.Tonality.Tests
{
    public class IntervalTests
    {
        private readonly Interval _unison = new Interval(0, Accidentals.Natural, 0, IntervalNames.PerfectUnison, IntervalSymbols.PerfectUnison);
        private readonly Interval _foobarUnison = new Interval(0, Accidentals.Natural, 0, "foobar", "foobar");

        [Fact]
        public void Constructor_WhenNoteIndexIsLessThanZero_ThenThrows()
        {
            short noteIndex = -1;

            var exception = Record.Exception(() => new Interval(0, Accidentals.Natural, noteIndex, "foobar", "foobar"));

            Assert.NotNull(exception);
            Assert.IsType<IntervalException>(exception);
        }

        [Fact]
        public void Constructor_WhenNoteIndexIsMoreThanSeven_ThenThrows()
        {
            short noteIndex = 8;

            var exception = Record.Exception(() => new Interval(0, Accidentals.Natural, noteIndex, "foobar", "foobar"));

            Assert.NotNull(exception);
            Assert.IsType<IntervalException>(exception);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   \n \r \t   ")]
        public void Constructor_WhenNameIsNotProvided_ThenThrows(string name)
        {
            var exception = Record.Exception(() => new Interval(0, Accidentals.Natural, 0, name, "foobar"));

            Assert.NotNull(exception);
            Assert.IsType<IntervalException>(exception);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   \n \r \t   ")]
        public void Constructor_WhenSymbolIsNotProvided_ThenThrows(string symbol)
        {
            var exception = Record.Exception(() => new Interval(0, Accidentals.Natural, 0, "foobar", symbol));

            Assert.NotNull(exception);
            Assert.IsType<IntervalException>(exception);
        }

        [Fact]
        public void EffectivelyEquals_Test()
        {
            Assert.True(Intervals.PerfectUnison.EffectivelyEquals(_foobarUnison));
            Assert.True(Intervals.PerfectUnison.EffectivelyEquals(Intervals.DiminishedSecond));
            Assert.True(Intervals.DiminishedSecond.EffectivelyEquals(Intervals.PerfectUnison));
            Assert.False(Intervals.MinorSecond.EffectivelyEquals(Intervals.MajorSecond));
            Assert.False(Intervals.PerfectUnison.EffectivelyEquals(Intervals.PerfectOctave));
        }

        [Fact]
        public void IntervalEquals_Test()
        {
            Assert.True(Intervals.PerfectUnison.Equals(_unison));
            Assert.False(Intervals.PerfectUnison.Equals(Intervals.MinorSecond));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(Intervals.PerfectUnison.Equals(_unison));
            Assert.False(Intervals.PerfectUnison.Equals((object)Intervals.MinorSecond));
            Assert.False(Intervals.PerfectUnison.Equals((object)null));
            Assert.False(Intervals.PerfectUnison.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            Assert.Equal(Intervals.PerfectUnison.GetHashCode(), _unison.GetHashCode());
            Assert.NotEqual(Intervals.PerfectUnison.GetHashCode(), Intervals.MinorSecond.GetHashCode());
        }
    }
}
