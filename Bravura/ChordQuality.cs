using System;
using System.Collections.Generic;

namespace Bravura
{
    public struct ChordQuality
    {
        public string Symbol { get; }
        public List<Interval> Intervals { get; }

        public ChordQuality(string symbol, List<Interval> intervals)
        {
            Symbol = symbol ?? throw new NullReferenceException("Symbol cannot be null.");
            Intervals = intervals;
        }
    }
}