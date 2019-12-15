using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ChordTests
    {
        [Fact(Skip = "Figure this out")]
        public void Constructor_WhenProvidedNullRoot_Throws()
        {
            var exception = Record.Exception(() => new Chord(null, ChordQualities.Maj));
            Assert.NotNull(exception);
            Assert.IsType<ChordException>(exception);
        }

        [Fact]
        public void Constructor_WhenProvidedNullChordQuality_Throws()
        {
            var exception = Record.Exception(() => new Chord(Pitches.CNatural, null));
            Assert.NotNull(exception);
            Assert.IsType<ChordException>(exception);
        }

        [Fact(Skip = "Figure this out")]
        public void CommonTones_Test()
        {
            var cMajor = new Chord(Pitches.CNatural, ChordQualities.Maj);
            var aMinor = new Chord(Pitches.ANatural, ChordQualities.Min);
            var commonTones = cMajor.CommonTones(aMinor);
            Assert.Equal(2, commonTones.Count);
            Assert.Contains(Pitches.CNatural, commonTones);
            Assert.Contains(Pitches.ENatural, commonTones);
            Assert.DoesNotContain(Pitches.ANatural, commonTones);
            Assert.DoesNotContain(Pitches.GNatural, commonTones);
        }
    }
}
