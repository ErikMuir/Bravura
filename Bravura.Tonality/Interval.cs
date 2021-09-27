using System;
using System.Collections.Generic;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Interval : IEquatable<Interval>
    {
        public Interval(
            int semitones,
            Accidental accidental,
            int degree,
            string name,
            string symbol)
        {
            Semitones = semitones;
            Accidental = accidental;
            Degree = degree;
            Name = name.TrimToNull();
            Symbol = symbol.TrimToNull();

            Validate();
        }

        public int Semitones { get; }
        public Accidental Accidental { get; }
        public int Degree { get; }
        public string Name { get; }
        public string Symbol { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Degree < 0)
                errors.Add($"{nameof(Degree)} cannot be less than 0.");
            if (Degree > 7)
                errors.Add($"{nameof(Degree)} cannot be more than 7.");
            if (Name == null)
                errors.Add($"{nameof(Name)} is required.");
            if (Symbol == null)
                errors.Add($"{nameof(Symbol)} is required.");

            if (errors.Count > 0)
                throw new IntervalException(errors);
        }

        public override string ToString() => $"{Accidental.Symbol}{Degree + 1}";

        public string ToAsciiString() => $"{Accidental.AsciiSymbol}{Degree + 1}";

        public bool EffectivelyEquals(Interval other)
            => Semitones == other?.Semitones;

        public bool Equals(Interval other)
            => other != null
                && Semitones == other.Semitones
                && Accidental.Equals(other.Accidental)
                && Degree == other.Degree
                && Name == other.Name
                && Symbol == other.Symbol;

        public override bool Equals(object obj)
            => (obj is Interval) && Equals((Interval)obj);

        public override int GetHashCode()
            => Bravura.Common.HashCode.Start
                .Hash(Semitones)
                .Hash(Accidental)
                .Hash(Degree)
                .Hash(Name)
                .Hash(Symbol);
    }
}
