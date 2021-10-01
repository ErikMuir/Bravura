using Xunit;

namespace Bravura.Tonality.Tests
{
    public class ChordTests
    {
        private readonly Chord _cMajor = new Chord(Pitches.CNatural, ChordQualities.Maj);
        private readonly Chord _aMinor = new Chord(Pitches.ANatural, ChordQualities.Min);
        private readonly Chord _cSharpMin7 = new Chord(Pitches.CSharp, ChordQualities.Min7);

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
            var eSus4 = new Chord(Pitches.ENatural, ChordQualities.Sus4);
            var aSus2 = new Chord(Pitches.ANatural, ChordQualities.Sus2);
            Assert.True(eSus4.HasSamePitches(aSus2));
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
        public void ToString_Override_Test()
        {
            Assert.Equal("C♯m7", _cSharpMin7.ToString());
        }

        [Fact]
        public void ToAsciiString_Test()
        {
            Assert.Equal("C#m7", _cSharpMin7.ToAsciiString());
        }

        [Fact]
        public void ToStringWithPitches_Test()
        {
            Assert.Equal("C♯m7 { C♯ E G♯ B }", _cSharpMin7.ToStringWithPitches());
        }

        [Fact]
        public void ToAsciiStringWithPitches_Test()
        {
            Assert.Equal("C#m7 { C# E G# B }", _cSharpMin7.ToAsciiStringWithPitches());
        }

        [Fact]
        public void TryParse_WhenValid_Test()
        {
            var result = Chord.TryParse("C#m7", out var chord);
            Assert.True(result);
            Assert.Equal(_cSharpMin7, chord);
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
