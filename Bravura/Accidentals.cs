using System.Collections.Generic;

namespace Bravura
{
    public struct Accidentals
    {
        public static readonly Accidental DoubleFlat = new Accidental(-2, "♭♭", "♭♭", "bb");
        public static readonly Accidental Flat = new Accidental(-1, "♭", "♭", "b");
        public static readonly Accidental Natural = new Accidental(0, "", "♮", "");
        public static readonly Accidental Sharp = new Accidental(1, "♯", "♯", "#");
        public static readonly Accidental DoubleSharp = new Accidental(2, "♯♯", "♯♯", "##");

        public static List<Accidental> AllAccidentals = new List<Accidental>
        {
            DoubleFlat,
            Flat,
            Natural,
            Sharp,
            DoubleSharp,
        };
    }
}