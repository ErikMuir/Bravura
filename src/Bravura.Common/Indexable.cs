using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Common;

public class Indexable<T>
{
    public Indexable(IEnumerable<T> objects, int startingIndex = 0)
    {
        Objects = objects.ToList();
        Index = startingIndex;
    }

    public List<T> Objects { get; }

    private int _index;
    public int Index
    {
        get => _index;
        private set
        {
            if (value < 0 || value >= Count)
                throw new IndexOutOfRangeException();
            _index = value;
        }
    }

    public int Count => Objects.Count;

    public T Current => Objects.ElementAt(Index);

    public void MoveNext()
    {
        Index++;
    }

    public void Reset()
    {
        Index = 0;
    }

    public void MoveNextOrReset()
    {
        if (Index == Count - 1) Reset();
        else MoveNext();
    }

    public void JumpTo(int index)
    {
        Index = index;
    }
}
