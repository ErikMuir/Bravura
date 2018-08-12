using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura
{
    public static class Keys
    {
        public static Key CMajor = new Key(Pitches.CNatural, KeyMode.Major);
        public static Key CSharpMajor = new Key(Pitches.CSharp, KeyMode.Major);
        public static Key DFlatMajor = new Key(Pitches.DFlat, KeyMode.Major);
        public static Key DMajor = new Key(Pitches.DNatural, KeyMode.Major);
        public static Key EFlatMajor = new Key(Pitches.EFlat, KeyMode.Major);
        public static Key EMajor = new Key(Pitches.ENatural, KeyMode.Major);
        public static Key FMajor = new Key(Pitches.FNatural, KeyMode.Major);
        public static Key FSharpMajor = new Key(Pitches.FSharp, KeyMode.Major);
        public static Key GFlatMajor = new Key(Pitches.GFlat, KeyMode.Major);
        public static Key GMajor = new Key(Pitches.GNatural, KeyMode.Major);
        public static Key AFlatMajor = new Key(Pitches.AFlat, KeyMode.Major);
        public static Key AMajor = new Key(Pitches.ANatural, KeyMode.Major);
        public static Key BFlatMajor = new Key(Pitches.BFlat, KeyMode.Major);
        public static Key BMajor = new Key(Pitches.BNatural, KeyMode.Major);
        public static Key CFlatMajor = new Key(Pitches.CFlat, KeyMode.Major);

        public static Key CMinor = new Key(Pitches.CNatural, KeyMode.Minor);
        public static Key CSharpMinor = new Key(Pitches.CSharp, KeyMode.Minor);
        public static Key DMinor = new Key(Pitches.DNatural, KeyMode.Minor);
        public static Key DSharpMinor = new Key(Pitches.DSharp, KeyMode.Minor);
        public static Key EFlatMinor = new Key(Pitches.EFlat, KeyMode.Minor);
        public static Key EMinor = new Key(Pitches.ENatural, KeyMode.Minor);
        public static Key FMinor = new Key(Pitches.FNatural, KeyMode.Minor);
        public static Key FSharpMinor = new Key(Pitches.FSharp, KeyMode.Minor);
        public static Key GMinor = new Key(Pitches.GNatural, KeyMode.Minor);
        public static Key GSharpMinor = new Key(Pitches.GSharp, KeyMode.Minor);
        public static Key AFlatMinor = new Key(Pitches.AFlat, KeyMode.Minor);
        public static Key AMinor = new Key(Pitches.ANatural, KeyMode.Minor);
        public static Key ASharpMinor = new Key(Pitches.ASharp, KeyMode.Minor);
        public static Key BFlatMinor = new Key(Pitches.BFlat, KeyMode.Minor);
        public static Key BMinor = new Key(Pitches.BNatural, KeyMode.Minor);

        public static ReadOnlyCollection<Key> MajorKeys =
            new List<Key>
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

        public static ReadOnlyCollection<Key> MinorKeys =
            new List<Key>
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

        public static ReadOnlyCollection<Key> AllKeys =
            new List<Key>
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
}