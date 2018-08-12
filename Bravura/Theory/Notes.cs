using Bravura.Constants;

namespace Bravura
{
    public static partial class Theory
    {
        public static readonly Note C = new Note(NoteLetters.C, NoteValues.C);
        public static readonly Note D = new Note(NoteLetters.D, NoteValues.D);
        public static readonly Note E = new Note(NoteLetters.E, NoteValues.E);
        public static readonly Note F = new Note(NoteLetters.F, NoteValues.F);
        public static readonly Note G = new Note(NoteLetters.G, NoteValues.G);
        public static readonly Note A = new Note(NoteLetters.A, NoteValues.A);
        public static readonly Note B = new Note(NoteLetters.B, NoteValues.B);

        public static readonly ReadOnlyOrderedDictionary<char, short> MusicalAlphabet =
            new ReadOnlyOrderedDictionary<char, short>
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