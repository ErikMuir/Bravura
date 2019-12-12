using System;
using System.Collections.Generic;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class Interval : IEquatable<Interval>
    {
        internal Interval(
            int semitones,
            Accidental accidental,
            int noteIndex,
            string name,
            string symbol)
        {
            Semitones = semitones;
            Accidental = accidental;
            NoteIndex = noteIndex;
            Name = name.TrimToNull();
            Symbol = symbol.TrimToNull();

            Validate();
        }

        public int Semitones { get; }
        public Accidental Accidental { get; }
        public int NoteIndex { get; }
        public string Name { get; }
        public string Symbol { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (NoteIndex < 0)
                errors.Add($"{nameof(NoteIndex)} cannot be less than 0.");
            if (Name == null)
                errors.Add($"{nameof(Name)} is required.");
            if (Symbol == null)
                errors.Add($"{nameof(Symbol)} is required.");

            if (errors.Count > 0)
                throw new BravuraTonalityException($"{nameof(Interval)} is invalid: {string.Join(" ", errors)}");
        }

        public override string ToString() => $"{Accidental.Symbol}{NoteIndex}";

        public string ToAsciiString() => $"{Accidental.AsciiSymbol}{NoteIndex}";

        public bool EffectivelyEquals(Interval other)
            => Semitones == other?.Semitones;

        public bool Equals(Interval other)
            => other != null
                && Semitones == other.Semitones
                && !Accidental.Equals(other.Accidental)
                && NoteIndex == other.NoteIndex
                && Name == other.Name
                && Symbol == other.Symbol;

        public override bool Equals(object obj)
            => (obj is Interval) && Equals((Interval)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Semitones)
                .Hash(Accidental)
                .Hash(NoteIndex)
                .Hash(Name)
                .Hash(Symbol);
    }
}