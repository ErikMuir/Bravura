using Bravura.Common.Utilities;

namespace Bravura.Common.Tests;

public class AsciiConverterTests
{
    [Fact]
    public void ToAscii_WhenProvidedAUnicodeSharpSymbol_ThenConvertsToAsciiSharpSymbol()
    {
        Assert.Equal("#", "♯".ToAscii());
    }

    [Fact]
    public void ToAscii_WhenProvidedAUnicodeFlatSymbol_ThenConvertsToAsciiFlatSymbol()
    {
        Assert.Equal("b", "♭".ToAscii());
    }

    [Fact]
    public void ToAscii_WhenProvidedAUnicodeNaturalSymbol_ThenConvertsToAsciiUnderscore()
    {
        Assert.Equal("_", "♮".ToAscii());
    }

    [Fact]
    public void FromAscii_WhenProvidedAnAsciiSharpSymbol_ThenConvertsToUnicodeSharpSymbol()
    {
        Assert.Equal("♯", "#".FromAscii());
    }

    [Fact]
    public void FromAscii_WhenProvidedAnAsciiFlatSymbol_ThenConvertsToUnicodeFlatSymbol()
    {
        Assert.Equal("♭", "b".FromAscii());
    }

    [Fact]
    public void FromAscii_WhenProvidedAnAsciiUnderscore_ThenConvertsToUnicodeNaturalSymbol()
    {
        Assert.Equal("♮", "_".FromAscii());
    }
}
