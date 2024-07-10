using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public static class TonalityExtensions
{
    public static string DisplayValue(this IEnumerable<IBaseTonality> source, bool onlyAscii = false) =>
        string.Join(" ", source.Select(item => item.DisplayValue(onlyAscii)));

    public static string ToString(this IEnumerable<IBaseTonality> source) => source.DisplayValue(true);

    public static IEnumerable<T> Append<T>(this IEnumerable<T> source, IEnumerable<T> incoming) where T : IBaseTonality
    {
        var result = new List<T>();
        result.AddRange(source);
        result.AddRange(incoming);
        return result;
    }

    public static IEnumerable<T> AppendDistinct<T>(this IEnumerable<T> source, IEnumerable<T> incoming) where T : IBaseTonality =>
        source.Append(incoming).DistinctBy(item => item.DisplayValue(true));
}
