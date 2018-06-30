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
            Name = name ?? throw new BravuraException("An Interval's Name cannot be null.");
            Symbol = symbol ?? throw new BravuraException("An Interval's Symbol cannot be null.");
        }

        public static bool operator ==(Interval a, Interval b)
        {
            return a.Semitones == b.Semitones;
        }

        public static bool operator !=(Interval a, Interval b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $"{Accidental.DefaultSymbol}{NoteIndex}";
        }
    }
}