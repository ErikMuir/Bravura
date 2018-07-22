using System.Collections.Generic;

namespace Bravura
{
    public struct NoteNames
    {
        public static readonly NoteName C = new NoteName(0, 0, "C", true, false);
        public static readonly NoteName D = new NoteName(1, 2, "D", false, false);
        public static readonly NoteName E = new NoteName(2, 4, "E", false, true);
        public static readonly NoteName F = new NoteName(3, 5, "F", true, false);
        public static readonly NoteName G = new NoteName(4, 7, "G", false, false);
        public static readonly NoteName A = new NoteName(5, 9, "A", false, false);
        public static readonly NoteName B = new NoteName(6, 11, "B", false, true);

        public static List<NoteName> AllNotes = new List<NoteName> { C, D, E, F, G, A, B };
    }
}