using Xunit;

namespace Bravura.Tests
{
    public class PitchTests
    {
        [Fact]
        public void Pitch_Equality_Test()
        {
            var fakeNoteName = new NoteName(1, 0, "Cee", true, false);
            var fakeAccidental = new Accidental(1, "", "", "", "");
            var fakePitch = new Pitch(fakeNoteName, fakeAccidental);
            Assert.True(fakePitch == Pitches.CSharp);
            Assert.True(fakePitch.Equals(Pitches.CSharp));
            Assert.Equal(fakePitch.GetHashCode(), Pitches.CSharp.GetHashCode());
        }
    }
}