using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura
{
    public static partial class Theory
    {
        public static readonly Pitch CDoubleFlat = new Pitch(C, DoubleFlat);
        public static readonly Pitch DDoubleFlat = new Pitch(D, DoubleFlat);
        public static readonly Pitch EDoubleFlat = new Pitch(E, DoubleFlat);
        public static readonly Pitch FDoubleFlat = new Pitch(F, DoubleFlat);
        public static readonly Pitch GDoubleFlat = new Pitch(G, DoubleFlat);
        public static readonly Pitch ADoubleFlat = new Pitch(A, DoubleFlat);
        public static readonly Pitch BDoubleFlat = new Pitch(B, DoubleFlat);

        public static readonly Pitch CFlat = new Pitch(C, Flat);
        public static readonly Pitch DFlat = new Pitch(D, Flat);
        public static readonly Pitch EFlat = new Pitch(E, Flat);
        public static readonly Pitch FFlat = new Pitch(F, Flat);
        public static readonly Pitch GFlat = new Pitch(G, Flat);
        public static readonly Pitch AFlat = new Pitch(A, Flat);
        public static readonly Pitch BFlat = new Pitch(B, Flat);

        public static readonly Pitch CNatural = new Pitch(C, Natural);
        public static readonly Pitch DNatural = new Pitch(D, Natural);
        public static readonly Pitch ENatural = new Pitch(E, Natural);
        public static readonly Pitch FNatural = new Pitch(F, Natural);
        public static readonly Pitch GNatural = new Pitch(G, Natural);
        public static readonly Pitch ANatural = new Pitch(A, Natural);
        public static readonly Pitch BNatural = new Pitch(B, Natural);

        public static readonly Pitch CSharp = new Pitch(C, Sharp);
        public static readonly Pitch DSharp = new Pitch(D, Sharp);
        public static readonly Pitch ESharp = new Pitch(E, Sharp);
        public static readonly Pitch FSharp = new Pitch(F, Sharp);
        public static readonly Pitch GSharp = new Pitch(G, Sharp);
        public static readonly Pitch ASharp = new Pitch(A, Sharp);
        public static readonly Pitch BSharp = new Pitch(B, Sharp);

        public static readonly Pitch CDoubleSharp = new Pitch(C, DoubleSharp);
        public static readonly Pitch DDoubleSharp = new Pitch(D, DoubleSharp);
        public static readonly Pitch EDoubleSharp = new Pitch(E, DoubleSharp);
        public static readonly Pitch FDoubleSharp = new Pitch(F, DoubleSharp);
        public static readonly Pitch GDoubleSharp = new Pitch(G, DoubleSharp);
        public static readonly Pitch ADoubleSharp = new Pitch(A, DoubleSharp);
        public static readonly Pitch BDoubleSharp = new Pitch(B, DoubleSharp);

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