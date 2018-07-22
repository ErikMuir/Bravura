using System;

namespace Bravura
{
    public struct NoteName
    {
        public int Index { get; }
        public int Value { get; }
        public string Symbol { get; }
        public bool IsLowerNeighborHalfstep { get; }
        public bool IsHigherNeighborHalfstep { get; }

        public NoteName(int index, int value, string symbol, bool isLowerNeighborHalfstep, bool isHigherNeighborHalfstep)
        {
            if (index < 0 || index > 6)
                throw new BravuraException("A NoteName's Index must be between 0 and 6.");
            if (value < 0 || value > 11)
                throw new BravuraException("A NoteName's Value must be between 0 and 11.");

            Index = index;
            Value = value;
            Symbol = symbol ?? throw new BravuraException("A NoteName's Symbol cannot be null.");
            IsLowerNeighborHalfstep = isLowerNeighborHalfstep;
            IsHigherNeighborHalfstep = isHigherNeighborHalfstep;
        }

        public NoteName LowerNeighbor
            => NoteNames.AllNotes[((Index - 1) == -1 ? 6 : (Index - 1))];

        public NoteName HigherNeighbor
            => NoteNames.AllNotes[((Index + 1) == 7 ? 0 : (Index + 1))];

        public static bool operator ==(NoteName a, NoteName b)
        {
            return a.Value == b.Value;
        }

        public static bool operator !=(NoteName a, NoteName b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NoteName))
            {
                return false;
            }

            var name = (NoteName)obj;
            return Value == name.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}