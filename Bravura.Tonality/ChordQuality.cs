using System;
using System.Collections.Generic;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class ChordQuality
    {
        public ChordQuality(string symbol, string asciiSymbol, List<Interval> intervals)
        {
            try
            {
                Symbol = symbol ?? throw new Exception();
                AsciiSymbol = asciiSymbol ?? throw new Exception();
                ChordQualityIntervals = intervals ?? throw new Exception();
                if (intervals.Count < 2)
                    throw new Exception();
                if (intervals[0] != Intervals.PerfectUnison)
                    throw new Exception();
            }
            catch (Exception)
            {
                throw new BravuraTonalityException($"{nameof(ChordQuality)} is invalid");
            }
        }

        public string Symbol { get; }

        public string AsciiSymbol { get; }

        public List<Interval> ChordQualityIntervals { get; }

        //public static bool operator ==(ChordQuality a, ChordQuality b)
        //{
        //    if (a == null && b == null) return true;
        //    if (a == null || b == null) return false;
        //    if (a.ChordQualityIntervals.Count != b.ChordQualityIntervals.Count) return false;
        //    return !a.ChordQualityIntervals.Where((t, i) => t != b.ChordQualityIntervals[i]).Any();
        //}

        //public static bool operator !=(ChordQuality a, ChordQuality b)
        //    => !(a == b);

        //public override bool Equals(object obj)
        //{
        //    if (!(obj is ChordQuality)) return false;
        //    var quality = (ChordQuality)obj;
        //    if (ChordQualityIntervals.Count != quality.ChordQualityIntervals.Count) return false;
        //    return !ChordQualityIntervals.Where((t, i) => t != quality.ChordQualityIntervals[i]).Any();
        //}

        //public override int GetHashCode()
        //    => ChordQualityIntervals.Sum(i => i.Semitones);
    }
}