using System.Collections.Generic;
using Xunit;
using static Bravura.Tonality;

namespace Bravura.Tests
{
    public class PitchTests
    {
        public static IEnumerable<object[]> PitchMemberData()
        {
            yield return new object[] { CDoubleFlat, BFlat };
            yield return new object[] { DDoubleFlat, CNatural };
            yield return new object[] { EDoubleFlat, DNatural };
            yield return new object[] { FDoubleFlat, EFlat };
            yield return new object[] { GDoubleFlat, FNatural };
            yield return new object[] { ADoubleFlat, GNatural };
            yield return new object[] { BDoubleFlat, ANatural };
            yield return new object[] { CFlat, BNatural };
            yield return new object[] { DFlat, DFlat };
            yield return new object[] { EFlat, EFlat };
            yield return new object[] { FFlat, ENatural };
            yield return new object[] { GFlat, GFlat };
            yield return new object[] { AFlat, AFlat };
            yield return new object[] { BFlat, BFlat };
            yield return new object[] { CNatural, CNatural };
            yield return new object[] { DNatural, DNatural };
            yield return new object[] { ENatural, ENatural };
            yield return new object[] { FNatural, FNatural };
            yield return new object[] { GNatural, GNatural };
            yield return new object[] { ANatural, ANatural };
            yield return new object[] { BNatural, BNatural };
            yield return new object[] { CSharp, CSharp };
            yield return new object[] { DSharp, DSharp };
            yield return new object[] { ESharp, FNatural };
            yield return new object[] { FSharp, FSharp };
            yield return new object[] { GSharp, GSharp };
            yield return new object[] { ASharp, ASharp };
            yield return new object[] { BSharp, CNatural };
            yield return new object[] { CDoubleSharp, DNatural };
            yield return new object[] { DDoubleSharp, ENatural };
            yield return new object[] { EDoubleSharp, FSharp };
            yield return new object[] { FDoubleSharp, GNatural };
            yield return new object[] { GDoubleSharp, ANatural };
            yield return new object[] { ADoubleSharp, BNatural };
            yield return new object[] { BDoubleSharp, CSharp };
        }                                      

        [Theory]
        [MemberData(nameof(PitchMemberData))]
        public void Pitch_EnharmonicallyEquals_Tests(Pitch pitch, Pitch expectedLogical)
        {
            var actualLogical = pitch.Logical();
            Assert.True(pitch.EnharmonicallyEquals(actualLogical));
        }
    }
}