using System;
using System.Collections.Generic;
using Bravura.Common;

namespace Bravura.Tonality
{
    public struct Note : IEquatable<Note>
    {
        internal Note(char letter, short semitonesAboveC)
        {
            Letter = letter;
            SemitonesAboveC = semitonesAboveC;
        }

        public char Letter { get; }
        public short SemitonesAboveC { get; }

        public KeyValuePair<char, short> KeyValuePair => new KeyValuePair<char, short>(Letter, SemitonesAboveC);

        public int Index => Notes.MusicalAlphabet.IndexOf(Letter);

        public int PreviousIndex => (Index - 1).RollingRange(6);

        public int NextIndex => (Index + 1).RollingRange(6);

        public Note PreviousNote => GetNoteByIndex(PreviousIndex);

        public Note NextNote => GetNoteByIndex(NextIndex);

        public bool IsLowerNeighborNatural()
        {
            var semitones = SemitonesAboveC - PreviousNote.SemitonesAboveC;
            return semitones < 0 || semitones == 1;
        }

        public bool IsHigherNeighborNatural()
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

        public bool Equals(Note other)
            => Letter == other.Letter && SemitonesAboveC == other.SemitonesAboveC;

        public override bool Equals(object obj)
            => (obj is Note) && Equals((Note)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Letter)
                .Hash(SemitonesAboveC);
    }
}