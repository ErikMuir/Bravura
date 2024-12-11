using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public static class TonalityExtensions
{
    public static string ToJoinedString<T>(this IEnumerable<T> source, string delimiter = " ")
        => string.Join(delimiter, source.Select(x => x.ToString()));
}
