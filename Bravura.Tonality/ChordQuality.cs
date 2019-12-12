using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class ChordQuality : IEquatable<ChordQuality>
    {
        public ChordQuality(string symbol, string asciiSymbol, List<Interval> chordQualityIntervals)
        {
            Symbol = symbol.TrimToNull();
            AsciiSymbol = asciiSymbol.TrimToNull();
            ChordQualityIntervals = chordQualityIntervals;

            Validate();
        }

        public string Symbol { get; }
        public string AsciiSymbol { get; }
        public List<Interval> ChordQualityIntervals { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Symbol == null)
                errors.Add($"{nameof(Symbol)} is required.");
            if (AsciiSymbol == null)
                errors.Add($"{nameof(AsciiSymbol)} is required.");
            if (ChordQualityIntervals == null)
                errors.Add($"{nameof(ChordQualityIntervals)} is required.");
            if (ChordQualityIntervals.Count < 2)
                errors.Add($"{nameof(ChordQualityIntervals)} length cannot be less than 2.");
            if (ChordQualityIntervals[0] != Intervals.PerfectUnison)
                errors.Add($"The first interval in {nameof(ChordQualityIntervals)} must be {Intervals.PerfectUnison.Name}.");
            if (ChordQualityIntervals.Count != ChordQualityIntervals.Select(x => x.Semitones).Distinct().Count())
                errors.Add($"All {nameof(ChordQualityIntervals)} must be unique.");

            if (errors.Count > 0)
                throw new BravuraTonalityException($"{nameof(ChordQuality)} is invalid: {string.Join(" ", errors)}");
        }

        public bool EffectivelyEquals(ChordQuality other)
        {
            if (other == null) return false;
            if (ChordQualityIntervals.Count != other.ChordQualityIntervals.Count) return false;
            for (var i = 0; i < ChordQualityIntervals.Count; i++)
            {
                if (!ChordQualityIntervals[i].Equals(other.ChordQualityIntervals[i])) return false;
            }
            return true;
        }

        public bool Equals(ChordQuality other)
        {
            if (other == null) return false;
            if (Symbol != other.Symbol) return false;
            if (AsciiSymbol != other.AsciiSymbol) return false;
            if (ChordQualityIntervals.Count != other.ChordQualityIntervals.Count) return false;
            for (var i = 0; i < ChordQualityIntervals.Count; i++)
            {
                if (!ChordQualityIntervals[i].Equals(other.ChordQualityIntervals[i])) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
            => (obj is ChordQuality) && Equals((ChordQuality)obj);

        public override int GetHashCode()
        {
            var hashCode = HashCode.Start
                .Hash(Symbol)
                .Hash(AsciiSymbol);
            for (var i = 0; i < ChordQualityIntervals.Count; i++)
            {
                hashCode = hashCode.Hash(ChordQualityIntervals[i]);
            }
            return hashCode;
        }
    }
}