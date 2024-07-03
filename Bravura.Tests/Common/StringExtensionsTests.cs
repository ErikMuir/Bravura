using Xunit;

namespace Bravura.Common.Tests;

public class StringExtensionsTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   \n \r \t   ")]
    public void TrimToNull_WhenProvidedNullOrWhiteSpace_ThenReturnsNull(string val)
    {
        Assert.Null(val.TrimToNull());
    }

    [Theory]
    [InlineData("foo bar")]
    [InlineData("     foo bar")]
    [InlineData("foo bar     ")]
    [InlineData("     foo bar     ")]
    public void TrimToNull_WhenProvidedStringWithNonWhiteSpace_ThenReturnsTrimmedString(string val)
    {
        Assert.Equal("foo bar", val.TrimToNull());
    }

    [Fact]
    public void SafeTrim_WhenProvidedNull_ThenReturnsNull()
    {
        string val = null;

        Assert.Null(val.SafeTrim());
    }

    [Fact]
    public void SafeTrim_WhenProvidedEmptyString_ThenReturnsEmptyString()
    {
        var val = "";

        Assert.Equal("", val.SafeTrim());
    }

    [Theory]
    [InlineData("foo bar")]
    [InlineData("     foo bar")]
    [InlineData("foo bar     ")]
    [InlineData("     foo bar     ")]
    public void SafeTrim_WhenProvidedNonNullString_ThenReturnsTrimmedString(string val)
    {
        Assert.Equal("foo bar", val.SafeTrim());
    }
}
