namespace Bravura.Tonality;

public record Accidental : ITonality
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

    public short SemitonesAwayFromNatural { get; }

    public string Name { get; }

    public string Symbol { get; }

    public override string ToString() => Symbol;
}
