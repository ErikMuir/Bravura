using Xunit;

namespace Bravura.Tonality.Tests
{
    public class AccidentalTests
    {
        [Fact]
        public void AccidentalEquals_Test()
        {
            Assert.True(Accidentals.Natural.Equals(Accidentals.Natural));
            Assert.False(Accidentals.Natural.Equals(Accidentals.Flat));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(Accidentals.Natural.Equals((object)Accidentals.Natural));
            Assert.False(Accidentals.Natural.Equals((object)Accidentals.Flat));
            Assert.False(Accidentals.Natural.Equals((object)null));
            Assert.False(Accidentals.Natural.Equals(new { Foo = "bar " }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            Assert.Equal(Accidentals.DoubleFlat.GetHashCode(), Accidentals.DoubleFlat.GetHashCode());
            Assert.NotEqual(Accidentals.DoubleFlat.GetHashCode(), Accidentals.Flat.GetHashCode());
        }
    }
}
