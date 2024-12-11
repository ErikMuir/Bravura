using Bravura.Common.Utilities;

namespace Bravura.Common.Tests;

public class StringHelpersTests
{
    #region IsNullOrWhiteSpace

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   \n \r \t   ")]
    public void IsNullOrWhiteSpace_WhenProvidedNullOrWhiteSpace_ThenReturnsTrue(string val)
    {
        Assert.True(val.IsNullOrWhiteSpace());
    }

    [Theory]
    [InlineData("foo bar")]
    [InlineData("     foo bar")]
    [InlineData("foo bar     ")]
    [InlineData("     foo bar     ")]
    public void IsNullOrWhiteSpace_WhenProvidedANonEmptyValue_ThenReturnsFalse(string val)
    {
        Assert.False(val.IsNullOrWhiteSpace());
    }

    #endregion

    #region TrimToNull

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

    #endregion

    #region SafeTrim

    [Fact]
    public void SafeTrim_WhenProvidedNull_ThenReturnsNull()
    {
        string val = null;
        // ReSharper disable once ExpressionIsAlwaysNull
        Assert.Null(val.SafeTrim());
    }

    [Fact]
    public void SafeTrim_WhenProvidedEmptyString_ThenReturnsEmptyString()
    {
        const string val = "";
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

    #endregion
}
