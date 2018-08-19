using System.Collections.Generic;
using Xunit;
using static Bravura.Theory;

namespace Bravura.Tests
{
    public class PitchTests
    {
        public static IEnumerable<object[]> PitchMemberData()
        {
            yield return new object[] { CDoubleFlat, BFlat, BFlat, CDoubleFlat };
            yield return new object[] { DDoubleFlat, CNatural, CNatural, DDoubleFlat };
            yield return new object[] { EDoubleFlat, DNatural, DNatural, EDoubleFlat };
            yield return new object[] { FDoubleFlat, EFlat, EFlat, FDoubleFlat };
            yield return new object[] { GDoubleFlat, FNatural, FNatural, GDoubleFlat };
            yield return new object[] { ADoubleFlat, GNatural, GNatural, ADoubleFlat };
            yield return new object[] { BDoubleFlat, ANatural, ANatural, BDoubleFlat };
            yield return new object[] { CFlat, BNatural, BNatural, CFlat };
            yield return new object[] { DFlat, DFlat, CSharp, DFlat };
            yield return new object[] { EFlat, EFlat, DSharp, EFlat };
            yield return new object[] { FFlat, ENatural, ENatural, FFlat };
            yield return new object[] { GFlat, GFlat, FSharp, GFlat };
            yield return new object[] { AFlat, AFlat, GSharp, AFlat };
            yield return new object[] { BFlat, BFlat, ASharp, BFlat };
            yield return new object[] { CNatural, CNatural, BSharp, CNatural };
            yield return new object[] { DNatural, DNatural, DNatural, DNatural };
            yield return new object[] { ENatural, ENatural, ENatural, FFlat };
            yield return new object[] { FNatural, FNatural, ESharp, FNatural };
            yield return new object[] { GNatural, GNatural, GNatural, GNatural };
            yield return new object[] { ANatural, ANatural, ANatural, ANatural };
            yield return new object[] { BNatural, BNatural, BNatural, CFlat };
            yield return new object[] { CSharp, CSharp, CSharp, DFlat };
            yield return new object[] { DSharp, DSharp, DSharp, EFlat };
            yield return new object[] { ESharp, FNatural, ESharp, FNatural };
            yield return new object[] { FSharp, FSharp, FSharp, GFlat };
            yield return new object[] { GSharp, GSharp, GSharp, AFlat };
            yield return new object[] { ASharp, ASharp, ASharp, BFlat };
            yield return new object[] { BSharp, CNatural, BSharp, CNatural };
            yield return new object[] { CDoubleSharp, DNatural, CDoubleSharp, DNatural };
            yield return new object[] { DDoubleSharp, ENatural, DDoubleSharp, ENatural };
            yield return new object[] { EDoubleSharp, FSharp, EDoubleSharp, FSharp };
            yield return new object[] { FDoubleSharp, GNatural, FDoubleSharp, GNatural };
            yield return new object[] { GDoubleSharp, ANatural, GDoubleSharp, ANatural };
            yield return new object[] { ADoubleSharp, BNatural, ADoubleSharp, BNatural };
            yield return new object[] { BDoubleSharp, CSharp, BDoubleSharp, CSharp };
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