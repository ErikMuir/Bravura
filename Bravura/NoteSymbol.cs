namespace Bravura
{
    public struct NoteSymbol
    {
        public NoteName NoteName { get; }
        public Accidental Accidental { get; }

        public NoteSymbol(NoteName noteName, Accidental accidental)
        {
            NoteName = noteName;
            Accidental = accidental;
        }

        public override string ToString()
            => $"{NoteName.Symbol}{Accidental.DefaultSymbol}";

        public string ToAsciiString()
            => $"{NoteName.Symbol}{Accidental.AsciiSymbol}";
    }
}