using System;
using System.Collections.Generic;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public struct Accidental : IEquatable<Accidental>
    {
        internal Accidental(
            short semitonesAwayFromNatural,
            string name,
            string symbol,
            string asciiSymbol)
        {
            SemitonesAwayFromNatural = semitonesAwayFromNatural;
            Name = name.TrimToNull();
            Symbol = symbol.TrimToNull();
            AsciiSymbol = asciiSymbol.TrimToNull();

            Validate();
        }

        public short SemitonesAwayFromNatural { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string AsciiSymbol { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Name == null)
                errors.Add($"{nameof(Name)} is required.");
            if (Symbol == null)
                errors.Add($"{nameof(Symbol)} is required.");
            if (AsciiSymbol == null)
                errors.Add($"{nameof(AsciiSymbol)} is required.");

            if (errors.Count > 0)
                throw new BravuraTonalityException($"{nameof(Accidental)} is invalid: {string.Join(" ", errors)}");
        }

        public bool EffectivelyEquals(Accidental other)
            => SemitonesAwayFromNatural == other.SemitonesAwayFromNatural;

        public bool Equals(Accidental other)
            => SemitonesAwayFromNatural == other.SemitonesAwayFromNatural
                && Name == other.Name
                && Symbol == other.Symbol
                && AsciiSymbol == other.AsciiSymbol;

        public override bool Equals(object obj)
            => (obj is Accidental) && Equals((Accidental)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(SemitonesAwayFromNatural)
                .Hash(Name)
                .Hash(Symbol)
                .Hash(AsciiSymbol);
    }
}