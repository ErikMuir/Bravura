using System;

namespace Bravura
{
    public struct NoteName
    {
        public int Index { get; }
        public int Value { get; }
        public string Symbol { get; }
        public Accidental KeyAccidental { get; }
        public bool IsLowerNeighborHalfstep { get; }
        public bool IsHigherNeighborHalfstep { get; }

        public NoteName(int index, int value, string symbol, Accidental keyAccidental, bool isLowerNeighborHalfstep, bool isHigherNeighborHalfstep)
        {
            Index = index;
            Value = value;
            Symbol = symbol ?? throw new NullReferenceException("Symbol cannot be null.");
            KeyAccidental = keyAccidental;
            IsLowerNeighborHalfstep = isLowerNeighborHalfstep;
            IsHigherNeighborHalfstep = isHigherNeighborHalfstep;
        }

        public NoteName LowerNeighbor
            => NoteNames.AllNotes[((Index - 1) == -1 ? 6 : (Index - 1))];

        public NoteName HigherNeighbor
            => NoteNames.AllNotes[((Index + 1) == 7 ? 0 : (Index + 1))];
    }
}