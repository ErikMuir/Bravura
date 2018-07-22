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
            if (semitones < 0 || semitones > 12)
                throw new BravuraException("An Interval's Semitones must be between 0 and 12.");
            Semitones = semitones;
            Accidental = accidental;
            if (noteIndex < 1 || noteIndex > 8)
                throw new BravuraException("An Interval's NoteIndex must be between 1 and 8.");
            NoteIndex = noteIndex;
            Name = name ?? throw new BravuraException("An Interval's Name cannot be null.");
            Symbol = symbol ?? throw new BravuraException("An Interval's Symbol cannot be null.");
        }

        public override string ToString()
            => $"{Accidental.DefaultSymbol}{NoteIndex}";

        public static bool operator ==(Interval a, Interval b)
            => a.Semitones == b.Semitones;

        public static bool operator !=(Interval a, Interval b)
            => !(a == b);

        public override bool Equals(object obj)
        {
            if (!(obj is Interval)) return false;
            var interval = (Interval)obj;
            return Semitones == interval.Semitones;
        }

        public override int GetHashCode()
            => HashCode.Combine(Semitones);
    }
}