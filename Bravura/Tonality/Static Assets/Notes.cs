using Bravura.Constants;

namespace Bravura
{
    public static partial class Tonality
    {
        public static Note C { get; private set; }
        public static Note D { get; private set; }
        public static Note E { get; private set; }
        public static Note F { get; private set; }
        public static Note G { get; private set; }
        public static Note A { get; private set; }
        public static Note B { get; private set; }
        public static ReadOnlyOrderedDictionary<char, short> MusicalAlphabet { get; private set; }

        static partial void SetNotes()
        {
            C = new Note(NoteLetters.C, NoteValues.C);
            D = new Note(NoteLetters.D, NoteValues.D);
            E = new Note(NoteLetters.E, NoteValues.E);
            F = new Note(NoteLetters.F, NoteValues.F);
            G = new Note(NoteLetters.G, NoteValues.G);
            A = new Note(NoteLetters.A, NoteValues.A);
            B = new Note(NoteLetters.B, NoteValues.B);

            MusicalAlphabet = new ReadOnlyOrderedDictionary<char, short>
            {
                C.KeyValuePair,
                D.KeyValuePair,
                E.KeyValuePair,
                F.KeyValuePair,
                G.KeyValuePair,
                A.KeyValuePair,
                B.KeyValuePair,
            };
        }
    }
}