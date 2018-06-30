using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public struct ChordQuality
    {
        public string Symbol { get; }
        public List<Interval> Intervals { get; }

        public ChordQuality(string symbol, List<Interval> intervals)
        {
            Symbol = symbol ?? throw new BravuraException("A Chord Quality's Symbol cannot be null.");
            Intervals = intervals;
        }

        public static bool operator ==(ChordQuality a, ChordQuality b)
        {
            if (a.Intervals.Count != b.Intervals.Count)
                return false;

            return !a.Intervals.Where((t, i) => t.Semitones != b.Intervals[i].Semitones).Any();
        }

        public static bool operator !=(ChordQuality a, ChordQuality b)
        {
            return !(a == b);
        }
    }
}