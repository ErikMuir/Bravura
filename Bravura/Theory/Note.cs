using System;
using System.Collections.Generic;

namespace Bravura.Theory
{
    public struct Note
    {
        public char Letter { get; }
        public int SemitonesAboveC { get; }

        internal Note(char letter, int semitonesAboveC)
        {
            Letter = letter;
            SemitonesAboveC = semitonesAboveC;
        }

        public KeyValuePair<char, int> KeyValuePair => new KeyValuePair<char, int>(Letter, SemitonesAboveC);

        #region -- Equality Operator Overrides --

        public static bool operator ==(Note a, Note b)
            => a.SemitonesAboveC == b.SemitonesAboveC;

        public static bool operator !=(Note a, Note b)
            => !(a == b);

        public override bool Equals(object obj)
        {
            if (!(obj is Note)) return false;
            var note = (Note)obj;
            return SemitonesAboveC == note.SemitonesAboveC;
        }

        public override int GetHashCode()
            => HashCode.Combine(SemitonesAboveC);

        #endregion
    }
}