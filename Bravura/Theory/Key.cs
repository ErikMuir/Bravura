using System.Collections.Generic;
using System.Linq;

namespace Bravura.Theory
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
                ? Modes.Major
                : Modes.NaturalMinor;
            Scale = new Scale(Root, ActualMode);

            var accidentals = new List<Pitch>();
            foreach (var accidental in Pitches.SignatureAccidentals)
            {
                if (Scale.Pitches.Contains(accidental))
                    accidentals.Add(accidental);
            }

            SignatureAccidentals = accidentals;
            RelativeRoot = Keys.AllKeys
                .Where(k => k.Mode != keyMode)
                .Where(k => k.SignatureAccidentals.Count == accidentals.Count)
                .Where(k => k.SignatureAccidentals.Count == 0 ||
                            k.SignatureAccidentals.First().Accidental == accidentals.First().Accidental)
                .Select(k => k.Root)
                .Single();
            RelativeMode = keyMode == KeyMode.Major
                ? KeyMode.Minor
                : KeyMode.Major;
        }

        public Mode ActualMode { get; }

        public Scale Scale { get; }

        public List<Pitch> SignatureAccidentals { get; }

        public Pitch RelativeRoot { get; }

        public KeyMode RelativeMode { get; }
    }

    public enum KeyMode { Major, Minor, }
}