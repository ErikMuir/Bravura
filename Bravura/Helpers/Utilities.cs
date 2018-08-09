using System.Collections.Generic;
using Bravura.Extensions;
using Bravura.Theory;

namespace Bravura
{
    public static class Utilities
    {
        public static Note GetNoteByIndex(int index)
        {
            index = index.RollingRange(6);
            return new KeyValuePair<char, int>(Notes.MusicalAlphabet.KeysList[index], Notes.MusicalAlphabet[index]).GetNote();
        }
    }
}