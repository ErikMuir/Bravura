using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality
{
    public record ChordQuality(string Symbol, string AsciiSymbol, List<Interval> Intervals)
    {
        public bool EffectivelyEquals(ChordQuality other)
        {
            if (other == null) return false;
            if (Intervals.Count != other.Intervals.Count) return false;
            for (var i = 0; i < Intervals.Count; i++)
            {
                if (!Intervals[i].Equals(other.Intervals[i])) return false;
            }
            return true;
        }

        public override string ToString() => Symbol;
        public string ToAsciiString() => AsciiSymbol;
        public string ToStringWithIntervals() => $"{ Symbol } {{ { string.Join(" ", Intervals.Select(i => i.ToString())) } }}";
        public string ToAsciiStringWithIntervals() => $"{ AsciiSymbol } {{ { string.Join(" ", Intervals.Select(i => i.ToAsciiString())) } }}";

        public static bool TryParse(string val, out ChordQuality chordQuality)
        {
            chordQuality = null;
            if (val == null) return false;
            var trimmedVal = val.Trim();
            foreach (var quality in ChordQualities.AllChordQualities)
            {
                if (quality.Symbol != trimmedVal && quality.AsciiSymbol != trimmedVal) continue;
                chordQuality = quality;
                return true;
            }
            return false;
        }
    }
}
