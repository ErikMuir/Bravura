using System.Collections.Generic;
using Xunit;

namespace Bravura.Tests
{
    public class PitchTests
    {
        public static IEnumerable<object[]> PitchMemberData()
        {
            yield return new object[] { Theory.CDoubleFlat, Theory.BFlat, Theory.BFlat, Theory.CDoubleFlat };
            yield return new object[] { Theory.DDoubleFlat, Theory.CNatural, Theory.CNatural, Theory.DDoubleFlat };
            yield return new object[] { Theory.EDoubleFlat, Theory.DNatural, Theory.DNatural, Theory.EDoubleFlat };
            yield return new object[] { Theory.FDoubleFlat, Theory.EFlat, Theory.EFlat, Theory.FDoubleFlat };
            yield return new object[] { Theory.GDoubleFlat, Theory.FNatural, Theory.FNatural, Theory.GDoubleFlat };
            yield return new object[] { Theory.ADoubleFlat, Theory.GNatural, Theory.GNatural, Theory.ADoubleFlat };
            yield return new object[] { Theory.BDoubleFlat, Theory.ANatural, Theory.ANatural, Theory.BDoubleFlat };
            yield return new object[] { Theory.CFlat, Theory.BNatural, Theory.BNatural, Theory.CFlat };
            yield return new object[] { Theory.DFlat, Theory.DFlat, Theory.CSharp, Theory.DFlat };
            yield return new object[] { Theory.EFlat, Theory.EFlat, Theory.DSharp, Theory.EFlat };
            yield return new object[] { Theory.FFlat, Theory.ENatural, Theory.ENatural, Theory.FFlat };
            yield return new object[] { Theory.GFlat, Theory.GFlat, Theory.FSharp, Theory.GFlat };
            yield return new object[] { Theory.AFlat, Theory.AFlat, Theory.GSharp, Theory.AFlat };
            yield return new object[] { Theory.BFlat, Theory.BFlat, Theory.ASharp, Theory.BFlat };
            yield return new object[] { Theory.CNatural, Theory.CNatural, Theory.BSharp, Theory.CNatural };
            yield return new object[] { Theory.DNatural, Theory.DNatural, Theory.DNatural, Theory.DNatural };
            yield return new object[] { Theory.ENatural, Theory.ENatural, Theory.ENatural, Theory.FFlat };
            yield return new object[] { Theory.FNatural, Theory.FNatural, Theory.ESharp, Theory.FNatural };
            yield return new object[] { Theory.GNatural, Theory.GNatural, Theory.GNatural, Theory.GNatural };
            yield return new object[] { Theory.ANatural, Theory.ANatural, Theory.ANatural, Theory.ANatural };
            yield return new object[] { Theory.BNatural, Theory.BNatural, Theory.BNatural, Theory.CFlat };
            yield return new object[] { Theory.CSharp, Theory.CSharp, Theory.CSharp, Theory.DFlat };
            yield return new object[] { Theory.DSharp, Theory.DSharp, Theory.DSharp, Theory.EFlat };
            yield return new object[] { Theory.ESharp, Theory.FNatural, Theory.ESharp, Theory.FNatural };
            yield return new object[] { Theory.FSharp, Theory.FSharp, Theory.FSharp, Theory.GFlat };
            yield return new object[] { Theory.GSharp, Theory.GSharp, Theory.GSharp, Theory.AFlat };
            yield return new object[] { Theory.ASharp, Theory.ASharp, Theory.ASharp, Theory.BFlat };
            yield return new object[] { Theory.BSharp, Theory.CNatural, Theory.BSharp, Theory.CNatural };
            yield return new object[] { Theory.CDoubleSharp, Theory.DNatural, Theory.CDoubleSharp, Theory.DNatural };
            yield return new object[] { Theory.DDoubleSharp, Theory.ENatural, Theory.DDoubleSharp, Theory.ENatural };
            yield return new object[] { Theory.EDoubleSharp, Theory.FSharp, Theory.EDoubleSharp, Theory.FSharp };
            yield return new object[] { Theory.FDoubleSharp, Theory.GNatural, Theory.FDoubleSharp, Theory.GNatural };
            yield return new object[] { Theory.GDoubleSharp, Theory.ANatural, Theory.GDoubleSharp, Theory.ANatural };
            yield return new object[] { Theory.ADoubleSharp, Theory.BNatural, Theory.ADoubleSharp, Theory.BNatural };
            yield return new object[] { Theory.BDoubleSharp, Theory.CSharp, Theory.BDoubleSharp, Theory.CSharp };
        }                                      

        [Theory]
        [MemberData(nameof(PitchMemberData))]
        public void Pitch_Tests(Pitch pitch, Pitch expectedLogical, Pitch expectedLower, Pitch expectedHigher)
        {
            var actualLogical = pitch.Logical();
            var actualLower = pitch.Lower();
            var actualHigher = pitch.Higher();
            Assert.Equal(expectedLogical, actualLogical);
            Assert.Equal(expectedLower, actualLower);
            Assert.Equal(expectedHigher, actualHigher);
            Assert.True(pitch.EnharmonicallyEquals(actualLogical));
            Assert.True(pitch.EnharmonicallyEquals(actualLower));
            Assert.True(pitch.EnharmonicallyEquals(actualHigher));
        }
    }
}