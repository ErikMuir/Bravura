using Bravura.Common.Exceptions;
using Bravura.Common.Extensions;
using Xunit;

namespace Bravura.Tests.Common;

public class IntExtensionsTests
{
    private readonly int _low = 1;
    private readonly int _high = 3;

    [Fact]
    public void RollingRange_WhenLowIsHigherThanHigh_ThenThrows()
    {
        var val = 1;

        var exception = Record.Exception(() => val.RollingRange(_high, _low));

        Assert.NotNull(exception);
        Assert.IsType<BravuraException>(exception);
    }

    [Fact]
    public void RollingRange_WhenLowIsSameAsHigh_ThenThrows()
    {
        var val = 1;

        var exception = Record.Exception(() => val.RollingRange(_low, _low));

        Assert.NotNull(exception);
        Assert.IsType<BravuraException>(exception);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void RollingRange_WhenValIsWithinRange_ThenReturnsItself(int val)
    {
        var actualResult = val.RollingRange(_low, _high);

        Assert.Equal(val, actualResult);
    }

    [Theory]
    [InlineData(0, 3)]
    [InlineData(-1, 2)]
    [InlineData(-2, 1)]
    public void RollingRange_WhenValIsBelowRange_ThenRollsOverTheTop(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(_low, _high);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(4, 1)]
    [InlineData(5, 2)]
    [InlineData(6, 3)]
    public void RollingRange_WhenValIsAboveRange_ThenRollsOverTheBottom(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(_low, _high);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(-3, 3)]
    [InlineData(-7, 2)]
    [InlineData(-11, 1)]
    public void RollingRange_WhenValIsFarBelowRange_ThenRollsOverTheTopMultipleTimes(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(_low, _high);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(7, 1)]
    [InlineData(11, 2)]
    [InlineData(15, 3)]
    public void RollingRange_WhenValIsFarAboveRange_ThenRollsOverTheBottom(int val, int expectedResult)
    {
        var actualResult = val.RollingRange(_low, _high);

        Assert.Equal(expectedResult, actualResult);
    }
}
