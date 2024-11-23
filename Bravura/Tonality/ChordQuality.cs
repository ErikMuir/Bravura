using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public record ChordQuality(string Symbol, string AsciiSymbol, List<Interval> Intervals) : IBaseTonality
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

    public string DisplayValue(bool onlyAscii = false) => onlyAscii ? AsciiSymbol : Symbol;

    public string DisplayValueWithIntervals(bool onlyAscii = false) => $"{DisplayValue(onlyAscii)}: {Intervals.DisplayValue(onlyAscii)}";

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

    public override string ToString() => DisplayValue(true);
}
