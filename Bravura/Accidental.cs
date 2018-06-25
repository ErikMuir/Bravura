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
            Value = value;
            DefaultSymbol = defaultSymbol ?? throw new NullReferenceException("DefaultSymbol cannot be null.");
            ActualSymbol = actualSymbol ?? throw new NullReferenceException("ActualSymbol cannot be null.");
        }
    }
}
