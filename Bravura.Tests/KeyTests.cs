using System.Collections.Generic;
using Xunit;

namespace Bravura.Tests
{
    public class KeyTests
    {
        #region -- Member Data --

        public static IEnumerable<object[]> KeyWorksData()
        {
            yield return new object[] { Pitches.ANatural, KeyMode.Major };
            yield return new object[] { Pitches.BNatural, KeyMode.Major };
            yield return new object[] { Pitches.CNatural, KeyMode.Major };
            yield return new object[] { Pitches.DNatural, KeyMode.Major };
            yield return new object[] { Pitches.ENatural, KeyMode.Major };
            yield return new object[] { Pitches.FNatural, KeyMode.Major };
            yield return new object[] { Pitches.GNatural, KeyMode.Major };
            yield return new object[] { Pitches.ANatural, KeyMode.Minor };
            yield return new object[] { Pitches.BNatural, KeyMode.Minor };
            yield return new object[] { Pitches.CNatural, KeyMode.Minor };
            yield return new object[] { Pitches.DNatural, KeyMode.Minor };
            yield return new object[] { Pitches.ENatural, KeyMode.Minor };
            yield return new object[] { Pitches.FNatural, KeyMode.Minor };
            yield return new object[] { Pitches.GNatural, KeyMode.Minor };
            yield return new object[] { Pitches.AFlat, KeyMode.Major };
            yield return new object[] { Pitches.BFlat, KeyMode.Major };
            yield return new object[] { Pitches.CFlat, KeyMode.Major };
            yield return new object[] { Pitches.DFlat, KeyMode.Major };
            yield return new object[] { Pitches.EFlat, KeyMode.Major };
            yield return new object[] { Pitches.GFlat, KeyMode.Major };
            yield return new object[] { Pitches.AFlat, KeyMode.Minor };
            yield return new object[] { Pitches.BFlat, KeyMode.Minor };
            yield return new object[] { Pitches.EFlat, KeyMode.Minor };
            yield return new object[] { Pitches.CSharp, KeyMode.Major };
            yield return new object[] { Pitches.FSharp, KeyMode.Major };
            yield return new object[] { Pitches.ASharp, KeyMode.Minor };
            yield return new object[] { Pitches.CSharp, KeyMode.Minor };
            yield return new object[] { Pitches.DSharp, KeyMode.Minor };
            yield return new object[] { Pitches.FSharp, KeyMode.Minor };
            yield return new object[] { Pitches.GSharp, KeyMode.Minor };
        }

        public static IEnumerable<object[]> KeyThrowsData()
        {
            yield return new object[] { Pitches.ASharp, KeyMode.Major };
            yield return new object[] { Pitches.BSharp, KeyMode.Major };
            yield return new object[] { Pitches.BSharp, KeyMode.Minor };
            yield return new object[] { Pitches.DSharp, KeyMode.Major };
            yield return new object[] { Pitches.ESharp, KeyMode.Major };
            yield return new object[] { Pitches.ESharp, KeyMode.Minor };
            yield return new object[] { Pitches.GSharp, KeyMode.Major };
            yield return new object[] { Pitches.CFlat, KeyMode.Minor };
            yield return new object[] { Pitches.DFlat, KeyMode.Minor };
            yield return new object[] { Pitches.FFlat, KeyMode.Major };
            yield return new object[] { Pitches.FFlat, KeyMode.Minor };
            yield return new object[] { Pitches.GFlat, KeyMode.Minor };
            yield return new object[] { Pitches.ADoubleFlat, KeyMode.Major };
            yield return new object[] { Pitches.BDoubleFlat, KeyMode.Major };
            yield return new object[] { Pitches.CDoubleFlat, KeyMode.Major };
            yield return new object[] { Pitches.DDoubleFlat, KeyMode.Major };
            yield return new object[] { Pitches.EDoubleFlat, KeyMode.Major };
            yield return new object[] { Pitches.FDoubleFlat, KeyMode.Major };
            yield return new object[] { Pitches.GDoubleFlat, KeyMode.Major };
            yield return new object[] { Pitches.ADoubleFlat, KeyMode.Minor };
            yield return new object[] { Pitches.BDoubleFlat, KeyMode.Minor };
            yield return new object[] { Pitches.CDoubleFlat, KeyMode.Minor };
            yield return new object[] { Pitches.DDoubleFlat, KeyMode.Minor };
            yield return new object[] { Pitches.EDoubleFlat, KeyMode.Minor };
            yield return new object[] { Pitches.FDoubleFlat, KeyMode.Minor };
            yield return new object[] { Pitches.GDoubleFlat, KeyMode.Minor };
            yield return new object[] { Pitches.ADoubleSharp, KeyMode.Major };
            yield return new object[] { Pitches.BDoubleSharp, KeyMode.Major };
            yield return new object[] { Pitches.CDoubleSharp, KeyMode.Major };
            yield return new object[] { Pitches.DDoubleSharp, KeyMode.Major };
            yield return new object[] { Pitches.EDoubleSharp, KeyMode.Major };
            yield return new object[] { Pitches.FDoubleSharp, KeyMode.Major };
            yield return new object[] { Pitches.GDoubleSharp, KeyMode.Major };
            yield return new object[] { Pitches.ADoubleSharp, KeyMode.Minor };
            yield return new object[] { Pitches.BDoubleSharp, KeyMode.Minor };
            yield return new object[] { Pitches.CDoubleSharp, KeyMode.Minor };
            yield return new object[] { Pitches.DDoubleSharp, KeyMode.Minor };
            yield return new object[] { Pitches.EDoubleSharp, KeyMode.Minor };
            yield return new object[] { Pitches.FDoubleSharp, KeyMode.Minor };
            yield return new object[] { Pitches.GDoubleSharp, KeyMode.Minor };
        }

        #endregion 

        [Theory]
        [MemberData(nameof(KeyWorksData))]
        public void Key_Works_Test(Pitch root, KeyMode keyMode)
        {
            var key = new Key(root, keyMode);
            Assert.IsType<Key>(key);
            Assert.True(root == key.Root);
            Assert.Equal(keyMode, key.Mode);
        }

        [Theory]
        [MemberData(nameof(KeyThrowsData))]
        public void Key_Throws_Test(Pitch root, KeyMode keyMode)
        {
            var exception = Record.Exception(() => new Key(root, keyMode));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }
    }
}
