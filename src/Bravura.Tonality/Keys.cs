using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality;

public static class Keys
{
    public static readonly Key CMajor = new(Pitches.CNatural, Modality.Major);
    public static readonly Key CSharpMajor = new(Pitches.CSharp, Modality.Major);
    public static readonly Key DFlatMajor = new(Pitches.DFlat, Modality.Major);
    public static readonly Key DMajor = new(Pitches.DNatural, Modality.Major);
    public static readonly Key EFlatMajor = new(Pitches.EFlat, Modality.Major);
    public static readonly Key EMajor = new(Pitches.ENatural, Modality.Major);
    public static readonly Key FMajor = new(Pitches.FNatural, Modality.Major);
    public static readonly Key FSharpMajor = new(Pitches.FSharp, Modality.Major);
    public static readonly Key GFlatMajor = new(Pitches.GFlat, Modality.Major);
    public static readonly Key GMajor = new(Pitches.GNatural, Modality.Major);
    public static readonly Key AFlatMajor = new(Pitches.AFlat, Modality.Major);
    public static readonly Key AMajor = new(Pitches.ANatural, Modality.Major);
    public static readonly Key BFlatMajor = new(Pitches.BFlat, Modality.Major);
    public static readonly Key BMajor = new(Pitches.BNatural, Modality.Major);
    public static readonly Key CFlatMajor = new(Pitches.CFlat, Modality.Major);

    public static readonly Key CMinor = new(Pitches.CNatural, Modality.Minor);
    public static readonly Key CSharpMinor = new(Pitches.CSharp, Modality.Minor);
    public static readonly Key DMinor = new(Pitches.DNatural, Modality.Minor);
    public static readonly Key DSharpMinor = new(Pitches.DSharp, Modality.Minor);
    public static readonly Key EFlatMinor = new(Pitches.EFlat, Modality.Minor);
    public static readonly Key EMinor = new(Pitches.ENatural, Modality.Minor);
    public static readonly Key FMinor = new(Pitches.FNatural, Modality.Minor);
    public static readonly Key FSharpMinor = new(Pitches.FSharp, Modality.Minor);
    public static readonly Key GMinor = new(Pitches.GNatural, Modality.Minor);
    public static readonly Key GSharpMinor = new(Pitches.GSharp, Modality.Minor);
    public static readonly Key AFlatMinor = new(Pitches.AFlat, Modality.Minor);
    public static readonly Key AMinor = new(Pitches.ANatural, Modality.Minor);
    public static readonly Key ASharpMinor = new(Pitches.ASharp, Modality.Minor);
    public static readonly Key BFlatMinor = new(Pitches.BFlat, Modality.Minor);
    public static readonly Key BMinor = new(Pitches.BNatural, Modality.Minor);

    public static readonly ReadOnlyCollection<Key> MajorKeys = new List<Key>
    {
        CMajor,
        CSharpMajor,
        DFlatMajor,
        DMajor,
        EFlatMajor,
        EMajor,
        FMajor,
        FSharpMajor,
        GFlatMajor,
        GMajor,
        AFlatMajor,
        AMajor,
        BFlatMajor,
        BMajor,
        CFlatMajor,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Key> MinorKeys = new List<Key>
    {
        CMinor,
        CSharpMinor,
        DMinor,
        DSharpMinor,
        EFlatMinor,
        EMinor,
        FMinor,
        FSharpMinor,
        GMinor,
        GSharpMinor,
        AFlatMinor,
        AMinor,
        ASharpMinor,
        BFlatMinor,
        BMinor,
    }.AsReadOnly();

    public static readonly ReadOnlyCollection<Key> AllKeys = new List<Key>
    {
        CMajor,
        CSharpMajor,
        DFlatMajor,
        DMajor,
        EFlatMajor,
        EMajor,
        FMajor,
        FSharpMajor,
        GFlatMajor,
        GMajor,
        AFlatMajor,
        AMajor,
        BFlatMajor,
        BMajor,
        CFlatMajor,
        CMinor,
        CSharpMinor,
        DMinor,
        DSharpMinor,
        EFlatMinor,
        EMinor,
        FMinor,
        FSharpMinor,
        GMinor,
        GSharpMinor,
        AFlatMinor,
        AMinor,
        ASharpMinor,
        BFlatMinor,
        BMinor,
    }.AsReadOnly();
}
