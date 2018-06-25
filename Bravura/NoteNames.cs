using System.Collections.Generic;

namespace Bravura
{
    public struct NoteNames
    {
        public static readonly NoteName C = new NoteName(0, 0, "C", Accidentals.Natural, true, false);
        public static readonly NoteName D = new NoteName(1, 2, "D", Accidentals.Sharp, false, false);
        public static readonly NoteName E = new NoteName(2, 4, "E", Accidentals.Sharp, false, true);
        public static readonly NoteName F = new NoteName(3, 5, "F", Accidentals.Flat, true, false);
        public static readonly NoteName G = new NoteName(4, 7, "G", Accidentals.Sharp, false, false);
        public static readonly NoteName A = new NoteName(5, 9, "A", Accidentals.Sharp, false, false);
        public static readonly NoteName B = new NoteName(6, 11, "B", Accidentals.Sharp, false, true);

        public static List<NoteName> AllNotes = new List<NoteName> { C, D, E, F, G, A, B };
    }
}