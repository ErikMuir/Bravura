using Xunit;

namespace Bravura.Tests
{
    public class AccidentalTests
    {
        [Theory]
        [InlineData(-2, "Double Flat", "♭♭", "♭♭", "bb")]
        [InlineData(-1, "Flat", "♭", "♭", "b")]
        [InlineData(0, "Natural", "", "♮", "")]
        [InlineData(1, "Sharp", "♯", "♯", "#")]
        [InlineData(2, "Double Sharp", "♯♯", "♯♯", "##")]
        public void Accidental_Works_Test(int value, string name, string defaultSymbol, string actualSymbol, string asciiSymbol)
        {
            var accidental = new Accidental(value, name, defaultSymbol, actualSymbol, asciiSymbol);
            Assert.IsType<Accidental>(accidental);
            Assert.Equal(value, accidental.Value);
            Assert.Equal(name, accidental.Name);
            Assert.Equal(defaultSymbol, accidental.DefaultSymbol);
            Assert.Equal(actualSymbol, accidental.ActualSymbol);
            Assert.Equal(asciiSymbol, accidental.AsciiSymbol);
            Assert.True(accidental.Value >= -2);
            Assert.True(accidental.Value <= 2);
        }

        [Theory]
        [InlineData(-3, "", "", "", "")]
        [InlineData(3, "", "", "", "")]
        [InlineData(0, null, "", "", "")]
        [InlineData(0, "", null, "", "")]
        [InlineData(0, "", "", null, "")]
        [InlineData(0, "", "", "", null)]
        public void Accidental_Throws_Test(int value, string name, string defaultSymbol, string actualSymbol, string asciiSymbol)
        {
            var exception = Record.Exception(() => new Accidental(value, name, defaultSymbol, actualSymbol, asciiSymbol));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        [Fact]
        public void Accidental_Equality_Test()
        {
            var fakeFlat = new Accidental(-1, "Fake Flat", "-", "-", "-");
            Assert.True(fakeFlat == Accidentals.Flat);
            Assert.True(fakeFlat.Equals(Accidentals.Flat));
            Assert.Equal(fakeFlat.GetHashCode(), Accidentals.Flat.GetHashCode());
        }
    }
}