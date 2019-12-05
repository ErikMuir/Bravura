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

        public short SemitonesAwayFromNatural { get; }
        public string Name { get; }
        public string Symbol { get; }
        public string AsciiSymbol { get; }
    }
}