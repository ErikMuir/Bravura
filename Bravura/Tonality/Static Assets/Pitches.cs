using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality
{
    public static class Pitches
    {
        static Pitches()
        {
            CDoubleFlat = new Pitch(Notes.C, Accidentals.DoubleFlat);
            DDoubleFlat = new Pitch(Notes.D, Accidentals.DoubleFlat);
            EDoubleFlat = new Pitch(Notes.E, Accidentals.DoubleFlat);
            FDoubleFlat = new Pitch(Notes.F, Accidentals.DoubleFlat);
            GDoubleFlat = new Pitch(Notes.G, Accidentals.DoubleFlat);
            ADoubleFlat = new Pitch(Notes.A, Accidentals.DoubleFlat);
            BDoubleFlat = new Pitch(Notes.B, Accidentals.DoubleFlat);

            CFlat = new Pitch(Notes.C, Accidentals.Flat);
            DFlat = new Pitch(Notes.D, Accidentals.Flat);
            EFlat = new Pitch(Notes.E, Accidentals.Flat);
            FFlat = new Pitch(Notes.F, Accidentals.Flat);
            GFlat = new Pitch(Notes.G, Accidentals.Flat);
            AFlat = new Pitch(Notes.A, Accidentals.Flat);
            BFlat = new Pitch(Notes.B, Accidentals.Flat);

            CNatural = new Pitch(Notes.C, Accidentals.Natural);
            DNatural = new Pitch(Notes.D, Accidentals.Natural);
            ENatural = new Pitch(Notes.E, Accidentals.Natural);
            FNatural = new Pitch(Notes.F, Accidentals.Natural);
            GNatural = new Pitch(Notes.G, Accidentals.Natural);
            ANatural = new Pitch(Notes.A, Accidentals.Natural);
            BNatural = new Pitch(Notes.B, Accidentals.Natural);

            CSharp = new Pitch(Notes.C, Accidentals.Sharp);
            DSharp = new Pitch(Notes.D, Accidentals.Sharp);
            ESharp = new Pitch(Notes.E, Accidentals.Sharp);
            FSharp = new Pitch(Notes.F, Accidentals.Sharp);
            GSharp = new Pitch(Notes.G, Accidentals.Sharp);
            ASharp = new Pitch(Notes.A, Accidentals.Sharp);
            BSharp = new Pitch(Notes.B, Accidentals.Sharp);

            CDoubleSharp = new Pitch(Notes.C, Accidentals.DoubleSharp);
            DDoubleSharp = new Pitch(Notes.D, Accidentals.DoubleSharp);
            EDoubleSharp = new Pitch(Notes.E, Accidentals.DoubleSharp);
            FDoubleSharp = new Pitch(Notes.F, Accidentals.DoubleSharp);
            GDoubleSharp = new Pitch(Notes.G, Accidentals.DoubleSharp);
            ADoubleSharp = new Pitch(Notes.A, Accidentals.DoubleSharp);
            BDoubleSharp = new Pitch(Notes.B, Accidentals.DoubleSharp);

            DoubleFlats = new List<Pitch>
            {
                CDoubleFlat,
                DDoubleFlat,
                EDoubleFlat,
                FDoubleFlat,
                GDoubleFlat,
                ADoubleFlat,
                BDoubleFlat,
            }.AsReadOnly();

            Flats = new List<Pitch>
            {
                CFlat,
                DFlat,
                EFlat,
                FFlat,
                GFlat,
                AFlat,
                BFlat,
            }.AsReadOnly();

            Naturals = new List<Pitch>
            {
                CNatural,
                DNatural,
                ENatural,
                FNatural,
                GNatural,
                ANatural,
                BNatural,
            }.AsReadOnly();

            Sharps = new List<Pitch>
            {
                CSharp,
                DSharp,
                ESharp,
                FSharp,
                GSharp,
                ASharp,
                BSharp,
            }.AsReadOnly();

            DoubleSharps = new List<Pitch>
            {
                CDoubleSharp,
                DDoubleSharp,
                EDoubleSharp,
                FDoubleSharp,
                GDoubleSharp,
                ADoubleSharp,
                BDoubleSharp,
            }.AsReadOnly();

            SignatureFlats = new List<Pitch>
            {
                BFlat,
                EFlat,
                AFlat,
                DFlat,
                GFlat,
                CFlat,
                FFlat,
            }.AsReadOnly();

            SignatureSharps = new List<Pitch>
            {
                FSharp,
                CSharp,
                GSharp,
                DSharp,
                ASharp,
                ESharp,
                BSharp,
            }.AsReadOnly();

            SignatureAccidentals = new List<Pitch>
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

            AllPitches = new List<Pitch>
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

        public static readonly Pitch CDoubleFlat;
        public static readonly Pitch DDoubleFlat;
        public static readonly Pitch EDoubleFlat;
        public static readonly Pitch FDoubleFlat;
        public static readonly Pitch GDoubleFlat;
        public static readonly Pitch ADoubleFlat;
        public static readonly Pitch BDoubleFlat;

        public static readonly Pitch CFlat;
        public static readonly Pitch DFlat;
        public static readonly Pitch EFlat;
        public static readonly Pitch FFlat;
        public static readonly Pitch GFlat;
        public static readonly Pitch AFlat;
        public static readonly Pitch BFlat;

        public static readonly Pitch CNatural;
        public static readonly Pitch DNatural;
        public static readonly Pitch ENatural;
        public static readonly Pitch FNatural;
        public static readonly Pitch GNatural;
        public static readonly Pitch ANatural;
        public static readonly Pitch BNatural;

        public static readonly Pitch CSharp;
        public static readonly Pitch DSharp;
        public static readonly Pitch ESharp;
        public static readonly Pitch FSharp;
        public static readonly Pitch GSharp;
        public static readonly Pitch ASharp;
        public static readonly Pitch BSharp;

        public static readonly Pitch CDoubleSharp;
        public static readonly Pitch DDoubleSharp;
        public static readonly Pitch EDoubleSharp;
        public static readonly Pitch FDoubleSharp;
        public static readonly Pitch GDoubleSharp;
        public static readonly Pitch ADoubleSharp;
        public static readonly Pitch BDoubleSharp;

        public static readonly ReadOnlyCollection<Pitch> DoubleFlats;
        public static readonly ReadOnlyCollection<Pitch> Flats;
        public static readonly ReadOnlyCollection<Pitch> Naturals;
        public static readonly ReadOnlyCollection<Pitch> Sharps;
        public static readonly ReadOnlyCollection<Pitch> DoubleSharps;
        public static readonly ReadOnlyCollection<Pitch> SignatureFlats;
        public static readonly ReadOnlyCollection<Pitch> SignatureSharps;
        public static readonly ReadOnlyCollection<Pitch> SignatureAccidentals;
        public static readonly ReadOnlyCollection<Pitch> AllPitches;
    }
}