using System;
using System.Linq;

namespace Bravura.Tonality;

public record Interval(short Semitones, Accidental Accidental, short Degree, string Name, string Symbol) : IBaseTonality
{
    public bool EffectivelyEquals(Interval other) => Semitones == other?.Semitones;
    public string DisplayValue(bool onlyAscii = false) => $"{Accidental.DisplayValue(onlyAscii)}{Degree}";
    public static bool TryParse(string val, out Interval interval)
    {
        interval = Intervals.AllIntervals.FirstOrDefault(i => i.Symbol.Equals(val, StringComparison.CurrentCultureIgnoreCase));
        return interval is not null;
    }
}
