using System;
using System.Collections.Generic;
using Bravura.Constants;

namespace Bravura
{
    public static partial class Theory
    {
        public class Note
        {
            #region -- Constructor --

            internal Note(char letter, short semitonesAboveC)
            {
                Letter = letter;
                SemitonesAboveC = semitonesAboveC;

                KeyValuePair = new KeyValuePair<char, short>(letter, semitonesAboveC);
            }

            #endregion

            #region -- Properties --

            public char Letter { get; }
            public short SemitonesAboveC { get; }
            public KeyValuePair<char, short> KeyValuePair { get; }

            #endregion

            #region -- Equality Methods --

            // TODO : Are these even needed? All instances are static.

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

        #region -- Notes --

        public static Note C { get; private set; }
        public static Note D { get; private set; }
        public static Note E { get; private set; }
        public static Note F { get; private set; }
        public static Note G { get; private set; }
        public static Note A { get; private set; }
        public static Note B { get; private set; }
        public static ReadOnlyOrderedDictionary<char, short> MusicalAlphabet { get; private set; }

        #endregion 

        static partial void SetNotes()
        {
            C = new Note(NoteLetters.C, NoteValues.C);
            D = new Note(NoteLetters.D, NoteValues.D);
            E = new Note(NoteLetters.E, NoteValues.E);
            F = new Note(NoteLetters.F, NoteValues.F);
            G = new Note(NoteLetters.G, NoteValues.G);
            A = new Note(NoteLetters.A, NoteValues.A);
            B = new Note(NoteLetters.B, NoteValues.B);

            MusicalAlphabet = new ReadOnlyOrderedDictionary<char, short>
            {
                C.KeyValuePair,
                D.KeyValuePair,
                E.KeyValuePair,
                F.KeyValuePair,
                G.KeyValuePair,
                A.KeyValuePair,
                B.KeyValuePair,
            };
        }
    }
}