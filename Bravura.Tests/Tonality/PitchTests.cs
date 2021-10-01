using Xunit;

namespace Bravura.Tonality.Tests
{
    public class PitchTests
    {
        [Fact]
        public void SemitonesAboveC_Test()
        {
            Assert.Equal(0, Pitches.CNatural.SemitonesAboveC);
            Assert.Equal(1, Pitches.CSharp.SemitonesAboveC);
            Assert.Equal(1, Pitches.DFlat.SemitonesAboveC);
            Assert.Equal(2, Pitches.DNatural.SemitonesAboveC);
        }

        [Fact]
        public void IsFlat_Test()
        {
            Assert.True(Pitches.GDoubleFlat.IsFlat);
            Assert.True(Pitches.GFlat.IsFlat);
            Assert.False(Pitches.GNatural.IsFlat);
            Assert.False(Pitches.GSharp.IsFlat);
            Assert.False(Pitches.GDoubleSharp.IsFlat);
        }

        [Fact]
        public void IsSharp_Test()
        {
            Assert.False(Pitches.GDoubleFlat.IsSharp);
            Assert.False(Pitches.GFlat.IsSharp);
            Assert.False(Pitches.GNatural.IsSharp);
            Assert.True(Pitches.GSharp.IsSharp);
            Assert.True(Pitches.GDoubleSharp.IsSharp);
        }

        [Fact]
        public void Logical_Test()
        {
            Assert.Equal(Pitches.CNatural, Pitches.CNatural.Logical);
            Assert.Equal(Pitches.CNatural, Pitches.BSharp.Logical);
            Assert.Equal(Pitches.CNatural, Pitches.DDoubleFlat.Logical);
            Assert.Equal(Pitches.CSharp, Pitches.CSharp.Logical);
            Assert.Equal(Pitches.DFlat, Pitches.DFlat.Logical);
        }

        [Fact]
        public void GetPitchByIntervalAbove_Test()
        {
            Assert.Equal(Pitches.CNatural, Pitches.CNatural.GetPitchByIntervalAbove(Intervals.PerfectUnison));
            Assert.Equal(Pitches.GNatural, Pitches.CNatural.GetPitchByIntervalAbove(Intervals.PerfectFifth));
        }

        [Fact]
        public void GetPitchByIntervalBelow_Test()
        {
            Assert.Equal(Pitches.CNatural, Pitches.CNatural.GetPitchByIntervalBelow(Intervals.PerfectUnison));
            Assert.Equal(Pitches.FNatural, Pitches.CNatural.GetPitchByIntervalBelow(Intervals.PerfectFifth));
        }

        [Fact]
        public void EnharmonicallyEquals_Test()
        {
            Assert.True(Pitches.CNatural.EnharmonicallyEquals(Pitches.CNatural));
            Assert.True(Pitches.CNatural.EnharmonicallyEquals(Pitches.BSharp));
            Assert.False(Pitches.CNatural.EnharmonicallyEquals(Pitches.BNatural));
            Assert.False(Pitches.CNatural.EnharmonicallyEquals(null as Pitch));
        }

        [Fact]
        public void ToString_Override_Test()
        {
            Assert.Equal("G♭♭", Pitches.GDoubleFlat.ToString());
            Assert.Equal("G♭", Pitches.GFlat.ToString());
            Assert.Equal("G", Pitches.GNatural.ToString());
            Assert.Equal("G♯", Pitches.GSharp.ToString());
            Assert.Equal("G♯♯", Pitches.GDoubleSharp.ToString());
        }

        [Fact]
        public void ToString_Overload_Test()
        {
            Assert.Equal("G♭♭", Pitches.GDoubleFlat.ToString(true));
            Assert.Equal("G♭", Pitches.GFlat.ToString(true));
            Assert.Equal("G♮", Pitches.GNatural.ToString(true));
            Assert.Equal("G♯", Pitches.GSharp.ToString(true));
            Assert.Equal("G♯♯", Pitches.GDoubleSharp.ToString(true));
            Assert.Equal("G♭♭", Pitches.GDoubleFlat.ToString(false));
            Assert.Equal("G♭", Pitches.GFlat.ToString(false));
            Assert.Equal("G", Pitches.GNatural.ToString(false));
            Assert.Equal("G♯", Pitches.GSharp.ToString(false));
            Assert.Equal("G♯♯", Pitches.GDoubleSharp.ToString(false));
        }

        [Fact]
        public void ToAsciiString_Test()
        {
            Assert.Equal("Gbb", Pitches.GDoubleFlat.ToAsciiString());
            Assert.Equal("Gb", Pitches.GFlat.ToAsciiString());
            Assert.Equal("G", Pitches.GNatural.ToAsciiString());
            Assert.Equal("G#", Pitches.GSharp.ToAsciiString());
            Assert.Equal("G##", Pitches.GDoubleSharp.ToAsciiString());
        }

        [Theory]
        [InlineData("G♭♭")]
        [InlineData("Gbb")]
        public void TryParse_DoubleFlat_Test(string value)
        {
            var result = Pitch.TryParse(value, out var pitch);
            Assert.True(result);
            Assert.Equal(Pitches.GDoubleFlat, pitch);
        }

        [Theory]
        [InlineData("G♭")]
        [InlineData("Gb")]
        public void TryParse_Flat_Test(string value)
        {
            var result = Pitch.TryParse(value, out var pitch);
            Assert.True(result);
            Assert.Equal(Pitches.GFlat, pitch);
        }

        [Fact]
        public void TryParse_Natural_Test()
        {
            var result = Pitch.TryParse("G", out var pitch);
            Assert.True(result);
            Assert.Equal(Pitches.GNatural, pitch);
        }

        [Theory]
        [InlineData("G♯")]
        [InlineData("G#")]
        public void TryParse_Sharp_Test(string value)
        {
            var result = Pitch.TryParse(value, out var pitch);
            Assert.True(result);
            Assert.Equal(Pitches.GSharp, pitch);
        }

        [Theory]
        [InlineData("G♯♯")]
        [InlineData("G##")]
        public void TryParse_DoubleSharp_Test(string value)
        {
            var result = Pitch.TryParse(value, out var pitch);
            Assert.True(result);
            Assert.Equal(Pitches.GDoubleSharp, pitch);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("     ")]
        [InlineData("foobar")]
        public void TryParse_Fails_Test(string value)
        {
            var result = Pitch.TryParse(value, out var pitch);
            Assert.False(result);
            Assert.Null(pitch);
        }
    }
}
