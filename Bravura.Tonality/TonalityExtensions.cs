using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public static class TonalityExtensions
{
    public static string DisplayValue(this IEnumerable<Interval> intervals, bool onlyAscii = false) =>
        string.Join(" ", intervals.Select(i => i.DisplayValue(onlyAscii)));

    public static string DisplayValue(this IEnumerable<Pitch> pitches, bool onlyAscii = false) =>
        string.Join(" ", pitches.Select(p => p.DisplayValue(onlyAscii)));
}
