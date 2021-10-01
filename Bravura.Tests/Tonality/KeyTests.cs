using Xunit;

namespace Bravura.Tonality.Tests
{
    public class KeyTests
    {
        [Fact]
        public void Scale_Test()
        {
            var cMajorScale = new Scale(Pitches.CNatural, Modes.Major);
            Assert.Equal(cMajorScale, Keys.CMajor.Scale);

            var aMinorScale = new Scale(Pitches.ANatural, Modes.NaturalMinor);
            Assert.Equal(aMinorScale, Keys.AMinor.Scale);
        }

        [Fact]
        public void KeySignature_Test()
        {
            var cMajorKeySignature = Keys.CMajor.KeySignature;
            Assert.Empty(cMajorKeySignature);

            var aMinorKeySignature = Keys.AMinor.KeySignature;
            Assert.Empty(aMinorKeySignature);

            var eMajorKeySignature = Keys.EMajor.KeySignature;
            Assert.Equal(4, eMajorKeySignature.Count);
            Assert.Equal(Pitches.FSharp, eMajorKeySignature[0]);
            Assert.Equal(Pitches.CSharp, eMajorKeySignature[1]);
            Assert.Equal(Pitches.GSharp, eMajorKeySignature[2]);
            Assert.Equal(Pitches.DSharp, eMajorKeySignature[3]);

            var fMinorKeySignature = Keys.FMinor.KeySignature;
            Assert.Equal(4, fMinorKeySignature.Count);
            Assert.Equal(Pitches.BFlat, fMinorKeySignature[0]);
            Assert.Equal(Pitches.EFlat, fMinorKeySignature[1]);
            Assert.Equal(Pitches.AFlat, fMinorKeySignature[2]);
            Assert.Equal(Pitches.DFlat, fMinorKeySignature[3]);
        }

        [Fact]
        public void Relative_Test()
        {
            Assert.Equal(Keys.AMinor, Keys.CMajor.Relative);
            Assert.Equal(Keys.CMajor, Keys.AMinor.Relative);
        }
    }
}
