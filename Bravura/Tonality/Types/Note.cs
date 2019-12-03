using System.Collections.Generic;

namespace Bravura
{
    public static partial class Tonality
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
        }
    }
}