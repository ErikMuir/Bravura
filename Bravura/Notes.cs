using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bravura.Constants;
using Bravura.Theory;

namespace Bravura
{
    public static class Notes
    {
        public static readonly Note C = new Note(NoteLetters.C, (int)NoteValue.C);
        public static readonly Note D = new Note(NoteLetters.D, (int)NoteValue.D);
        public static readonly Note E = new Note(NoteLetters.E, (int)NoteValue.E);
        public static readonly Note F = new Note(NoteLetters.F, (int)NoteValue.F);
        public static readonly Note G = new Note(NoteLetters.G, (int)NoteValue.G);
        public static readonly Note A = new Note(NoteLetters.A, (int)NoteValue.A);
        public static readonly Note B = new Note(NoteLetters.B, (int)NoteValue.B);

        public static readonly ReadOnlyCollection<Note> AllNotes =
            new List<Note> { C, D, E, F, G, A, B, }.AsReadOnly();

        public static readonly ReadOnlyOrderedDictionary<char, int> MusicalAlphabet =
            new ReadOnlyOrderedDictionary<char, int>
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

    public enum NoteValue
    {
        C = 0,
        D = 2,
        E = 4,
        F = 5,
        G = 7,
        A = 9,
        B = 11,
    }
}