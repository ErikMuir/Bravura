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
            int noteIndexCount,
            string name,
            string symbol)
        {
            Semitones = semitones;
            Accidental = accidental;
            NoteIndexCount = noteIndexCount;
            Name = name.TrimToNull();
            Symbol = symbol.TrimToNull();

            Validate();
        }

        public int Semitones { get; }
        public Accidental Accidental { get; }
        public int NoteIndexCount { get; }
        public string Name { get; }
        public string Symbol { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (NoteIndexCount < 0)
                errors.Add($"{nameof(NoteIndexCount)} cannot be less than 0.");
            if (NoteIndexCount > 7)
                errors.Add($"{nameof(NoteIndexCount)} cannot be more than 7.");
            if (Name == null)
                errors.Add($"{nameof(Name)} is required.");
            if (Symbol == null)
                errors.Add($"{nameof(Symbol)} is required.");

            if (errors.Count > 0)
                throw new IntervalException(errors);
        }

        public override string ToString() => $"{Accidental.Symbol}{NoteIndexCount}";

        public string ToAsciiString() => $"{Accidental.AsciiSymbol}{NoteIndexCount}";

        public bool EffectivelyEquals(Interval other)
            => Semitones == other?.Semitones;

        public bool Equals(Interval other)
            => other != null
                && Semitones == other.Semitones
                && Accidental.Equals(other.Accidental)
                && NoteIndexCount == other.NoteIndexCount
                && Name == other.Name
                && Symbol == other.Symbol;

        public override bool Equals(object obj)
            => (obj is Interval) && Equals((Interval)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Semitones)
                .Hash(Accidental)
                .Hash(NoteIndexCount)
                .Hash(Name)
                .Hash(Symbol);
    }
}