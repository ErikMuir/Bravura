using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality;

public record ChordQuality(string Symbol, List<Interval> Intervals) : ITonality
{
    public bool IsMajor => Contains(Tonality.Intervals.MajorThird) && Contains(Tonality.Intervals.PerfectFifth);

    public bool IsMinor => Contains(Tonality.Intervals.MinorThird) && Contains(Tonality.Intervals.PerfectFifth);

    public bool IsDiminished => Contains(Tonality.Intervals.MinorThird) && Contains(Tonality.Intervals.DiminishedFifth);

    public bool IsAugmented => Contains(Tonality.Intervals.MajorThird) && Contains(Tonality.Intervals.AugmentedFifth);

    public bool IsDominant => Contains(Tonality.Intervals.MajorThird) && Contains(Tonality.Intervals.MinorSeventh);

    public bool IsAltered =>
        Contains(Tonality.Intervals.MajorThird) &&
        Contains(Tonality.Intervals.MinorSeventh) &&
        (
            Contains(Tonality.Intervals.MinorSecond) ||
            Contains(Tonality.Intervals.AugmentedSecond) ||
            Contains(Tonality.Intervals.DiminishedFifth) ||
            Contains(Tonality.Intervals.AugmentedFifth)
        );

    public bool IsSuspended =>
        !Contains(Tonality.Intervals.MajorThird) &&
        !Contains(Tonality.Intervals.MinorThird) &&
        (
            Contains(Tonality.Intervals.MajorSecond) ||
            Contains(Tonality.Intervals.PerfectFourth)
        );

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

    public bool Contains(Interval interval) => Intervals.Any(i => i.EffectivelyEquals(interval));

    public static bool TryParse(string val, out ChordQuality chordQuality)
    {
        chordQuality = null;
        var trimmedVal = val.SafeTrim();
        chordQuality = ChordQualities.AllChordQualities.FirstOrDefault(quality =>
            trimmedVal == quality.Symbol || trimmedVal == quality.ToString().ToAscii());
        return chordQuality != null;
    }

    public override string ToString() => Symbol;
}
