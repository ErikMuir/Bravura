namespace Bravura.Tonality;

public readonly struct Accidental : ITonality
{
    internal Accidental(
        short semitonesAwayFromNatural,
        string name,
        string symbol)
    {
        SemitonesAwayFromNatural = semitonesAwayFromNatural;
        Name = name;
        Symbol = symbol;
    }

    public short SemitonesAwayFromNatural { get; init; }
    public string Name { get; init; }
    public string Symbol { get; init; }

    public override string ToString() => Symbol;
}
