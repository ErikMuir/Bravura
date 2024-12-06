using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Common.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Append<T>(this IEnumerable<T> source, IEnumerable<T> incoming)
    {
        var result = new List<T>();
        result.AddRange(source);
        result.AddRange(incoming);
        return result;
    }

    public static IEnumerable<T> AppendDistinct<T>(this IEnumerable<T> source, IEnumerable<T> incoming)
        => source.Append(incoming).DistinctBy(item => item.ToString());

    public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool doApply, Func<T, bool> predicate)
        where T : new()
        => doApply ? source.Where(predicate) : source;
}
