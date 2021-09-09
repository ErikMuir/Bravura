using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ChordTests
    {
        private readonly Chord _cMajor = new Chord(Pitches.CNatural, ChordQualities.Maj);
        private readonly Chord _aMinor = new Chord(Pitches.ANatural, ChordQualities.Min);
        private readonly Chord _anotherCMajor = new Chord(Pitches.CNatural, ChordQualities.Maj);

        [Fact]
        public void Constructor_WhenProvidedNullRoot_Throws()
        {
            var exception = Record.Exception(() => new Chord(null, ChordQualities.Maj));
            Assert.NotNull(exception);
            Assert.IsType<ChordException>(exception);
        }

        [Fact]
        public void Constructor_WhenProvidedNullQuality_Throws()
        {
            var exception = Record.Exception(() => new Chord(Pitches.CNatural, null));
            Assert.NotNull(exception);
            Assert.IsType<ChordException>(exception);
        }

        [Fact]
        public void CommonTones_Test()
        {
            var commonTones = _cMajor.CommonTones(_aMinor);
            Assert.Equal(2, commonTones.Count);
            Assert.Contains(Pitches.CNatural, commonTones);
            Assert.Contains(Pitches.ENatural, commonTones);
            Assert.DoesNotContain(Pitches.ANatural, commonTones);
            Assert.DoesNotContain(Pitches.GNatural, commonTones);
        }

        [Fact]
        public void HasSamePitches_Test()
        {
            Assert.True(_cMajor.HasSamePitches(_anotherCMajor));
            Assert.False(_cMajor.HasSamePitches(_aMinor));
        }

        [Fact]
        public void EnharmonicallyEquals_Test()
        {
            var bSharpMajor = new Chord(Pitches.BSharp, ChordQualities.Maj);

            Assert.True(bSharpMajor.EnharmonicallyEquals(_cMajor));
            Assert.False(_aMinor.EnharmonicallyEquals(_cMajor));
        }

        [Fact]
        public void ChordEquals_Test()
        {
            Assert.True(_cMajor.Equals(_anotherCMajor));
            Assert.False(_cMajor.Equals(_aMinor));
            Assert.False(_cMajor.Equals((Chord)null));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(_cMajor.Equals((object)_anotherCMajor));
            Assert.False(_cMajor.Equals((object)_aMinor));
            Assert.False(_cMajor.Equals((object)null));
            Assert.False(_cMajor.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            Assert.Equal(_cMajor.GetHashCode(), _anotherCMajor.GetHashCode());
            Assert.NotEqual(_cMajor.GetHashCode(), _aMinor.GetHashCode());
        }

        // TODO : TryParse_Test()
    }
}
