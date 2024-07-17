namespace Bravura.Tonality;

public readonly struct Accidental(
    short semitonesAwayFromNatural,
    string name,
    string symbol,
    string asciiSymbol) : IBaseTonality
{
    public short SemitonesAwayFromNatural { get; init; } = semitonesAwayFromNatural;
    public string Name { get; init; } = name;
    public string Symbol { get; init; } = symbol;
    public string AsciiSymbol { get; init; } = asciiSymbol;

    public string DisplayValue(bool onlyAscii = false) => onlyAscii ? AsciiSymbol : Symbol;

    public override string ToString() => DisplayValue(true);
}
