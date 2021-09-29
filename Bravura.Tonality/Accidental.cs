namespace Bravura.Tonality
{
    public readonly struct Accidental
    {
        public short SemitonesAwayFromNatural { get; init; }
        public string Name { get; init; }
        public string Symbol { get; init; }
        public string AsciiSymbol { get; init; }

        public Accidental(
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

        public override string ToString() => Symbol;

        public string ToAsciiString() => AsciiSymbol;
    }
}
