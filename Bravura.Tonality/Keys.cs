using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality
{
    public static class Keys
    {
        static Keys()
        {
            CMajor = new Key(Pitches.CNatural, KeyMode.Major);
            CSharpMajor = new Key(Pitches.CSharp, KeyMode.Major);
            DFlatMajor = new Key(Pitches.DFlat, KeyMode.Major);
            DMajor = new Key(Pitches.DNatural, KeyMode.Major);
            EFlatMajor = new Key(Pitches.EFlat, KeyMode.Major);
            EMajor = new Key(Pitches.ENatural, KeyMode.Major);
            FMajor = new Key(Pitches.FNatural, KeyMode.Major);
            FSharpMajor = new Key(Pitches.FSharp, KeyMode.Major);
            GFlatMajor = new Key(Pitches.GFlat, KeyMode.Major);
            GMajor = new Key(Pitches.GNatural, KeyMode.Major);
            AFlatMajor = new Key(Pitches.AFlat, KeyMode.Major);
            AMajor = new Key(Pitches.ANatural, KeyMode.Major);
            BFlatMajor = new Key(Pitches.BFlat, KeyMode.Major);
            BMajor = new Key(Pitches.BNatural, KeyMode.Major);
            CFlatMajor = new Key(Pitches.CFlat, KeyMode.Major);

            CMinor = new Key(Pitches.CNatural, KeyMode.Minor);
            CSharpMinor = new Key(Pitches.CSharp, KeyMode.Minor);
            DMinor = new Key(Pitches.DNatural, KeyMode.Minor);
            DSharpMinor = new Key(Pitches.DSharp, KeyMode.Minor);
            EFlatMinor = new Key(Pitches.EFlat, KeyMode.Minor);
            EMinor = new Key(Pitches.ENatural, KeyMode.Minor);
            FMinor = new Key(Pitches.FNatural, KeyMode.Minor);
            FSharpMinor = new Key(Pitches.FSharp, KeyMode.Minor);
            GMinor = new Key(Pitches.GNatural, KeyMode.Minor);
            GSharpMinor = new Key(Pitches.GSharp, KeyMode.Minor);
            AFlatMinor = new Key(Pitches.AFlat, KeyMode.Minor);
            AMinor = new Key(Pitches.ANatural, KeyMode.Minor);
            ASharpMinor = new Key(Pitches.ASharp, KeyMode.Minor);
            BFlatMinor = new Key(Pitches.BFlat, KeyMode.Minor);
            BMinor = new Key(Pitches.BNatural, KeyMode.Minor);

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

            AllKeys = new List<Key>
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

        public static Key CMajor { get; }
        public static Key CSharpMajor { get; }
        public static Key DFlatMajor { get; }
        public static Key DMajor { get; }
        public static Key EFlatMajor { get; }
        public static Key EMajor { get; }
        public static Key FMajor { get; }
        public static Key FSharpMajor { get; }
        public static Key GFlatMajor { get; }
        public static Key GMajor { get; }
        public static Key AFlatMajor { get; }
        public static Key AMajor { get; }
        public static Key BFlatMajor { get; }
        public static Key BMajor { get; }
        public static Key CFlatMajor { get; }

        public static Key CMinor { get; }
        public static Key CSharpMinor { get; }
        public static Key DMinor { get; }
        public static Key DSharpMinor { get; }
        public static Key EFlatMinor { get; }
        public static Key EMinor { get; }
        public static Key FMinor { get; }
        public static Key FSharpMinor { get; }
        public static Key GMinor { get; }
        public static Key GSharpMinor { get; }
        public static Key AFlatMinor { get; }
        public static Key AMinor { get; }
        public static Key ASharpMinor { get; }
        public static Key BFlatMinor { get; }
        public static Key BMinor { get; }

        public static ReadOnlyCollection<Key> MajorKeys { get; }
        public static ReadOnlyCollection<Key> MinorKeys { get; }
        public static ReadOnlyCollection<Key> AllKeys { get; }
    }
}