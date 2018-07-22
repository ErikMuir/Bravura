using System.Collections.Generic;
using Xunit;

namespace Bravura.Tests
{
    public class AccidentalTests
    {
        [Theory]
        [MemberData(nameof(AccidentalWorksData))]
        public void Accidental_Works_Test(int value, string name, string defaultSymbol, string actualSymbol, string asciiSymbol)
        {
            var accidental = new Accidental(value, name, defaultSymbol, actualSymbol, asciiSymbol);
            Assert.IsType<Accidental>(accidental);
            Assert.Equal(value, accidental.Value);
            Assert.Equal(name, accidental.Name);
            Assert.Equal(defaultSymbol, accidental.DefaultSymbol);
            Assert.Equal(actualSymbol, accidental.ActualSymbol);
            Assert.Equal(asciiSymbol, accidental.AsciiSymbol);
            Assert.True(accidental.Value >= -2);
            Assert.True(accidental.Value <= 2);
        }

        [Theory]
        [MemberData(nameof(AccidentalThrowsData))]
        public void Accidental_Throws_Test(int value, string name, string defaultSymbol, string actualSymbol, string asciiSymbol)
        {
            var exception = Record.Exception(() => new Accidental(value, name, defaultSymbol, actualSymbol, asciiSymbol));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        public static IEnumerable<object[]> AccidentalWorksData()
        {
            yield return new object[] { -2, "Double Flat", "♭♭", "♭♭", "bb" };
            yield return new object[] { -1, "Flat", "♭", "♭", "b" };
            yield return new object[] { 0, "Natural", "", "♮", "" };
            yield return new object[] { 1, "Sharp", "♯", "♯", "#" };
            yield return new object[] { 2, "Double Sharp", "♯♯", "♯♯", "##" };
        }

        public static IEnumerable<object[]> AccidentalThrowsData()
        {
            yield return new object[] { -3, "", "", "", "" };
            yield return new object[] { 3, "", "", "", "" };
            yield return new object[] { 0, null, "", "", "" };
            yield return new object[] { 0, "", null, "", "" };
            yield return new object[] { 0, "", "", null, "" };
            yield return new object[] { 0, "", "", "", null };
        }
    }
}