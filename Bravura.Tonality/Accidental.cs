namespace Bravura.Tonality
{
    public class Accidental
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

        public readonly short SemitonesAwayFromNatural;
        public readonly string Name;
        public readonly string Symbol;
        public readonly string AsciiSymbol;
    }
}