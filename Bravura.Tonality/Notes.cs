using System.Collections.Generic;
using Bravura.Common;

namespace Bravura.Tonality;

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

        var notes = new List<KeyValuePair<char, short>>
            {
                C.KeyValuePair,
                D.KeyValuePair,
                E.KeyValuePair,
                F.KeyValuePair,
                G.KeyValuePair,
                A.KeyValuePair,
                B.KeyValuePair,
            }.AsReadOnly();

        MusicalAlphabet = new ReadOnlyOrderedDictionary<char, short>(notes);
    }

    public static Note C { get; }
    public static Note D { get; }
    public static Note E { get; }
    public static Note F { get; }
    public static Note G { get; }
    public static Note A { get; }
    public static Note B { get; }
    public static ReadOnlyOrderedDictionary<char, short> MusicalAlphabet { get; }
}

public static class NoteLetters
{
    public const char C = 'C';
    public const char D = 'D';
    public const char E = 'E';
    public const char F = 'F';
    public const char G = 'G';
    public const char A = 'A';
    public const char B = 'B';
}

public static class NoteValues
{
    public const short C = 0;
    public const short D = 2;
    public const short E = 4;
    public const short F = 5;
    public const short G = 7;
    public const short A = 9;
    public const short B = 11;
}
