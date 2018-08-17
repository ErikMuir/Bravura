using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura
{
    public static partial class Theory
    {
        public static Pitch CDoubleFlat { get; private set; }
        public static Pitch DDoubleFlat { get; private set; }
        public static Pitch EDoubleFlat { get; private set; }
        public static Pitch FDoubleFlat { get; private set; }
        public static Pitch GDoubleFlat { get; private set; }
        public static Pitch ADoubleFlat { get; private set; }
        public static Pitch BDoubleFlat { get; private set; }

        public static Pitch CFlat { get; private set; }
        public static Pitch DFlat { get; private set; }
        public static Pitch EFlat { get; private set; }
        public static Pitch FFlat { get; private set; }
        public static Pitch GFlat { get; private set; }
        public static Pitch AFlat { get; private set; }
        public static Pitch BFlat { get; private set; }

        public static Pitch CNatural { get; private set; }
        public static Pitch DNatural { get; private set; }
        public static Pitch ENatural { get; private set; }
        public static Pitch FNatural { get; private set; }
        public static Pitch GNatural { get; private set; }
        public static Pitch ANatural { get; private set; }
        public static Pitch BNatural { get; private set; }

        public static Pitch CSharp { get; private set; }
        public static Pitch DSharp { get; private set; }
        public static Pitch ESharp { get; private set; }
        public static Pitch FSharp { get; private set; }
        public static Pitch GSharp { get; private set; }
        public static Pitch ASharp { get; private set; }
        public static Pitch BSharp { get; private set; }

        public static Pitch CDoubleSharp { get; private set; }
        public static Pitch DDoubleSharp { get; private set; }
        public static Pitch EDoubleSharp { get; private set; }
        public static Pitch FDoubleSharp { get; private set; }
        public static Pitch GDoubleSharp { get; private set; }
        public static Pitch ADoubleSharp { get; private set; }
        public static Pitch BDoubleSharp { get; private set; }

        public static ReadOnlyCollection<Pitch> DoubleFlats { get; private set; }
        public static ReadOnlyCollection<Pitch> Flats { get; private set; }
        public static ReadOnlyCollection<Pitch> Naturals { get; private set; }
        public static ReadOnlyCollection<Pitch> Sharps { get; private set; }
        public static ReadOnlyCollection<Pitch> DoubleSharps { get; private set; }
        public static ReadOnlyCollection<Pitch> SignatureFlats { get; private set; }
        public static ReadOnlyCollection<Pitch> SignatureSharps { get; private set; }
        public static ReadOnlyCollection<Pitch> SignatureAccidentals { get; private set; }
        public static ReadOnlyCollection<Pitch> Pitches { get; private set; }

        private static void SetPitches()
        {
            CDoubleFlat = new Pitch(C, DoubleFlat);
            DDoubleFlat = new Pitch(D, DoubleFlat);
            EDoubleFlat = new Pitch(E, DoubleFlat);
            FDoubleFlat = new Pitch(F, DoubleFlat);
            GDoubleFlat = new Pitch(G, DoubleFlat);
            ADoubleFlat = new Pitch(A, DoubleFlat);
            BDoubleFlat = new Pitch(B, DoubleFlat);

            CFlat = new Pitch(C, Flat);
            DFlat = new Pitch(D, Flat);
            EFlat = new Pitch(E, Flat);
            FFlat = new Pitch(F, Flat);
            GFlat = new Pitch(G, Flat);
            AFlat = new Pitch(A, Flat);
            BFlat = new Pitch(B, Flat);

            CNatural = new Pitch(C, Natural);
            DNatural = new Pitch(D, Natural);
            ENatural = new Pitch(E, Natural);
            FNatural = new Pitch(F, Natural);
            GNatural = new Pitch(G, Natural);
            ANatural = new Pitch(A, Natural);
            BNatural = new Pitch(B, Natural);

            CSharp = new Pitch(C, Sharp);
            DSharp = new Pitch(D, Sharp);
            ESharp = new Pitch(E, Sharp);
            FSharp = new Pitch(F, Sharp);
            GSharp = new Pitch(G, Sharp);
            ASharp = new Pitch(A, Sharp);
            BSharp = new Pitch(B, Sharp);

            CDoubleSharp = new Pitch(C, DoubleSharp);
            DDoubleSharp = new Pitch(D, DoubleSharp);
            EDoubleSharp = new Pitch(E, DoubleSharp);
            FDoubleSharp = new Pitch(F, DoubleSharp);
            GDoubleSharp = new Pitch(G, DoubleSharp);
            ADoubleSharp = new Pitch(A, DoubleSharp);
            BDoubleSharp = new Pitch(B, DoubleSharp);

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

            Pitches = new List<Pitch>
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
}