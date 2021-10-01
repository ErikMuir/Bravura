namespace Bravura.Tonality
{
    public record Interval(short Semitones, Accidental Accidental, short Degree, string Name, string Symbol)
    {
        public bool EffectivelyEquals(Interval other) => Semitones == other?.Semitones;
        public override string ToString() => $"{ Accidental.Symbol }{ Degree }";
        public string ToAsciiString() => $"{ Accidental.AsciiSymbol }{ Degree }";
    }
}
