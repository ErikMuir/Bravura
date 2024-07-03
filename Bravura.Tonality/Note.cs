using System.Collections.Generic;
using Bravura.Common.Extensions;

namespace Bravura.Tonality;

public readonly struct Note(char letter, short semitonesAboveC) : IBaseTonality
{
    public char Letter { get; init; } = letter;
    public short SemitonesAboveC { get; init; } = semitonesAboveC;

    public KeyValuePair<char, short> KeyValuePair => new(Letter, SemitonesAboveC);

    public int Index => Notes.MusicalAlphabet.IndexOf(Letter);

    public int PreviousIndex => (Index - 1).RollingRange(6);

    public int NextIndex => (Index + 1).RollingRange(6);

    public Note PreviousNote => GetNoteByIndex(PreviousIndex);

    public Note NextNote => GetNoteByIndex(NextIndex);

    public bool IsPreviousNoteOneSemitoneAway()
    {
        var semitones = SemitonesAboveC - PreviousNote.SemitonesAboveC;
        return semitones < 0 || semitones == 1;
    }

    public bool IsNextNoteOneSemitoneAway()
    {
        var semitones = NextNote.SemitonesAboveC - SemitonesAboveC;
        return semitones < 0 || semitones == 1;
    }

    public static Note GetNoteByIndex(int index)
    {
        index = index.RollingRange(6);
        var noteLetter = Notes.MusicalAlphabet.KeysList[index];
        var semitones = Notes.MusicalAlphabet[index];
        return new Note(noteLetter, semitones);
    }

    public string DisplayValue(bool onlyAscii = false) => $"{Letter}";
}
