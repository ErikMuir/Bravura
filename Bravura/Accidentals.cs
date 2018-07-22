using System.Collections.Generic;

namespace Bravura
{
    public struct Accidentals
    {
        public static readonly Accidental DoubleFlat = new Accidental(-2, "Double Flat", "♭♭", "♭♭", "bb");
        public static readonly Accidental Flat = new Accidental(-1, "Flat", "♭", "♭", "b");
        public static readonly Accidental Natural = new Accidental(0, "Natural", "", "♮", "");
        public static readonly Accidental Sharp = new Accidental(1, "Sharp", "♯", "♯", "#");
        public static readonly Accidental DoubleSharp = new Accidental(2, "Double Sharp", "♯♯", "♯♯", "##");

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