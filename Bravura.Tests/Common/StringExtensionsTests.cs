using Xunit;

namespace Bravura.Common.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   \n \r \t   ")]
        public void TrimToNull_WhenProvidedNullOrWhiteSpace_ReturnsNull_Test(string val)
        {
            Assert.Null(val.TrimToNull());

            Assert.Equal("foo bar", "foo bar".TrimToNull());
            Assert.Equal("foo bar", "   foo bar".TrimToNull());
            Assert.Equal("foo bar", "foo bar   ".TrimToNull());
        }

        [Theory]
        [InlineData("foo bar")]
        [InlineData("     foo bar")]
        [InlineData("foo bar     ")]
        [InlineData("     foo bar     ")]
        public void TrimToNull_WhenProvidedStringWithNonWhiteSpace_ReturnsTrimmedString_Test(string val)
        {
            var result = val.TrimToNull();

            Assert.NotNull(result);
            Assert.Equal("foo bar", result);
        }
    }
}
