namespace Bravura.Common;

public static class IntExtensions
{
    /// <summary>
    /// Returns the value when between 0 and high. Otherwise it will return the difference rolled over the other end of the range.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public static int RollingRange(this int val, int high)
        => val.RollingRange(0, high);

    /// <summary>
    /// Returns the value when between low and high. Otherwise it will return the difference rolled over the other end of the range.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public static int RollingRange(this int val, int low, int high)
    {
        if (low >= high)
            throw new BravuraException($"{nameof(RollingRange)}: {nameof(low)} must be less than {nameof(high)}");

        if (val >= low && val <= high) return val;

        var rangeLength = (high - low) + 1;
        var rolloverAdjustment = val > high ? rangeLength * -1 : rangeLength;

        return (val + rolloverAdjustment).RollingRange(low, high);
    }
}
