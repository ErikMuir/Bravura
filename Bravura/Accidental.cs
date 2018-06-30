namespace Bravura
{
    public struct Accidental
    {
        public int Value { get; }
        public string DefaultSymbol { get; }
        public string ActualSymbol { get; }
        public string ConsoleSymbol { get; }

        public Accidental(int value, string defaultSymbol, string actualSymbol, string consoleSymbol)
        {
            Value = value;
            DefaultSymbol = defaultSymbol ?? throw new BravuraException("An Accidental's DefaultSymbol cannot be null.");
            ActualSymbol = actualSymbol ?? throw new BravuraException("An Accidental's ActualSymbol cannot be null.");
            ConsoleSymbol = consoleSymbol ?? throw new BravuraException("An Accidental's ConsoleSymbol cannot be null.");
        }

        public static bool operator ==(Accidental a, Accidental b)
        {
            return a.Value == b.Value;
        }

        public static bool operator !=(Accidental a, Accidental b)
        {
            return !(a == b);
        }
    }
}
