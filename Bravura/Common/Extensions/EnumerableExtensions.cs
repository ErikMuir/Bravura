using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Common.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool doApply, Func<T, bool> predicate)
        where T : new()
        => doApply ? source.Where(predicate) : source;
}
