using System.Collections.Generic;
using Xunit;

namespace Bravura.Tonality.Tests
{
    public class PitchTests
    {
        public static IEnumerable<object[]> PitchMemberData()
        {
            yield return new object[] { Pitches.CDoubleFlat, Pitches.BFlat };
            yield return new object[] { Pitches.DDoubleFlat, Pitches.CNatural };
            yield return new object[] { Pitches.EDoubleFlat, Pitches.DNatural };
            yield return new object[] { Pitches.FDoubleFlat, Pitches.EFlat };
            yield return new object[] { Pitches.GDoubleFlat, Pitches.FNatural };
            yield return new object[] { Pitches.ADoubleFlat, Pitches.GNatural };
            yield return new object[] { Pitches.BDoubleFlat, Pitches.ANatural };
            yield return new object[] { Pitches.CFlat, Pitches.BNatural };
            yield return new object[] { Pitches.DFlat, Pitches.DFlat };
            yield return new object[] { Pitches.EFlat, Pitches.EFlat };
            yield return new object[] { Pitches.FFlat, Pitches.ENatural };
            yield return new object[] { Pitches.GFlat, Pitches.GFlat };
            yield return new object[] { Pitches.AFlat, Pitches.AFlat };
            yield return new object[] { Pitches.BFlat, Pitches.BFlat };
            yield return new object[] { Pitches.CNatural, Pitches.CNatural };
            yield return new object[] { Pitches.DNatural, Pitches.DNatural };
            yield return new object[] { Pitches.ENatural, Pitches.ENatural };
            yield return new object[] { Pitches.FNatural, Pitches.FNatural };
            yield return new object[] { Pitches.GNatural, Pitches.GNatural };
            yield return new object[] { Pitches.ANatural, Pitches.ANatural };
            yield return new object[] { Pitches.BNatural, Pitches.BNatural };
            yield return new object[] { Pitches.CSharp, Pitches.CSharp };
            yield return new object[] { Pitches.DSharp, Pitches.DSharp };
            yield return new object[] { Pitches.ESharp, Pitches.FNatural };
            yield return new object[] { Pitches.FSharp, Pitches.FSharp };
            yield return new object[] { Pitches.GSharp, Pitches.GSharp };
            yield return new object[] { Pitches.ASharp, Pitches.ASharp };
            yield return new object[] { Pitches.BSharp, Pitches.CNatural };
            yield return new object[] { Pitches.CDoubleSharp, Pitches.DNatural };
            yield return new object[] { Pitches.DDoubleSharp, Pitches.ENatural };
            yield return new object[] { Pitches.EDoubleSharp, Pitches.FSharp };
            yield return new object[] { Pitches.FDoubleSharp, Pitches.GNatural };
            yield return new object[] { Pitches.GDoubleSharp, Pitches.ANatural };
            yield return new object[] { Pitches.ADoubleSharp, Pitches.BNatural };
            yield return new object[] { Pitches.BDoubleSharp, Pitches.CSharp };
        }

        [Theory]
        [MemberData(nameof(PitchMemberData))]
        public void Pitch_EnharmonicallyEquals_Tests(Pitch pitch, Pitch expectedLogical)
        {
            var actualLogical = pitch.Logical();
            Assert.True(pitch.EnharmonicallyEquals(actualLogical));
            Assert.True(pitch.EnharmonicallyEquals(expectedLogical));
            Assert.True(expectedLogical.EnharmonicallyEquals(actualLogical));
        }
    }
}