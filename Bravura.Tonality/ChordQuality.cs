using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class ChordQuality : IEquatable<ChordQuality>
    {
        public ChordQuality(string symbol, string asciiSymbol, List<Interval> intervals)
        {
            Symbol = symbol.SafeTrim();
            AsciiSymbol = asciiSymbol.SafeTrim();
            Intervals = intervals;

            Validate();
        }

        public string Symbol { get; }
        public string AsciiSymbol { get; }
        public List<Interval> Intervals { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Symbol == null)
                errors.Add($"{nameof(Symbol)} is required.");
            if (AsciiSymbol == null)
                errors.Add($"{nameof(AsciiSymbol)} is required.");
            if (Intervals == null)
                errors.Add($"{nameof(Intervals)} is required.");
            else if (Intervals.Count < 2)
                errors.Add($"{nameof(Intervals)} length cannot be less than 2.");
            else
            {
                if (Intervals[0] != Bravura.Tonality.Intervals.PerfectUnison)
                    errors.Add($"The first interval in {nameof(Intervals)} must be {Bravura.Tonality.Intervals.PerfectUnison.Name}.");
                if (Intervals.Count != Intervals.Select(x => x.Semitones).Distinct().Count())
                    errors.Add($"All {nameof(Intervals)} must be unique.");
            }

            if (errors.Count > 0)
                throw new ChordQualityException(errors);
        }

        public bool EffectivelyEquals(ChordQuality other)
        {
            if (other == null) return false;
            if (Intervals.Count != other.Intervals.Count) return false;
            for (var i = 0; i < Intervals.Count; i++)
            {
                if (!Intervals[i].Equals(other.Intervals[i])) return false;
            }
            return true;
        }

        public bool Equals(ChordQuality other)
        {
            if (other == null) return false;
            if (Symbol != other.Symbol) return false;
            if (AsciiSymbol != other.AsciiSymbol) return false;
            if (Intervals.Count != other.Intervals.Count) return false;
            for (var i = 0; i < Intervals.Count; i++)
            {
                if (!Intervals[i].Equals(other.Intervals[i])) return false;
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
            for (var i = 0; i < Intervals.Count; i++)
            {
                hashCode = hashCode.Hash(Intervals[i]);
            }
            return hashCode;
        }
    }
}