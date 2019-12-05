﻿using System;
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
                Symbol = symbol?.Trim();
                AsciiSymbol = asciiSymbol?.Trim();
                ChordQualityIntervals = chordQualityIntervals;

                if (Symbol == null)
                    throw new Exception($"{nameof(Symbol)} is required.");
                if (AsciiSymbol == null)
                    throw new Exception($"{nameof(AsciiSymbol)} is required.");
                if (ChordQualityIntervals == null)
                    throw new Exception($"{nameof(ChordQualityIntervals)} is required.");
                if (ChordQualityIntervals.Count < 2)
                    throw new Exception($"{nameof(ChordQualityIntervals)} length cannot be less than 2.");
                if (ChordQualityIntervals[0] != Intervals.PerfectUnison)
                    throw new Exception($"the first interval in {nameof(ChordQualityIntervals)} must be {Intervals.PerfectUnison.Name}.");
                if (ChordQualityIntervals.Count != ChordQualityIntervals.Select(x => x.Semitones).Distinct().Count())
                    throw new Exception($"all {nameof(ChordQualityIntervals)} must be unique.");
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