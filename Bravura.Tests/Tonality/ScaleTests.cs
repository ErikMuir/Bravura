using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ScaleTests
    {
        private readonly Scale _cMajor = new Scale(Pitches.CNatural, Modes.Major);
        private readonly Scale _bSharpMajor = new Scale(Pitches.BSharp, Modes.Major);
        private readonly Scale _cMinor = new Scale(Pitches.CNatural, Modes.NaturalMinor);


        [Fact]
        public void Constructor_WhenRootIsNull_ThenThrows()
        {
            var exception = Record.Exception(() => new Scale(null, Modes.Ionian));

            Assert.NotNull(exception);
            Assert.IsType<ScaleException>(exception);
        }

        [Fact]
        public void Constructor_WhenModeIsNull_ThenThrows()
        {
            var exception = Record.Exception(() => new Scale(Pitches.CNatural, null));

            Assert.NotNull(exception);
            Assert.IsType<ScaleException>(exception);
        }

        [Fact]
        public void Constructor_CorrectlySetsPitches()
        {
            var eMajor = new Scale(Pitches.ENatural, Modes.Major);
            Assert.Equal(7, eMajor.Pitches.Count);
            Assert.Equal(Pitches.ENatural, eMajor.Pitches[0]);
            Assert.Equal(Pitches.FSharp, eMajor.Pitches[1]);
            Assert.Equal(Pitches.GSharp, eMajor.Pitches[2]);
            Assert.Equal(Pitches.ANatural, eMajor.Pitches[3]);
            Assert.Equal(Pitches.BNatural, eMajor.Pitches[4]);
            Assert.Equal(Pitches.CSharp, eMajor.Pitches[5]);
            Assert.Equal(Pitches.DSharp, eMajor.Pitches[6]);

            var fSharpMinorPentatonic = new Scale(Pitches.FSharp, Modes.MinorPentatonic);
            Assert.Equal(5, fSharpMinorPentatonic.Pitches.Count);
            Assert.Equal(Pitches.FSharp, fSharpMinorPentatonic.Pitches[0]);
            Assert.Equal(Pitches.ANatural, fSharpMinorPentatonic.Pitches[1]);
            Assert.Equal(Pitches.BNatural, fSharpMinorPentatonic.Pitches[2]);
            Assert.Equal(Pitches.CSharp, fSharpMinorPentatonic.Pitches[3]);
            Assert.Equal(Pitches.ENatural, fSharpMinorPentatonic.Pitches[4]);
        }

        [Fact]
        public void EnharmonicallyEquals_Test()
        {
            Assert.True(_cMajor.EnharmonicallyEquals(_bSharpMajor));
            Assert.False(_cMajor.EnharmonicallyEquals(_cMinor));
        }

        [Fact]
        public void ScaleEquals_Test()
        {
            Assert.True(_cMajor.Equals(_cMajor));
            Assert.False(_cMajor.Equals(_bSharpMajor));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(_cMajor.Equals((object)_cMajor));
            Assert.False(_cMajor.Equals((object)_bSharpMajor));
            Assert.False(_cMajor.Equals((object)null));
            Assert.False(_cMajor.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            Assert.Equal(_cMajor.GetHashCode(), _cMajor.GetHashCode());
            Assert.NotEqual(_cMajor.GetHashCode(), _bSharpMajor.GetHashCode());
        }
    }
}
