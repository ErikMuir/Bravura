using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Exceptions;

namespace Bravura
{
    public struct ChordQuality
    {
        public string Symbol { get; }
        public string AsciiSymbol { get; }
        public List<Interval> Intervals { get; }

        public ChordQuality(string symbol, string asciiSymbol, List<Interval> intervals)
        {
            try
            {
                Symbol = symbol ?? throw new Exception();
                AsciiSymbol = asciiSymbol ?? throw new Exception();
                Intervals = intervals ?? throw new Exception();
                if (intervals.Count < 2)
                    throw new Exception();
                if (intervals[0] != Bravura.Intervals.PerfectUnison)
                    throw new Exception();
            }
            catch (Exception)
            {
                throw new BravuraException($"{nameof(ChordQuality)} is invalid");
            }
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