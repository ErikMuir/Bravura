using Bravura.Extensions;

namespace Bravura
{
    public static class Utilities
    {
        /// <summary>
        /// Returns the note from the musical alphabet at the given index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Note GetNoteByIndex(int index)
        {
            index = index.RollingRange(6);
            var noteLetter = Theory.MusicalAlphabet.KeysList[index];
            var semitones = Theory.MusicalAlphabet[index];
            return new Note(noteLetter, semitones);
        }
    }
}