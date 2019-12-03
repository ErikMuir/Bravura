using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public static partial class Tonality
    {
        public enum KeyMode { Major, Minor }

        public class Key
        {
            internal Key(Pitch root, KeyMode keyMode)
            {
                Root = root;
                KeyMode = keyMode;

                ActualMode = KeyMode == KeyMode.Major
                    ? Major
                    : NaturalMinor;
                Scale = new Scale(Root, ActualMode);

                var accidentals = new List<Pitch>();
                foreach (var accidental in SignatureAccidentals)
                {
                    if (Scale.ScalePitches.Contains(accidental))
                        accidentals.Add(accidental);
                }

                KeySignatureAccidentals = accidentals;
            }

            public Pitch Root { get; }

            public KeyMode KeyMode { get; }

            public Mode ActualMode { get; }

            public Scale Scale { get; }

            public List<Pitch> KeySignatureAccidentals { get; }

            public Key Relative()
            {
                var accidentals = KeySignatureAccidentals;
                var keys = KeyMode == KeyMode.Major ? MinorKeys : MajorKeys;
                var root = keys
                    .Where(k => k.KeySignatureAccidentals.Count == accidentals.Count)
                    .Where(k => k.KeySignatureAccidentals.Count == 0 ||
                                k.KeySignatureAccidentals.First() == accidentals.First())
                    .Select(k => k.Root)
                    .Single();
                var mode = KeyMode == KeyMode.Major ? KeyMode.Minor : KeyMode.Major;
                return new Key(root, mode);
            }
        }
    }
}