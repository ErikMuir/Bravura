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
        public void ToString_Override_Test()
        {
            Assert.Equal("Aeolian", Modes.Aeolian.ToString());
        }

        [Fact]
        public void ToStringWithIntervals_Test()
        {
            Assert.Equal("Aeolian { ♮1 ♮2 ♭3 ♮4 ♮5 ♭6 ♭7 }", Modes.Aeolian.ToStringWithIntervals());
        }

        [Fact]
        public void ToAsciiStringWithIntervals_Test()
        {
            Assert.Equal("Aeolian { 1 2 b3 4 5 b6 b7 }", Modes.Aeolian.ToAsciiStringWithIntervals());
        }
    }
}
