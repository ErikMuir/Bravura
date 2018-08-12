using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura
{
    public static class Pitches
    {
        public static readonly Pitch CDoubleFlat = new Pitch(Notes.C, Accidentals.DoubleFlat);
        public static readonly Pitch DDoubleFlat = new Pitch(Notes.D, Accidentals.DoubleFlat);
        public static readonly Pitch EDoubleFlat = new Pitch(Notes.E, Accidentals.DoubleFlat);
        public static readonly Pitch FDoubleFlat = new Pitch(Notes.F, Accidentals.DoubleFlat);
        public static readonly Pitch GDoubleFlat = new Pitch(Notes.G, Accidentals.DoubleFlat);
        public static readonly Pitch ADoubleFlat = new Pitch(Notes.A, Accidentals.DoubleFlat);
        public static readonly Pitch BDoubleFlat = new Pitch(Notes.B, Accidentals.DoubleFlat);

        public static readonly Pitch CFlat = new Pitch(Notes.C, Accidentals.Flat);
        public static readonly Pitch DFlat = new Pitch(Notes.D, Accidentals.Flat);
        public static readonly Pitch EFlat = new Pitch(Notes.E, Accidentals.Flat);
        public static readonly Pitch FFlat = new Pitch(Notes.F, Accidentals.Flat);
        public static readonly Pitch GFlat = new Pitch(Notes.G, Accidentals.Flat);
        public static readonly Pitch AFlat = new Pitch(Notes.A, Accidentals.Flat);
        public static readonly Pitch BFlat = new Pitch(Notes.B, Accidentals.Flat);

        public static readonly Pitch CNatural = new Pitch(Notes.C, Accidentals.Natural);
        public static readonly Pitch DNatural = new Pitch(Notes.D, Accidentals.Natural);
        public static readonly Pitch ENatural = new Pitch(Notes.E, Accidentals.Natural);
        public static readonly Pitch FNatural = new Pitch(Notes.F, Accidentals.Natural);
        public static readonly Pitch GNatural = new Pitch(Notes.G, Accidentals.Natural);
        public static readonly Pitch ANatural = new Pitch(Notes.A, Accidentals.Natural);
        public static readonly Pitch BNatural = new Pitch(Notes.B, Accidentals.Natural);

        public static readonly Pitch CSharp = new Pitch(Notes.C, Accidentals.Sharp);
        public static readonly Pitch DSharp = new Pitch(Notes.D, Accidentals.Sharp);
        public static readonly Pitch ESharp = new Pitch(Notes.E, Accidentals.Sharp);
        public static readonly Pitch FSharp = new Pitch(Notes.F, Accidentals.Sharp);
        public static readonly Pitch GSharp = new Pitch(Notes.G, Accidentals.Sharp);
        public static readonly Pitch ASharp = new Pitch(Notes.A, Accidentals.Sharp);
        public static readonly Pitch BSharp = new Pitch(Notes.B, Accidentals.Sharp);

        public static readonly Pitch CDoubleSharp = new Pitch(Notes.C, Accidentals.DoubleSharp);
        public static readonly Pitch DDoubleSharp = new Pitch(Notes.D, Accidentals.DoubleSharp);
        public static readonly Pitch EDoubleSharp = new Pitch(Notes.E, Accidentals.DoubleSharp);
        public static readonly Pitch FDoubleSharp = new Pitch(Notes.F, Accidentals.DoubleSharp);
        public static readonly Pitch GDoubleSharp = new Pitch(Notes.G, Accidentals.DoubleSharp);
        public static readonly Pitch ADoubleSharp = new Pitch(Notes.A, Accidentals.DoubleSharp);
        public static readonly Pitch BDoubleSharp = new Pitch(Notes.B, Accidentals.DoubleSharp);

        public static readonly ReadOnlyCollection<Pitch> DoubleFlats =
            new List<Pitch>
            {
                CDoubleFlat,
                DDoubleFlat,
                EDoubleFlat,
                FDoubleFlat,
                GDoubleFlat,
                ADoubleFlat,
                BDoubleFlat,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> Flats =
            new List<Pitch>
            {
                CFlat,
                DFlat,
                EFlat,
                FFlat,
                GFlat,
                AFlat,
                BFlat,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> Naturals =
            new List<Pitch>
            {
                CNatural,
                DNatural,
                ENatural,
                FNatural,
                GNatural,
                ANatural,
                BNatural,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> Sharps =
            new List<Pitch>
            {
                CSharp,
                DSharp,
                ESharp,
                FSharp,
                GSharp,
                ASharp,
                BSharp,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> DoubleSharps =
            new List<Pitch>
            {
                CDoubleSharp,
                DDoubleSharp,
                EDoubleSharp,
                FDoubleSharp,
                GDoubleSharp,
                ADoubleSharp,
                BDoubleSharp,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> SignatureFlats =
            new List<Pitch>
            {
                BFlat,
                EFlat,
                AFlat,
                DFlat,
                GFlat,
                CFlat,
                FFlat,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> SignatureSharps =
            new List<Pitch>
            {
                FSharp,
                CSharp,
                GSharp,
                DSharp,
                ASharp,
                ESharp,
                BSharp,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> SignatureAccidentals =
            new List<Pitch>
            {
                BFlat,
                EFlat,
                AFlat,
                DFlat,
                GFlat,
                CFlat,
                FFlat,
                FSharp,
                CSharp,
                GSharp,
                DSharp,
                ASharp,
                ESharp,
                BSharp,
            }.AsReadOnly();

        public static readonly ReadOnlyCollection<Pitch> AllPitches =
            new List<Pitch>
            {
                CDoubleFlat,
                DDoubleFlat,
                EDoubleFlat,
                FDoubleFlat,
                GDoubleFlat,
                ADoubleFlat,
                BDoubleFlat,
                CFlat,
                DFlat,
                EFlat,
                FFlat,
                GFlat,
                AFlat,
                BFlat,
                CNatural,
                DNatural,
                ENatural,
                FNatural,
                GNatural,
                ANatural,
                BNatural,
                CSharp,
                DSharp,
                ESharp,
                FSharp,
                GSharp,
                ASharp,
                BSharp,
                CDoubleSharp,
                DDoubleSharp,
                EDoubleSharp,
                FDoubleSharp,
                GDoubleSharp,
                ADoubleSharp,
                BDoubleSharp,
            }.AsReadOnly();
    }
}