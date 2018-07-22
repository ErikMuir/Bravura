using System;

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
                throw new BravuraException("An Accidental's Value must be between -2 and 2.");
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

        public override bool Equals(object obj)
        {
            if (!(obj is Accidental))
            {
                return false;
            }

            var accidental = (Accidental)obj;
            return Value == accidental.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
