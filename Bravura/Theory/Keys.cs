using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura
{
    public static partial class Theory
    {
        public static Key CMajor = new Key(CNatural, KeyMode.Major);
        public static Key CSharpMajor = new Key(CSharp, KeyMode.Major);
        public static Key DFlatMajor = new Key(DFlat, KeyMode.Major);
        public static Key DMajor = new Key(DNatural, KeyMode.Major);
        public static Key EFlatMajor = new Key(EFlat, KeyMode.Major);
        public static Key EMajor = new Key(ENatural, KeyMode.Major);
        public static Key FMajor = new Key(FNatural, KeyMode.Major);
        public static Key FSharpMajor = new Key(FSharp, KeyMode.Major);
        public static Key GFlatMajor = new Key(GFlat, KeyMode.Major);
        public static Key GMajor = new Key(GNatural, KeyMode.Major);
        public static Key AFlatMajor = new Key(AFlat, KeyMode.Major);
        public static Key AMajor = new Key(ANatural, KeyMode.Major);
        public static Key BFlatMajor = new Key(BFlat, KeyMode.Major);
        public static Key BMajor = new Key(BNatural, KeyMode.Major);
        public static Key CFlatMajor = new Key(CFlat, KeyMode.Major);

        public static Key CMinor = new Key(CNatural, KeyMode.Minor);
        public static Key CSharpMinor = new Key(CSharp, KeyMode.Minor);
        public static Key DMinor = new Key(DNatural, KeyMode.Minor);
        public static Key DSharpMinor = new Key(DSharp, KeyMode.Minor);
        public static Key EFlatMinor = new Key(EFlat, KeyMode.Minor);
        public static Key EMinor = new Key(ENatural, KeyMode.Minor);
        public static Key FMinor = new Key(FNatural, KeyMode.Minor);
        public static Key FSharpMinor = new Key(FSharp, KeyMode.Minor);
        public static Key GMinor = new Key(GNatural, KeyMode.Minor);
        public static Key GSharpMinor = new Key(GSharp, KeyMode.Minor);
        public static Key AFlatMinor = new Key(AFlat, KeyMode.Minor);
        public static Key AMinor = new Key(ANatural, KeyMode.Minor);
        public static Key ASharpMinor = new Key(ASharp, KeyMode.Minor);
        public static Key BFlatMinor = new Key(BFlat, KeyMode.Minor);
        public static Key BMinor = new Key(BNatural, KeyMode.Minor);

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

        public static ReadOnlyCollection<Key> Keys =
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