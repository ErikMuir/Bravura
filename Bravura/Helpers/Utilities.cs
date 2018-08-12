using System.Collections.Generic;
using Bravura.Extensions;
using Bravura.Theory;

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
            return new KeyValuePair<char, int>(Notes.MusicalAlphabet.KeysList[index], Notes.MusicalAlphabet[index]).GetNote();
        }
    }
}