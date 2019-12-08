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

        public override string ToString() => $"{Accidental.Symbol}{NoteIndex}";

        public string ToAsciiString() => $"{Accidental.AsciiSymbol}{NoteIndex}";
    }
}