using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura
{
    public static partial class Theory
    {
        public static Key CMajor { get; private set; }
        public static Key CSharpMajor { get; private set; }
        public static Key DFlatMajor { get; private set; }
        public static Key DMajor { get; private set; }
        public static Key EFlatMajor { get; private set; }
        public static Key EMajor { get; private set; }
        public static Key FMajor { get; private set; }
        public static Key FSharpMajor { get; private set; }
        public static Key GFlatMajor { get; private set; }
        public static Key GMajor { get; private set; }
        public static Key AFlatMajor { get; private set; }
        public static Key AMajor { get; private set; }
        public static Key BFlatMajor { get; private set; }
        public static Key BMajor { get; private set; }
        public static Key CFlatMajor { get; private set; }

        public static Key CMinor { get; private set; }
        public static Key CSharpMinor { get; private set; }
        public static Key DMinor { get; private set; }
        public static Key DSharpMinor { get; private set; }
        public static Key EFlatMinor { get; private set; }
        public static Key EMinor { get; private set; }
        public static Key FMinor { get; private set; }
        public static Key FSharpMinor { get; private set; }
        public static Key GMinor { get; private set; }
        public static Key GSharpMinor { get; private set; }
        public static Key AFlatMinor { get; private set; }
        public static Key AMinor { get; private set; }
        public static Key ASharpMinor { get; private set; }
        public static Key BFlatMinor { get; private set; }
        public static Key BMinor { get; private set; }

        public static ReadOnlyCollection<Key> MajorKeys { get; private set; }
        public static ReadOnlyCollection<Key> MinorKeys { get; private set; }
        public static ReadOnlyCollection<Key> Keys { get; private set; }

        private static void SetKeys()
        {
            CMajor = new Key(CNatural, KeyMode.Major);
            CSharpMajor = new Key(CSharp, KeyMode.Major);
            DFlatMajor = new Key(DFlat, KeyMode.Major);
            DMajor = new Key(DNatural, KeyMode.Major);
            EFlatMajor = new Key(EFlat, KeyMode.Major);
            EMajor = new Key(ENatural, KeyMode.Major);
            FMajor = new Key(FNatural, KeyMode.Major);
            FSharpMajor = new Key(FSharp, KeyMode.Major);
            GFlatMajor = new Key(GFlat, KeyMode.Major);
            GMajor = new Key(GNatural, KeyMode.Major);
            AFlatMajor = new Key(AFlat, KeyMode.Major);
            AMajor = new Key(ANatural, KeyMode.Major);
            BFlatMajor = new Key(BFlat, KeyMode.Major);
            BMajor = new Key(BNatural, KeyMode.Major);
            CFlatMajor = new Key(CFlat, KeyMode.Major);

            CMinor = new Key(CNatural, KeyMode.Minor);
            CSharpMinor = new Key(CSharp, KeyMode.Minor);
            DMinor = new Key(DNatural, KeyMode.Minor);
            DSharpMinor = new Key(DSharp, KeyMode.Minor);
            EFlatMinor = new Key(EFlat, KeyMode.Minor);
            EMinor = new Key(ENatural, KeyMode.Minor);
            FMinor = new Key(FNatural, KeyMode.Minor);
            FSharpMinor = new Key(FSharp, KeyMode.Minor);
            GMinor = new Key(GNatural, KeyMode.Minor);
            GSharpMinor = new Key(GSharp, KeyMode.Minor);
            AFlatMinor = new Key(AFlat, KeyMode.Minor);
            AMinor = new Key(ANatural, KeyMode.Minor);
            ASharpMinor = new Key(ASharp, KeyMode.Minor);
            BFlatMinor = new Key(BFlat, KeyMode.Minor);
            BMinor = new Key(BNatural, KeyMode.Minor);

            MajorKeys = new List<Key>
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

            MinorKeys = new List<Key>
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

            Keys = new List<Key>
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
}