using System.Collections.Generic;

namespace Bravura.Tonality;

public record ChordQuality(string Symbol, string AsciiSymbol, List<Interval> Intervals) : IBaseTonality
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

    public string DisplayValue(bool onlyAscii = false) => onlyAscii ? AsciiSymbol : Symbol;

    public string DisplayValueWithIntervals(bool onlyAscii = false) => $"{DisplayValue(onlyAscii)} {{ {Intervals.DisplayValue(onlyAscii)} }}";

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
