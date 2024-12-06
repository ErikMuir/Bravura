using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Common.Types;

public class Indexable<T>(IEnumerable<T> objects) : IEnumerable<T>
{
    private readonly List<T> _objects = objects?.ToList() ?? [];

    public int Count => _objects.Count;

    public int Index { get; private set; } = 0;

    public T Current => _objects.ElementAt(Index);

    public bool IsLast => Index == _objects.Count - 1;

    public void MoveNext()
    {
        if (IsLast) throw new IndexOutOfRangeException();
        Index++;
    }

    public void Reset()
    {
        Index = 0;
    }

    public void MoveNextOrReset()
    {
        if (IsLast) Reset();
        else MoveNext();
    }

    // public string DisplayValue(bool onlyAscii = false)
    // {
    //     return ((IEnumerable<IBaseTonality>)_objects).DisplayValue(onlyAscii);
    // }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_objects).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_objects).GetEnumerator();
    }
}
