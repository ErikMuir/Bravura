using Bravura.Theory;

namespace Bravura.Extensions
{
    public static class NoteExtensions
    {
        public static int Index(this Note note)
            => Notes.MusicalAlphabet.IndexOf(note.Letter);

        public static int PreviousIndex(this Note note)
            => (note.Index() - 1).RollingRange(6);

        public static int NextIndex(this Note note)
            => (note.Index() + 1).RollingRange(6);

        public static Note LowerNeighbor(this Note note)
            => Utilities.GetNoteByIndex(note.PreviousIndex());

        public static Note HigherNeighbor(this Note note)
            => Utilities.GetNoteByIndex(note.NextIndex());

        public static bool IsLowerNeighborNatural(this Note note)
            => note.SemitonesAboveC - note.LowerNeighbor().SemitonesAboveC == 1;

        public static bool IsHigherNeighborNatural(this Note note)
            => note.HigherNeighbor().SemitonesAboveC - note.SemitonesAboveC == 1;
    }
}