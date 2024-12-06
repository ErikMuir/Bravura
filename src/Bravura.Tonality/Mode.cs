using System.Collections.Generic;

namespace Bravura.Tonality;

public record Mode(string Name, List<Interval> Intervals) : ITonality
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

    public override string ToString() => Name;
}
