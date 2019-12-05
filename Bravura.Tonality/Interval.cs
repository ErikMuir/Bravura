namespace Bravura.Tonality
{
    public class Interval
    {
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

        public int Semitones { get; }
        public Accidental Accidental { get; }
        public int NoteIndex { get; }
        public string Name { get; }
        public string Symbol { get; }

        public override string ToString()
            => $"{Accidental.Symbol}{NoteIndex}";

        public string ToAsciiString()
            => $"{Accidental.AsciiSymbol}{NoteIndex}";

        //public static bool operator ==(Interval a, Interval b)
        //{
        //    if (a == null && b == null) return true;
        //    if (a == null || b == null) return false;
        //    return a.NoteIndex == b.NoteIndex && a.Accidental.SemitonesAwayFromNatural == b.Accidental.SemitonesAwayFromNatural;
        //}

        //public static bool operator !=(Interval a, Interval b)
        //{
        //    return !(a == b);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (!(obj is Interval)) return false;
        //    var interval = (Interval)obj;
        //    return this.NoteIndex == interval.NoteIndex && this.Accidental.SemitonesAwayFromNatural == interval.Accidental.SemitonesAwayFromNatural;
        //}

        //public override int GetHashCode()
        //    => this.NoteIndex + this.Accidental.SemitonesAwayFromNatural;
    }
}