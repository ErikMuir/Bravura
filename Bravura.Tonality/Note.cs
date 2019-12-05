using System.Collections.Generic;
using Bravura.Tonality.Extensions;

namespace Bravura.Tonality
{
    public class Note
    {
        internal Note(char letter, short semitonesAboveC)
        {
            Letter = letter;
            SemitonesAboveC = semitonesAboveC;
            KeyValuePair = new KeyValuePair<char, short>(letter, semitonesAboveC);
        }

        public char Letter { get; }
        public short SemitonesAboveC { get; }
        public KeyValuePair<char, short> KeyValuePair { get; }

        public int Index() => Notes.MusicalAlphabet.IndexOf(Letter);

        public int PreviousIndex() => (Index() - 1).RollingRange(6);

        public int NextIndex() => (Index() + 1).RollingRange(6);

        public Note LowerNeighbor() => GetNoteByIndex(PreviousIndex());

        public Note HigherNeighbor() => GetNoteByIndex(NextIndex());

        public bool IsLowerNeighborNatural()
        {
            var semitones = SemitonesAboveC - LowerNeighbor().SemitonesAboveC;
            return semitones < 0 || semitones == 1;
        }

        public bool IsHigherNeighborNatural()
        {
            var semitones = HigherNeighbor().SemitonesAboveC - SemitonesAboveC;
            return semitones < 0 || semitones == 1;
        }

        public static Note GetNoteByIndex(int index)
        {
            index = index.RollingRange(6);
            var noteLetter = Notes.MusicalAlphabet.KeysList[index];
            var semitones = Notes.MusicalAlphabet[index];
            return new Note(noteLetter, semitones);
        }
    }
}