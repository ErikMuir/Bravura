using System.Collections.Generic;

namespace Bravura
{
    public struct Pitches
    {
        public static readonly Pitch CDoubleFlat = new Pitch(NoteNames.C, Accidentals.DoubleFlat);
        public static readonly Pitch DDoubleFlat = new Pitch(NoteNames.D, Accidentals.DoubleFlat);
        public static readonly Pitch EDoubleFlat = new Pitch(NoteNames.E, Accidentals.DoubleFlat);
        public static readonly Pitch FDoubleFlat = new Pitch(NoteNames.F, Accidentals.DoubleFlat);
        public static readonly Pitch GDoubleFlat = new Pitch(NoteNames.G, Accidentals.DoubleFlat);
        public static readonly Pitch ADoubleFlat = new Pitch(NoteNames.A, Accidentals.DoubleFlat);
        public static readonly Pitch BDoubleFlat = new Pitch(NoteNames.B, Accidentals.DoubleFlat);

        public static readonly Pitch CFlat = new Pitch(NoteNames.C, Accidentals.Flat);
        public static readonly Pitch DFlat = new Pitch(NoteNames.D, Accidentals.Flat);
        public static readonly Pitch EFlat = new Pitch(NoteNames.E, Accidentals.Flat);
        public static readonly Pitch FFlat = new Pitch(NoteNames.F, Accidentals.Flat);
        public static readonly Pitch GFlat = new Pitch(NoteNames.G, Accidentals.Flat);
        public static readonly Pitch AFlat = new Pitch(NoteNames.A, Accidentals.Flat);
        public static readonly Pitch BFlat = new Pitch(NoteNames.B, Accidentals.Flat);

        public static readonly Pitch CNatural = new Pitch(NoteNames.C, Accidentals.Natural);
        public static readonly Pitch DNatural = new Pitch(NoteNames.D, Accidentals.Natural);
        public static readonly Pitch ENatural = new Pitch(NoteNames.E, Accidentals.Natural);
        public static readonly Pitch FNatural = new Pitch(NoteNames.F, Accidentals.Natural);
        public static readonly Pitch GNatural = new Pitch(NoteNames.G, Accidentals.Natural);
        public static readonly Pitch ANatural = new Pitch(NoteNames.A, Accidentals.Natural);
        public static readonly Pitch BNatural = new Pitch(NoteNames.B, Accidentals.Natural);

        public static readonly Pitch CSharp = new Pitch(NoteNames.C, Accidentals.Sharp);
        public static readonly Pitch DSharp = new Pitch(NoteNames.D, Accidentals.Sharp);
        public static readonly Pitch ESharp = new Pitch(NoteNames.E, Accidentals.Sharp);
        public static readonly Pitch FSharp = new Pitch(NoteNames.F, Accidentals.Sharp);
        public static readonly Pitch GSharp = new Pitch(NoteNames.G, Accidentals.Sharp);
        public static readonly Pitch ASharp = new Pitch(NoteNames.A, Accidentals.Sharp);
        public static readonly Pitch BSharp = new Pitch(NoteNames.B, Accidentals.Sharp);

        public static readonly Pitch CDoubleSharp = new Pitch(NoteNames.C, Accidentals.DoubleSharp);
        public static readonly Pitch DDoubleSharp = new Pitch(NoteNames.D, Accidentals.DoubleSharp);
        public static readonly Pitch EDoubleSharp = new Pitch(NoteNames.E, Accidentals.DoubleSharp);
        public static readonly Pitch FDoubleSharp = new Pitch(NoteNames.F, Accidentals.DoubleSharp);
        public static readonly Pitch GDoubleSharp = new Pitch(NoteNames.G, Accidentals.DoubleSharp);
        public static readonly Pitch ADoubleSharp = new Pitch(NoteNames.A, Accidentals.DoubleSharp);
        public static readonly Pitch BDoubleSharp = new Pitch(NoteNames.B, Accidentals.DoubleSharp);

        public static readonly List<Pitch> DoubleFlats = new List<Pitch>
        {
            CDoubleFlat, DDoubleFlat, EDoubleFlat, FDoubleFlat, GDoubleFlat, ADoubleFlat, BDoubleFlat, 
        };

        public static readonly List<Pitch> Flats = new List<Pitch>
        {
            CFlat, DFlat, EFlat, FFlat, GFlat, AFlat, BFlat, 
        };

        public static readonly List<Pitch> Naturals = new List<Pitch>
        {
            CNatural, DNatural, ENatural, FNatural, GNatural, ANatural, BNatural,
        };

        public static readonly List<Pitch> Sharps = new List<Pitch>
        {
            CSharp, DSharp, ESharp, FSharp, GSharp, ASharp, BSharp,
        };

        public static readonly List<Pitch> DoubleSharps = new List<Pitch>
        {
            CDoubleSharp, DDoubleSharp, EDoubleSharp, FDoubleSharp, GDoubleSharp, ADoubleSharp, BDoubleSharp,
        };

        public static readonly List<Pitch> SignatureFlats = new List<Pitch>
        {
            BFlat, EFlat, AFlat, DFlat, GFlat, CFlat, FFlat,
        };

        public static readonly List<Pitch> SignatureSharps = new List<Pitch>
        {
            FSharp, CSharp, GSharp, DSharp, ASharp, ESharp, BSharp,
        };

        public static readonly List<Pitch> SignatureAccidentals = new List<Pitch>
        {
            BFlat, EFlat, AFlat, DFlat, GFlat, CFlat, FFlat, FSharp, CSharp, GSharp, DSharp, ASharp, ESharp, BSharp,
        };

        public static readonly List<Pitch> AllPitches = new List<Pitch>
        {
            CDoubleFlat, DDoubleFlat, EDoubleFlat, FDoubleFlat, GDoubleFlat, ADoubleFlat, BDoubleFlat,
            CFlat, DFlat, EFlat, FFlat, GFlat, AFlat, BFlat,
            CNatural, DNatural, ENatural, FNatural, GNatural, ANatural, BNatural, 
            CSharp, DSharp, ESharp, FSharp, GSharp, ASharp, BSharp,
            CDoubleSharp, DDoubleSharp, EDoubleSharp, FDoubleSharp, GDoubleSharp, ADoubleSharp, BDoubleSharp,
        };
    }
}