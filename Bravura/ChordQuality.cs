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
            Symbol = symbol ?? throw new BravuraException("A Chord Quality's Symbol cannot be null.");
            Intervals = intervals ?? throw new BravuraException("A Chord Quality's Intervals cannot be null");
            if (intervals.Count < 2)
                throw new BravuraException("A Chord Quality must have at least 2 Intervals");
        }

        public static bool operator ==(ChordQuality a, ChordQuality b)
        {
            return EqualityComparer<List<Interval>>.Default.Equals(a.Intervals, b.Intervals);

            //if (a.Intervals.Count != b.Intervals.Count)
            //    return false;

            //return !a.Intervals.Where((t, i) => t.Semitones != b.Intervals[i].Semitones).Any();
        }

        public static bool operator !=(ChordQuality a, ChordQuality b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ChordQuality))
            {
                return false;
            }

            var quality = (ChordQuality)obj;
            return EqualityComparer<List<Interval>>.Default.Equals(Intervals, quality.Intervals);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Intervals);
        }
    }
}