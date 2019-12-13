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
        public void Logical_Test()
        {
            Assert.Equal(Pitches.CNatural, Pitches.CNatural.Logical());
            Assert.Equal(Pitches.CNatural, Pitches.BSharp.Logical());
            Assert.Equal(Pitches.CNatural, Pitches.DDoubleFlat.Logical());
            Assert.Equal(Pitches.CSharp, Pitches.CSharp.Logical());
            Assert.Equal(Pitches.DFlat, Pitches.DFlat.Logical());
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
            Assert.True(Pitches.CNatural.EnharmonicallyEquals(Pitches.BSharp));
            Assert.False(Pitches.CNatural.EnharmonicallyEquals(Pitches.BNatural));
            Assert.False(Pitches.CNatural.EnharmonicallyEquals(null as Pitch));
        }

        [Fact]
        public void PitchEquals_Test()
        {
            Assert.True(Pitches.CNatural.Equals(Pitches.CNatural));
            Assert.False(Pitches.CNatural.Equals(Pitches.BSharp));
            Assert.False(Pitches.CNatural.Equals(null as Pitch));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(Pitches.CNatural.Equals((object)Pitches.CNatural));
            Assert.False(Pitches.CNatural.Equals((object)Pitches.BSharp));
            Assert.False(Pitches.CNatural.Equals((object)null));
            Assert.False(Pitches.CNatural.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            Assert.Equal(Pitches.CNatural.GetHashCode(), Pitches.CNatural.GetHashCode());
            Assert.NotEqual(Pitches.CNatural.GetHashCode(), Pitches.BSharp.GetHashCode());
        }
    }
}