namespace Bravura
{
    public struct Accidental
    {
        public int Value { get; }
        public string DefaultSymbol { get; }
        public string ActualSymbol { get; }

        public Accidental(int value, string defaultSymbol, string actualSymbol)
        {
            if (value < -2 || value > 2)
                throw new BravuraException("An Accidental's Value cannot be less than -2 or more than 2.");
            Value = value;
            DefaultSymbol = defaultSymbol ?? throw new BravuraException("An Accidental's DefaultSymbol cannot be null.");
            ActualSymbol = actualSymbol ?? throw new BravuraException("An Accidental's ActualSymbol cannot be null.");
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
