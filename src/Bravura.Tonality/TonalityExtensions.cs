using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public static class TonalityExtensions
{
    public static string JoinToString<T>(this IEnumerable<T> source, string delimiter = " ") where T : ITonality
        => string.Join(delimiter, source.Select(x => x.ToString()));
}
