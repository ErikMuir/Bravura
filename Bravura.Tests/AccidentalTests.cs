using System.Collections.Generic;
using Xunit;

namespace Bravura.Tests
{
    public class AccidentalTests
    {
        [Theory]
        [MemberData(nameof(AccidentalWorksData))]
        public void Accidental_Works_Test(int value, string defaultSymbol, string actualSymbol)
        {
            var accidental = new Accidental(value, defaultSymbol, actualSymbol);
            Assert.IsType<Accidental>(accidental);
            Assert.Equal(value, accidental.Value);
            Assert.Equal(defaultSymbol, accidental.DefaultSymbol);
            Assert.Equal(actualSymbol, accidental.ActualSymbol);
            Assert.True(accidental.Value >= -2);
            Assert.True(accidental.Value <= 2);
        }

        [Theory]
        [MemberData(nameof(AccidentalThrowsData))]
        public void Accidental_Throws_Test(int value, string defaultSymbol, string actualSymbol)
        {
            var exception = Record.Exception(() => new Accidental(value, defaultSymbol, actualSymbol));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        public static IEnumerable<object[]> AccidentalWorksData()
        {
            yield return new object[] { -2, "♭♭", "♭♭" };
            yield return new object[] { -1, "♭", "♭" };
            yield return new object[] { 0, "", "♮" };
            yield return new object[] { 1, "♯", "♯" };
            yield return new object[] { 2, "♯♯", "♯♯" };
        }

        public static IEnumerable<object[]> AccidentalThrowsData()
        {
            yield return new object[] { -3, "", "" };
            yield return new object[] { 3, "", "" };
            yield return new object[] { 0, null, "" };
            yield return new object[] { 0, "", null };
        }
    }
}