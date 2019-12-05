using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class ChordQuality
    {
        public ChordQuality(string symbol, string asciiSymbol, List<Interval> chordQualityIntervals)
        {
            try
            {
                Symbol = symbol?.Trim() ?? throw new Exception($"{nameof(symbol)} is required.");
                AsciiSymbol = asciiSymbol?.Trim() ?? throw new Exception($"{nameof(asciiSymbol)} is required.");
                ChordQualityIntervals = chordQualityIntervals ?? throw new Exception($"{nameof(chordQualityIntervals)} is required.");

                if (chordQualityIntervals.Count < 2)
                    throw new Exception($"{nameof(chordQualityIntervals)} length cannot be less than 2.");
                if (chordQualityIntervals[0] != Intervals.PerfectUnison)
                    throw new Exception($"the first interval in {nameof(chordQualityIntervals)} must be {Intervals.PerfectUnison.Name}.");
                if (chordQualityIntervals.Count != chordQualityIntervals.Select(x => x.Semitones).Distinct().Count())
                    throw new Exception($"all {nameof(chordQualityIntervals)} must be unique.");
            }
            catch (Exception ex)
            {
                throw new BravuraTonalityException($"{nameof(ChordQuality)} is invalid: {ex.Message}");
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