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

        internal Interval(
            int semitones,
            Accidental accidental,
            int noteIndex,
            string name,
            string symbol)
        {
            Semitones = semitones;
            Accidental = accidental;
            NoteIndex = noteIndex;
            Name = name;
            Symbol = symbol;
        }

        #region -- String Methods --

        public override string ToString()
            => $"{Accidental.Symbol}{NoteIndex}";

        public string ToAsciiString()
            => $"{Accidental.AsciiSymbol}{NoteIndex}";

        #endregion

        #region -- Equality Methods --

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

        #endregion
    }
}