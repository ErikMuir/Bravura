using Xunit;

namespace Bravura.Tonality.Tests
{
    public class IntervalTests
    {
        private readonly Interval _customUnison = new Interval(0, Accidentals.Natural, 1, "foobar", "foobar");

        [Fact]
        public void EffectivelyEquals_Test()
        {
            Assert.True(Intervals.PerfectUnison.EffectivelyEquals(_customUnison));
            Assert.True(Intervals.PerfectUnison.EffectivelyEquals(Intervals.DiminishedSecond));
            Assert.True(Intervals.DiminishedSecond.EffectivelyEquals(Intervals.PerfectUnison));
            Assert.False(Intervals.MinorSecond.EffectivelyEquals(Intervals.MajorSecond));
            Assert.False(Intervals.PerfectUnison.EffectivelyEquals(Intervals.PerfectOctave));
        }

        [Fact]
        public void DisplayValue_Test()
        {
            Assert.Equal("♭3", Intervals.MinorThird.DisplayValue());
            Assert.Equal("♭3", Intervals.MinorThird.DisplayValue(false));
            Assert.Equal("b3", Intervals.MinorThird.DisplayValue(true));
        }
    }
}
