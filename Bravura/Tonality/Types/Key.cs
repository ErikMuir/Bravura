using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality
{
    public enum KeyMode { Major, Minor }

    public class Key
    {
        internal Key(Pitch root, KeyMode keyMode)
        {
            Root = root;
            KeyMode = keyMode;

            ActualMode = KeyMode == KeyMode.Major
                ? Modes.Major
                : Modes.NaturalMinor;
            Scale = new Scale(Root, ActualMode);

            var accidentals = new List<Pitch>();
            foreach (var accidental in Pitches.SignatureAccidentals)
            {
                if (Scale.ScalePitches.Contains(accidental))
                    accidentals.Add(accidental);
            }

            KeySignatureAccidentals = accidentals;
        }

        public readonly Pitch Root;
        public readonly KeyMode KeyMode;
        public readonly Mode ActualMode;
        public readonly Scale Scale;
        public readonly List<Pitch> KeySignatureAccidentals;

        public Key Relative()
        {
            var accidentals = KeySignatureAccidentals;
            var keys = KeyMode == KeyMode.Major ? Keys.MinorKeys : Keys.MajorKeys;
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