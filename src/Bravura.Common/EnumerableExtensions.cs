using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Common;

public static class EnumerableExtensions
{
    public static string ToJoinedString<TSource>(this IEnumerable<TSource> source, string delimiter = " ")
        => string.Join(delimiter, source.Select(x => x.ToString()));

    public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool doApply,
        Func<TSource, bool> predicate)
        => doApply ? source.Where(predicate) : source;
}
