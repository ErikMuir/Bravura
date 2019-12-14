using Xunit;

namespace Bravura.Common.Tests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void RollingRange_WithLow_WhenWithinRange_ThenReturnsItself()
        {
            var val = 3;
            var low = 1;
            var high = 7;

            var result = val.RollingRange(low, high);

            Assert.Equal(3, result);
        }

        [Fact]
        public void RollingRange_WithLow_WhenAtBottomOfRange_ThenReturnsItself()
        {
            var val = 1;
            var low = 1;
            var high = 7;

            var result = val.RollingRange(low, high);

            Assert.Equal(1, result);
        }

        [Fact]
        public void RollingRange_WithLow_WhenAtTopOfRange_ThenReturnsItself()
        {
            var val = 7;
            var low = 1;
            var high = 7;

            var result = val.RollingRange(low, high);

            Assert.Equal(7, result);
        }

        [Fact]
        public void RollingRange_WithLow_WhenBelowBottomOfRange_ThenRollsOverTheTop()
        {
            var val = -1;
            var low = 1;
            var high = 7;

            var result = val.RollingRange(low, high);

            Assert.Equal(6, result);
        }

        [Fact]
        public void RollingRange_WithLow_WhenAboveTopOfRange_ThenRollsOverTheBottom()
        {
            var val = 9;
            var low = 1;
            var high = 7;

            var result = val.RollingRange(low, high);

            Assert.Equal(2, result);
        }

        [Fact(Skip = "Figure this out")]
        public void RollingRange_WithLow_WhenWayBelowBottomOfRange_ThenRollsOverMultipleTimes()
        {
            var val = -8;
            var low = 1;
            var high = 7;

            var result = val.RollingRange(low, high);

            Assert.Equal(6, result);
        }

        [Fact(Skip = "Figure this out")]
        public void RollingRange_WithLow_WhenWayAboveTopOfRange_ThenRollsOverMultipleTimes()
        {
            var val = 16;
            var low = 1;
            var high = 7;

            var result = val.RollingRange(low, high);

            Assert.Equal(2, result);
        }

        [Fact]
        public void RollingRange_WithoutLow_WhenWithinRange_ThenReturnsItself()
        {
            var val = 3;
            var high = 6;

            var result = val.RollingRange(high);

            Assert.Equal(3, result);
        }

        [Fact]
        public void RollingRange_WithoutLow_WhenZero_ThenReturnsZero()
        {
            var val = 0;
            var high = 6;

            var result = val.RollingRange(high);

            Assert.Equal(0, result);
        }

        [Fact]
        public void RollingRange_WithoutLow_WhenAtTopOfRange_ThenReturnsItself()
        {
            var val = 6;
            var high = 6;

            var result = val.RollingRange(high);

            Assert.Equal(6, result);
        }

        [Fact]
        public void RollingRange_WithoutLow_WhenBelowZero_ThenRollsOverTheTop()
        {
            var val = -2;
            var high = 6;

            var result = val.RollingRange(high);

            Assert.Equal(5, result);
        }

        [Fact]
        public void RollingRange_WithoutLow_WhenAboveTopOfRange_ThenRollsOverTheBottom()
        {
            var val = 8;
            var high = 6;

            var result = val.RollingRange(high);

            Assert.Equal(1, result);
        }

        [Fact(Skip = "Figure this out")]
        public void RollingRange_WithoutLow_WhenWayBelowZero_ThenRollsOverMultipleTimes()
        {
            var val = -9;
            var high = 6;

            var result = val.RollingRange(high);

            Assert.Equal(65, result);
        }

        [Fact(Skip = "Figure this out")]
        public void RollingRange_WithoutLow_WhenWayAboveTopOfRange_ThenRollsOverMultipleTimes()
        {
            var val = 15;
            var high = 6;

            var result = val.RollingRange(high);

            Assert.Equal(1, result);
        }
    }
}