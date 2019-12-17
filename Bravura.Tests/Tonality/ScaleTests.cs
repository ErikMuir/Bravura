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
        public void Constructor_CorrectlySetsScalePitches()
        {
            var eMajor = new Scale(Pitches.ENatural, Modes.Major);
            Assert.Equal(7, eMajor.ScalePitches.Count);
            Assert.Equal(Pitches.ENatural, eMajor.ScalePitches[0]);
            Assert.Equal(Pitches.FSharp, eMajor.ScalePitches[1]);
            Assert.Equal(Pitches.GSharp, eMajor.ScalePitches[2]);
            Assert.Equal(Pitches.ANatural, eMajor.ScalePitches[3]);
            Assert.Equal(Pitches.BNatural, eMajor.ScalePitches[4]);
            Assert.Equal(Pitches.CSharp, eMajor.ScalePitches[5]);
            Assert.Equal(Pitches.DSharp, eMajor.ScalePitches[6]);

            var fSharpMinorPentatonic = new Scale(Pitches.FSharp, Modes.MinorPentatonic);
            Assert.Equal(5, fSharpMinorPentatonic.ScalePitches.Count);
            Assert.Equal(Pitches.FSharp, fSharpMinorPentatonic.ScalePitches[0]);
            Assert.Equal(Pitches.ANatural, fSharpMinorPentatonic.ScalePitches[1]);
            Assert.Equal(Pitches.BNatural, fSharpMinorPentatonic.ScalePitches[2]);
            Assert.Equal(Pitches.CSharp, fSharpMinorPentatonic.ScalePitches[3]);
            Assert.Equal(Pitches.ENatural, fSharpMinorPentatonic.ScalePitches[4]);
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
