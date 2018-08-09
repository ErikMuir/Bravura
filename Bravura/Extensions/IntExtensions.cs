namespace Bravura.Extensions
{
    public static class IntExtensions
    {
        public static int RollingRange(this int val, int high)
            => val.RollingRange(0, high);

        public static int RollingRange(this int val, int low, int high)
            => val < low ? high + 1 - (low - val) : val > high ? low - 1 + val - high : val;
    }
}