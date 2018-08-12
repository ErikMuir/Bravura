using System.Collections.Generic;
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
            var noteLetter = Notes.MusicalAlphabet.KeysList[index];
            var semitones = Notes.MusicalAlphabet[index];
            var keyValuePair = new KeyValuePair<char, int>(noteLetter, semitones);
            return keyValuePair.GetNote();
        }
    }
}