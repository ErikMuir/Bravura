using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality
{
    public record Mode(string Name, List<Interval> Intervals)
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
        public string ToStringWithIntervals() => $"{ Name } {{ { string.Join(" ", Intervals.Select(i => i.ToString())) } }}";
        public string ToAsciiStringWithIntervals() => $"{ Name } {{ { string.Join(" ", Intervals.Select(i => i.ToAsciiString())) } }}";
    }
}
