using Bravura.Constants;

namespace Bravura.Tonality
{
    public static class Notes
    {
        static Notes()
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

        public static readonly Note C;
        public static readonly Note D;
        public static readonly Note E;
        public static readonly Note F;
        public static readonly Note G;
        public static readonly Note A;
        public static readonly Note B;
        public static readonly ReadOnlyOrderedDictionary<char, short> MusicalAlphabet;
    }
}