using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ModeTests
    {
        private readonly Mode _customAeolian = new Mode("foobar", Modes.Aeolian.Intervals);

        [Fact]
        public void EffectivelyEquals_Test()
        {
            Assert.True(_customAeolian.EffectivelyEquals(Modes.Aeolian));
            Assert.False(_customAeolian.EffectivelyEquals(Modes.Ionian));
        }

        [Fact]
        public void DisplayValue_Test()
        {
            Assert.Equal("Aeolian", Modes.Aeolian.DisplayValue());
            Assert.Equal("Aeolian", Modes.Aeolian.DisplayValue(false));
            Assert.Equal("Aeolian", Modes.Aeolian.DisplayValue(true));
        }

        [Fact]
        public void DisplayValueWithIntervals_Test()
        {
            Assert.Equal("Aeolian { ♮1 ♮2 ♭3 ♮4 ♮5 ♭6 ♭7 }", Modes.Aeolian.DisplayValueWithIntervals());
            Assert.Equal("Aeolian { ♮1 ♮2 ♭3 ♮4 ♮5 ♭6 ♭7 }", Modes.Aeolian.DisplayValueWithIntervals(false));
            Assert.Equal("Aeolian { 1 2 b3 4 5 b6 b7 }", Modes.Aeolian.DisplayValueWithIntervals(true));
        }
    }
}
