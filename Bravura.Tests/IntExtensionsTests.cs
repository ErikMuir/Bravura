using Bravura.Extensions;
using Xunit;

namespace Bravura.Tests
{
    public class IntExtensionsTests
    {
        [Theory]
        [InlineData(3, 1, 7, 3)]
        [InlineData(1, 1, 7, 1)]
        [InlineData(0, 1, 7, 7)]
        [InlineData(-1, 1, 7, 6)]
        [InlineData(7, 1, 7, 7)]
        [InlineData(8, 1, 7, 1)]
        [InlineData(9, 1, 7, 2)]
        public void RollingRange_WithLow_Tests(int val, int low, int high, int expectedResult)
        {
            var actualResult = val.RollingRange(low, high);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, 6, 3)]
        [InlineData(0, 6, 0)]
        [InlineData(-1, 6, 6)]
        [InlineData(-2, 6, 5)]
        [InlineData(6, 6, 6)]
        [InlineData(7, 6, 0)]
        [InlineData(8, 6, 1)]
        public void RollingRange_WithoutLow_Tests(int val, int high, int expectedResult)
        {
            var actualResult = val.RollingRange(high);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}