using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality
{
    public static class Keys
    {
        static Keys()
        {
            CMajor = new Key(Pitches.CNatural, Tonality.Major);
            CSharpMajor = new Key(Pitches.CSharp, Tonality.Major);
            DFlatMajor = new Key(Pitches.DFlat, Tonality.Major);
            DMajor = new Key(Pitches.DNatural, Tonality.Major);
            EFlatMajor = new Key(Pitches.EFlat, Tonality.Major);
            EMajor = new Key(Pitches.ENatural, Tonality.Major);
            FMajor = new Key(Pitches.FNatural, Tonality.Major);
            FSharpMajor = new Key(Pitches.FSharp, Tonality.Major);
            GFlatMajor = new Key(Pitches.GFlat, Tonality.Major);
            GMajor = new Key(Pitches.GNatural, Tonality.Major);
            AFlatMajor = new Key(Pitches.AFlat, Tonality.Major);
            AMajor = new Key(Pitches.ANatural, Tonality.Major);
            BFlatMajor = new Key(Pitches.BFlat, Tonality.Major);
            BMajor = new Key(Pitches.BNatural, Tonality.Major);
            CFlatMajor = new Key(Pitches.CFlat, Tonality.Major);

            CMinor = new Key(Pitches.CNatural, Tonality.Minor);
            CSharpMinor = new Key(Pitches.CSharp, Tonality.Minor);
            DMinor = new Key(Pitches.DNatural, Tonality.Minor);
            DSharpMinor = new Key(Pitches.DSharp, Tonality.Minor);
            EFlatMinor = new Key(Pitches.EFlat, Tonality.Minor);
            EMinor = new Key(Pitches.ENatural, Tonality.Minor);
            FMinor = new Key(Pitches.FNatural, Tonality.Minor);
            FSharpMinor = new Key(Pitches.FSharp, Tonality.Minor);
            GMinor = new Key(Pitches.GNatural, Tonality.Minor);
            GSharpMinor = new Key(Pitches.GSharp, Tonality.Minor);
            AFlatMinor = new Key(Pitches.AFlat, Tonality.Minor);
            AMinor = new Key(Pitches.ANatural, Tonality.Minor);
            ASharpMinor = new Key(Pitches.ASharp, Tonality.Minor);
            BFlatMinor = new Key(Pitches.BFlat, Tonality.Minor);
            BMinor = new Key(Pitches.BNatural, Tonality.Minor);

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