using Xunit;

namespace Bravura.Tonality.Tests
{
    public class IntervalTests
    {
        [Fact]
        public void Constructor_WhenNoteIndexIsLessThanOne_ThenThrows()
        {
            short noteIndex = 0;

            var exception = Record.Exception(() => new Interval(0, Accidentals.Natural, noteIndex, "foobar", "foobar"));

            Assert.NotNull(exception);
            Assert.IsType<IntervalException>(exception);
        }

        [Fact]
        public void Constructor_WhenNoteIndexIsMoreThanEight_ThenThrows()
        {
            short noteIndex = 9;

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
            var exception = Record.Exception(() => new Interval(0, Accidentals.Natural, 1, name, "foobar"));

            Assert.NotNull(exception);
            Assert.IsType<IntervalException>(exception);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   \n \r \t   ")]
        public void Constructor_WhenSymbolIsNotProvided_ThenThrows(string symbol)
        {
            var exception = Record.Exception(() => new Interval(0, Accidentals.Natural, 1, "foobar", symbol));

            Assert.NotNull(exception);
            Assert.IsType<IntervalException>(exception);
        }

        [Fact]
        public void EffectivelyEquals_Test()
        {
            var unison = new Interval(0, Accidentals.Natural, 1, "foobar", "foobar");

            Assert.True(Intervals.PerfectUnison.EffectivelyEquals(unison));
            Assert.True(Intervals.PerfectUnison.EffectivelyEquals(Intervals.DiminishedSecond));
            Assert.True(Intervals.DiminishedSecond.EffectivelyEquals(Intervals.PerfectUnison));
            Assert.False(Intervals.MinorSecond.EffectivelyEquals(Intervals.MajorSecond));
            Assert.False(Intervals.PerfectUnison.EffectivelyEquals(Intervals.PerfectOctave));
        }

        [Fact]
        public void IntervalEquals_Test()
        {
            var unison = new Interval(0, Accidentals.Natural, 1, IntervalNames.PerfectUnison, IntervalSymbols.PerfectUnison);

            Assert.True(Intervals.PerfectUnison.Equals(unison));
            Assert.False(Intervals.PerfectUnison.Equals(Intervals.MinorSecond));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            var unison = new Interval(0, Accidentals.Natural, 1, IntervalNames.PerfectUnison, IntervalSymbols.PerfectUnison);

            Assert.True(Intervals.PerfectUnison.Equals(unison));
            Assert.False(Intervals.PerfectUnison.Equals((object)Intervals.MinorSecond));
            Assert.False(Intervals.PerfectUnison.Equals((object)null));
            Assert.False(Intervals.PerfectUnison.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            var unison = new Interval(0, Accidentals.Natural, 1, IntervalNames.PerfectUnison, IntervalSymbols.PerfectUnison);

            Assert.Equal(Intervals.PerfectUnison.GetHashCode(), unison.GetHashCode());
            Assert.NotEqual(Intervals.PerfectUnison.GetHashCode(), Intervals.MinorSecond.GetHashCode());
        }
    }
}
