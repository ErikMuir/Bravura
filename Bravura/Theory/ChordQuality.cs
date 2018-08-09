using System.Collections.Generic;
using System.Linq;
using Bravura.Exceptions;

namespace Bravura.Theory
{
    public struct ChordQuality
    {
        public string Symbol { get; }
        public string AsciiSymbol { get; }
        public List<Interval> Intervals { get; }

        public ChordQuality(string symbol, string asciiSymbol, List<Interval> intervals)
        {
            Symbol = symbol ?? throw new BravuraException("A Chord Quality's Symbol cannot be null.");
            AsciiSymbol = asciiSymbol ?? throw new BravuraException("A Chord Quality's Ascii Symbol cannot be null.");
            Intervals = intervals ?? throw new BravuraException("A Chord Quality's Intervals cannot be null");
            if (intervals.Count < 2)
                throw new BravuraException("A Chord Quality must have at least 2 Intervals");
            if (intervals[0] != Bravura.Intervals.PerfectUnison)
                throw new BravuraException("A Chord Quality's first Interval must be Perfect Unison.");
        }

        #region -- Equality Methods --

        public static bool operator ==(ChordQuality a, ChordQuality b)
        {
            if (a.Intervals.Count != b.Intervals.Count) return false;
            return !a.Intervals.Where((t, i) => t != b.Intervals[i]).Any();
        }

        public static bool operator !=(ChordQuality a, ChordQuality b)
            => !(a == b);

        public override bool Equals(object obj)
        {
            if (!(obj is ChordQuality)) return false;
            var quality = (ChordQuality)obj;
            if (Intervals.Count != quality.Intervals.Count) return false;
            return !Intervals.Where((t, i) => t != quality.Intervals[i]).Any();
        }

        public override int GetHashCode()
            => Intervals.Sum(i => i.Semitones);

        #endregion
    }
}