using Bravura.Common.Exceptions;
using Bravura.Common.Utilities;

namespace Bravura.Common.Tests;

public class RollingRangeTests
{
    [Fact]
    public void RollingRange_WhenLowIsHigherThanHigh_ThenThrows()
    {
        var exception = Record.Exception(() => 1.RollingRange(3, 1));

        Assert.NotNull(exception);
        Assert.IsType<BravuraException>(exception);
    }

    [Fact]
    public void RollingRange_WhenLowIsSameAsHigh_ThenThrows()
    {
        var exception = Record.Exception(() => 1.RollingRange(1, 1));

        Assert.NotNull(exception);
        Assert.IsType<BravuraException>(exception);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void RollingRange_WhenValIsWithinRange_ThenReturnsItself(int val)
    {
        var actualResult = val.RollingRange(1, 3);

        Assert.Equal(val, actualResult);
    }

    [Theory]
    [InlineData(0, 3)]
    [InlineData(-1, 2)]
    [InlineData(-2, 1)]
    public void RollingRange_WhenValIsBelowRange_ThenRollsOverTheTop(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(1, 3);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(4, 1)]
    [InlineData(5, 2)]
    [InlineData(6, 3)]
    public void RollingRange_WhenValIsAboveRange_ThenRollsOverTheBottom(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(1, 3);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(-3, 3)]
    [InlineData(-7, 2)]
    [InlineData(-11, 1)]
    public void RollingRange_WhenValIsFarBelowRange_ThenRollsOverTheTopMultipleTimes(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(1, 3);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(7, 1)]
    [InlineData(11, 2)]
    [InlineData(15, 3)]
    public void RollingRange_WhenValIsFarAboveRange_ThenRollsOverTheBottom(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(1, 3);

        Assert.Equal(expectedResult, actualResult);
    }
}
