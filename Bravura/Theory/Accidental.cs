using System;

namespace Bravura
{
    public struct Accidental
    {
        public short SemitonesAwayFromNatural { get; }
        public string Name { get; }
        public string DefaultSymbol { get; }
        public string ActualSymbol { get; }
        public string AsciiSymbol { get; }

        internal Accidental(
            short semitonesAwayFromNatural, 
            string name, 
            string defaultSymbol, 
            string actualSymbol, 
            string asciiSymbol)
        {
            SemitonesAwayFromNatural = semitonesAwayFromNatural;
            Name = name;
            DefaultSymbol = defaultSymbol;
            ActualSymbol = actualSymbol;
            AsciiSymbol = asciiSymbol;
        }

        #region -- Equality Methods --

        public static bool operator ==(Accidental a, Accidental b)
            => a.SemitonesAwayFromNatural == b.SemitonesAwayFromNatural;

        public static bool operator !=(Accidental a, Accidental b)
            => !(a == b);

        public override bool Equals(object obj)
        {
            if (!(obj is Accidental)) return false;
            var accidental = (Accidental)obj;
            return SemitonesAwayFromNatural == accidental.SemitonesAwayFromNatural;
        }

        public override int GetHashCode()
            => HashCode.Combine(SemitonesAwayFromNatural);

        #endregion 
    }
}