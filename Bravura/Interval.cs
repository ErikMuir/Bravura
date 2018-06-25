using System;

namespace Bravura
{
    public struct Interval
    {
        public int Semitones { get; }
        public Accidental Accidental { get; }
        public int NoteIndex { get; }
        public string Name { get; }
        public string Symbol { get; }

        public Interval(
            int semitones,
            Accidental accidental,
            int noteIndex,
            string name,
            string symbol)
        {
            Semitones = semitones;
            Accidental = accidental;
            NoteIndex = noteIndex;
            Name = name ?? throw new NullReferenceException("Name cannot be null.");
            Symbol = symbol ?? throw new NullReferenceException("Symbol cannot be null.");
        }

        public override string ToString()
        {
            return $"{Accidental.DefaultSymbol}{NoteIndex}";
        }
    }
}