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
            var scale = new Scale(Pitches.CNatural, Modes.Major);

            var pitches = scale.ScalePitches;
            Assert.Equal(7, pitches.Count);
            Assert.Equal(Pitches.CNatural, pitches[0]);
            Assert.Equal(Pitches.DNatural, pitches[1]);
            Assert.Equal(Pitches.ENatural, pitches[2]);
            Assert.Equal(Pitches.FNatural, pitches[3]);
            Assert.Equal(Pitches.GNatural, pitches[4]);
            Assert.Equal(Pitches.ANatural, pitches[5]);
            Assert.Equal(Pitches.BNatural, pitches[6]);
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
