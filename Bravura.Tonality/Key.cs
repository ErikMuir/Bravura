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

            var signature = new List<Pitch>();
            foreach (var accidental in Pitches.SignatureAccidentals)
            {
                if (Scale.ScalePitches.Any(p => p.ToString() == accidental.ToString()))
                    signature.Add(accidental);
            }

            KeySignature = signature;
        }

        public Pitch Root { get; }
        public KeyMode KeyMode { get; }
        public Mode ActualMode { get; }
        public Scale Scale { get; }
        public List<Pitch> KeySignature { get; }

        public Key Relative()
        {
            var accidentals = KeySignature;
            var keys = KeyMode == KeyMode.Major ? Keys.MinorKeys : Keys.MajorKeys;
            var root = keys
                .Where(k => k.KeySignature.Count == accidentals.Count)
                .Where(k => k.KeySignature.Count == 0 ||
                            k.KeySignature.First() == accidentals.First())
                .Select(k => k.Root)
                .Single();
            var mode = KeyMode == KeyMode.Major ? KeyMode.Minor : KeyMode.Major;
            return new Key(root, mode);
        }
    }
}