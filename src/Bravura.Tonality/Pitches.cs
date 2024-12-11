using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality;

public static class Pitches
{
    public static readonly Pitch CDoubleFlat = new(Notes.C, Accidentals.DoubleFlat);
    public static readonly Pitch DDoubleFlat = new(Notes.D, Accidentals.DoubleFlat);
    public static readonly Pitch EDoubleFlat = new(Notes.E, Accidentals.DoubleFlat);
    public static readonly Pitch FDoubleFlat = new(Notes.F, Accidentals.DoubleFlat);
    public static readonly Pitch GDoubleFlat = new(Notes.G, Accidentals.DoubleFlat);
    public static readonly Pitch ADoubleFlat = new(Notes.A, Accidentals.DoubleFlat);
    public static readonly Pitch BDoubleFlat = new(Notes.B, Accidentals.DoubleFlat);

    public static readonly Pitch CFlat = new(Notes.C, Accidentals.Flat);
    public static readonly Pitch DFlat = new(Notes.D, Accidentals.Flat);
    public static readonly Pitch EFlat = new(Notes.E, Accidentals.Flat);
    public static readonly Pitch FFlat = new(Notes.F, Accidentals.Flat);
    public static readonly Pitch GFlat = new(Notes.G, Accidentals.Flat);
    public static readonly Pitch AFlat = new(Notes.A, Accidentals.Flat);
    public static readonly Pitch BFlat = new(Notes.B, Accidentals.Flat);

    public static readonly Pitch CNatural = new(Notes.C, Accidentals.Natural);
    public static readonly Pitch DNatural = new(Notes.D, Accidentals.Natural);
    public static readonly Pitch ENatural = new(Notes.E, Accidentals.Natural);
    public static readonly Pitch FNatural = new(Notes.F, Accidentals.Natural);
    public static readonly Pitch GNatural = new(Notes.G, Accidentals.Natural);
    public static readonly Pitch ANatural = new(Notes.A, Accidentals.Natural);
    public static readonly Pitch BNatural = new(Notes.B, Accidentals.Natural);

    public static readonly Pitch CSharp = new(Notes.C, Accidentals.Sharp);
    public static readonly Pitch DSharp = new(Notes.D, Accidentals.Sharp);
    public static readonly Pitch ESharp = new(Notes.E, Accidentals.Sharp);
    public static readonly Pitch FSharp = new(Notes.F, Accidentals.Sharp);
    public static readonly Pitch GSharp = new(Notes.G, Accidentals.Sharp);
    public static readonly Pitch ASharp = new(Notes.A, Accidentals.Sharp);
    public static readonly Pitch BSharp = new(Notes.B, Accidentals.Sharp);

    public static readonly Pitch CDoubleSharp = new(Notes.C, Accidentals.DoubleSharp);
    public static readonly Pitch DDoubleSharp = new(Notes.D, Accidentals.DoubleSharp);
    public static readonly Pitch EDoubleSharp = new(Notes.E, Accidentals.DoubleSharp);
    public static readonly Pitch FDoubleSharp = new(Notes.F, Accidentals.DoubleSharp);
    public static readonly Pitch GDoubleSharp = new(Notes.G, Accidentals.DoubleSharp);
    public static readonly Pitch ADoubleSharp = new(Notes.A, Accidentals.DoubleSharp);
    public static readonly Pitch BDoubleSharp = new(Notes.B, Accidentals.DoubleSharp);

    public static readonly ReadOnlyCollection<Pitch> DoubleFlats = new List<Pitch>
    {
        CDoubleFlat,
        DDoubleFlat,
        EDoubleFlat,
        FDoubleFlat,
        GDoubleFlat,
        ADoubleFlat,
        BDoubleFlat,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Pitch> Flats = new List<Pitch>
    {
        CFlat,
        DFlat,
        EFlat,
        FFlat,
        GFlat,
        AFlat,
        BFlat,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Pitch> Naturals = new List<Pitch>
    {
        CNatural,
        DNatural,
        ENatural,
        FNatural,
        GNatural,
        ANatural,
        BNatural,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Pitch> Sharps = new List<Pitch>
    {
        CSharp,
        DSharp,
        ESharp,
        FSharp,
        GSharp,
        ASharp,
        BSharp,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Pitch> DoubleSharps = new List<Pitch>
    {
        CDoubleSharp,
        DDoubleSharp,
        EDoubleSharp,
        FDoubleSharp,
        GDoubleSharp,
        ADoubleSharp,
        BDoubleSharp,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Pitch> SignatureFlats = new List<Pitch>
    {
        BFlat,
        EFlat,
        AFlat,
        DFlat,
        GFlat,
        CFlat,
        FFlat,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Pitch> SignatureSharps = new List<Pitch>
    {
        FSharp,
        CSharp,
        GSharp,
        DSharp,
        ASharp,
        ESharp,
        BSharp,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Pitch> SignatureAccidentals = new List<Pitch>
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

    public static readonly ReadOnlyCollection<Pitch> AllPitches = new List<Pitch>
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
