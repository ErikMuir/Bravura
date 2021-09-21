using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality
{
    public static class Keys
    {
        static Keys()
        {
            CMajor = new Key(Pitches.CNatural, Modality.Major);
            CSharpMajor = new Key(Pitches.CSharp, Modality.Major);
            DFlatMajor = new Key(Pitches.DFlat, Modality.Major);
            DMajor = new Key(Pitches.DNatural, Modality.Major);
            EFlatMajor = new Key(Pitches.EFlat, Modality.Major);
            EMajor = new Key(Pitches.ENatural, Modality.Major);
            FMajor = new Key(Pitches.FNatural, Modality.Major);
            FSharpMajor = new Key(Pitches.FSharp, Modality.Major);
            GFlatMajor = new Key(Pitches.GFlat, Modality.Major);
            GMajor = new Key(Pitches.GNatural, Modality.Major);
            AFlatMajor = new Key(Pitches.AFlat, Modality.Major);
            AMajor = new Key(Pitches.ANatural, Modality.Major);
            BFlatMajor = new Key(Pitches.BFlat, Modality.Major);
            BMajor = new Key(Pitches.BNatural, Modality.Major);
            CFlatMajor = new Key(Pitches.CFlat, Modality.Major);

            CMinor = new Key(Pitches.CNatural, Modality.Minor);
            CSharpMinor = new Key(Pitches.CSharp, Modality.Minor);
            DMinor = new Key(Pitches.DNatural, Modality.Minor);
            DSharpMinor = new Key(Pitches.DSharp, Modality.Minor);
            EFlatMinor = new Key(Pitches.EFlat, Modality.Minor);
            EMinor = new Key(Pitches.ENatural, Modality.Minor);
            FMinor = new Key(Pitches.FNatural, Modality.Minor);
            FSharpMinor = new Key(Pitches.FSharp, Modality.Minor);
            GMinor = new Key(Pitches.GNatural, Modality.Minor);
            GSharpMinor = new Key(Pitches.GSharp, Modality.Minor);
            AFlatMinor = new Key(Pitches.AFlat, Modality.Minor);
            AMinor = new Key(Pitches.ANatural, Modality.Minor);
            ASharpMinor = new Key(Pitches.ASharp, Modality.Minor);
            BFlatMinor = new Key(Pitches.BFlat, Modality.Minor);
            BMinor = new Key(Pitches.BNatural, Modality.Minor);

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
