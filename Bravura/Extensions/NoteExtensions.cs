namespace Bravura.Extensions
{
    public static class NoteExtensions
    {
        /// <summary>
        /// Returns the index of the note in the musical alphabet.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static int Index(this Note note)
            => Theory.MusicalAlphabet.IndexOf(note.Letter);

        /// <summary>
        /// Returns the index of the previous note in the musical alphabet.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static int PreviousIndex(this Note note)
            => (note.Index() - 1).RollingRange(6);

        /// <summary>
        /// Returns the index of the next note in the musical alphabet.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static int NextIndex(this Note note)
            => (note.Index() + 1).RollingRange(6);

        /// <summary>
        /// Returns the lower neighbor note in the musical alphabet.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static Note LowerNeighbor(this Note note)
            => Utilities.GetNoteByIndex(note.PreviousIndex());

        /// <summary>
        /// Returns the higher neighbor note in the musical alphabet.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static Note HigherNeighbor(this Note note)
            => Utilities.GetNoteByIndex(note.NextIndex());

        /// <summary>
        /// Returns true if the lower neighbor note in the musical alphabet is a half-step down.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static bool IsLowerNeighborNatural(this Note note)
        {
            var semitones = note.SemitonesAboveC - note.LowerNeighbor().SemitonesAboveC;
            return semitones < 0 || semitones == 1;
        }

        /// <summary>
        /// Returns true if the higher neighbor note in the musical alphabet is a half-step up.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static bool IsHigherNeighborNatural(this Note note)
        {
            var semitones = note.HigherNeighbor().SemitonesAboveC - note.SemitonesAboveC;
            return semitones < 0 || semitones == 1;
        }
    }
}