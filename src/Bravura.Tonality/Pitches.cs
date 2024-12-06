using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality;

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

    public static Pitch CDoubleFlat { get; }
    public static Pitch DDoubleFlat { get; }
    public static Pitch EDoubleFlat { get; }
    public static Pitch FDoubleFlat { get; }
    public static Pitch GDoubleFlat { get; }
    public static Pitch ADoubleFlat { get; }
    public static Pitch BDoubleFlat { get; }

    public static Pitch CFlat { get; }
    public static Pitch DFlat { get; }
    public static Pitch EFlat { get; }
    public static Pitch FFlat { get; }
    public static Pitch GFlat { get; }
    public static Pitch AFlat { get; }
    public static Pitch BFlat { get; }

    public static Pitch CNatural { get; }
    public static Pitch DNatural { get; }
    public static Pitch ENatural { get; }
    public static Pitch FNatural { get; }
    public static Pitch GNatural { get; }
    public static Pitch ANatural { get; }
    public static Pitch BNatural { get; }

    public static Pitch CSharp { get; }
    public static Pitch DSharp { get; }
    public static Pitch ESharp { get; }
    public static Pitch FSharp { get; }
    public static Pitch GSharp { get; }
    public static Pitch ASharp { get; }
    public static Pitch BSharp { get; }

    public static Pitch CDoubleSharp { get; }
    public static Pitch DDoubleSharp { get; }
    public static Pitch EDoubleSharp { get; }
    public static Pitch FDoubleSharp { get; }
    public static Pitch GDoubleSharp { get; }
    public static Pitch ADoubleSharp { get; }
    public static Pitch BDoubleSharp { get; }

    public static ReadOnlyCollection<Pitch> DoubleFlats { get; }
    public static ReadOnlyCollection<Pitch> Flats { get; }
    public static ReadOnlyCollection<Pitch> Naturals { get; }
    public static ReadOnlyCollection<Pitch> Sharps { get; }
    public static ReadOnlyCollection<Pitch> DoubleSharps { get; }
    public static ReadOnlyCollection<Pitch> SignatureFlats { get; }
    public static ReadOnlyCollection<Pitch> SignatureSharps { get; }
    public static ReadOnlyCollection<Pitch> SignatureAccidentals { get; }
    public static ReadOnlyCollection<Pitch> AllPitches { get; }
}
