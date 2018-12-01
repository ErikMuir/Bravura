using Bravura.Extensions;

namespace Bravura
{
    public static partial class Tonality
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
                var noteLetter = MusicalAlphabet.KeysList[index];
                var semitones = MusicalAlphabet[index];
                return new Note(noteLetter, semitones);
            }
        }
    }
}