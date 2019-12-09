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

        public bool QualityEquals(ChordQuality quality)
        {
            if (quality == null) return false;
            if (ChordQualityIntervals.Count != quality.ChordQualityIntervals.Count) return false;
            for (var i = 0; i < ChordQualityIntervals.Count; i++)
            {
                if (ChordQualityIntervals[i] != quality.ChordQualityIntervals[i]) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ChordQuality)) return false;
            var quality = (ChordQuality)obj;
            if (Symbol != quality.Symbol || AsciiSymbol != quality.AsciiSymbol) return false;
            if (ChordQualityIntervals.Count != quality.ChordQualityIntervals.Count) return false;
            for (var i = 0; i < ChordQualityIntervals.Count; i++)
            {
                if (ChordQualityIntervals[i] != quality.ChordQualityIntervals[i]) return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            var hashCode = HashCode.Start
                .Hash(Symbol)
                .Hash(AsciiSymbol);
            ChordQualityIntervals.ForEach(i =>
            {
                hashCode = hashCode.Hash(i);
            });
            return hashCode;
        }
    }
}