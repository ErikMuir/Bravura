using System;

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
            Name = name;
            Symbol = symbol;
            AsciiSymbol = asciiSymbol;
        }

        public short SemitonesAwayFromNatural { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string AsciiSymbol { get; }

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