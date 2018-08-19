using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public struct Key
    {
        public Pitch Root { get; }
        public KeyMode Mode { get; }

        internal Key(Pitch root, KeyMode keyMode)
        {
            Root = root;
            Mode = keyMode;

            ActualMode = Mode == KeyMode.Major
                ? Theory.Major
                : Theory.NaturalMinor;
            Scale = new Scale(Root, ActualMode);

            var accidentals = new List<Pitch>();
            foreach (var accidental in Theory.SignatureAccidentals)
            {
                if (Scale.Pitches.Contains(accidental))
                    accidentals.Add(accidental);
            }

            SignatureAccidentals = accidentals;
        }

        public Mode ActualMode { get; }

        public Scale Scale { get; }

        public List<Pitch> SignatureAccidentals { get; }

        public Key Relative()
        {
            var accidentals = SignatureAccidentals;
            var keys = Mode == KeyMode.Major ? Theory.MinorKeys : Theory.MajorKeys;
            var root = keys
                .Where(k => k.SignatureAccidentals.Count == accidentals.Count)
                .Where(k => k.SignatureAccidentals.Count == 0 ||
                            k.SignatureAccidentals.First() == accidentals.First())
                .Select(k => k.Root)
                .Single();
            var mode = Mode == KeyMode.Major ? KeyMode.Minor : KeyMode.Major;
            return new Key(root, mode);
        }
    }

    public enum KeyMode { Major, Minor, }
}