using System.Collections.Generic;

namespace Bravura.Tonality;

public record Mode(string Name, List<Interval> Intervals) : IBaseTonality
{
    public bool EffectivelyEquals(Mode other)
    {
        if (other == null) return false;
        for (var i = 0; i < Intervals.Count; i++)
        {
            if (!Intervals[i].Equals(other.Intervals[i])) return false;
        }
        return true;
    }

    public string DisplayValue(bool onlyAscii = false) => Name;

    public string DisplayValueWithIntervals(bool onlyAscii = false) => $"{DisplayValue(onlyAscii)}: {Intervals.DisplayValue(onlyAscii)}";

    public override string ToString() => DisplayValue(true);
}
