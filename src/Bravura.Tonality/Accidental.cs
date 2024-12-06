namespace Bravura.Tonality;

public readonly struct Accidental : ITonality
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

    public short SemitonesAwayFromNatural { get; init; }
    public string Name { get; init; }
    public string Symbol { get; init; }
    public string AsciiSymbol { get; init; }

    public override string ToString() => Symbol;
}
