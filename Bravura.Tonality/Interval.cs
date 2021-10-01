using System.Collections.Generic;

namespace Bravura.Tonality
{
    public record Interval
    {
        public int Semitones { get; init; }
        public Accidental Accidental { get; init; }
        public int Degree { get; init; }
        public string Name { get; init; }
        public string Symbol { get; init; }

        public Interval(int semitones, Accidental accidental, int degree, string name, string symbol)
        {
            var errors = new List<string>();

            if (degree < 1)
                errors.Add($"{ nameof(Degree) } cannot be less than 1.");
            if (degree > 8)
                errors.Add($"{ nameof(Degree) } cannot be more than 8.");
            if (string.IsNullOrWhiteSpace(name))
                errors.Add($"{ nameof(Name) } is required.");
            if (string.IsNullOrWhiteSpace(symbol))
                errors.Add($"{ nameof(Symbol) } is required.");

            if (errors.Count > 0)
                throw new IntervalException(errors);

            Semitones = semitones;
            Accidental = accidental;
            Degree = degree;
            Name = name;
            Symbol = symbol;
        }

        public void Deconstruct(out int semitones, out Accidental accidental, out int degree, out string name, out string symbol) 
            => (semitones, accidental, degree, name, symbol) = (Semitones, Accidental, Degree, Name, Symbol);

        public override string ToString() => $"{ Accidental.Symbol }{ Degree }";

        public string ToAsciiString() => $"{ Accidental.AsciiSymbol }{ Degree }";

        public bool EffectivelyEquals(Interval other) => Semitones == other?.Semitones;
    }
}
