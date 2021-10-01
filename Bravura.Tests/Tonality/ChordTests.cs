using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ChordTests
    {
        private readonly Chord _cMajor = new Chord(Pitches.CNatural, ChordQualities.Maj);
        private readonly Chord _aMinor = new Chord(Pitches.ANatural, ChordQualities.Min);
        private readonly Chord _anotherCMajor = new Chord(Pitches.CNatural, ChordQualities.Maj);

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
        public void TryParse_WhenValid_Test()
        {
            var result = Chord.TryParse("C#m9", out var chord);
            Assert.True(result);
            Assert.Equal(Pitches.CSharp, chord.Root);
            Assert.Equal(ChordQualities.Min9, chord.Quality);
        }

        [Fact]
        public void TryParse_WhenInvalid_Test()
        {
            var result = Chord.TryParse("foobar", out var chord);
            Assert.False(result);
            Assert.Null(chord);
        }

        [Fact]
        public void TryParse_WhenNull_Test()
        {
            var result = Chord.TryParse(null, out var chord);
            Assert.False(result);
            Assert.Null(chord);
        }
    }
}
