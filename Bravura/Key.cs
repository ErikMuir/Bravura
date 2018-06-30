using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public struct Key
    {
        public Pitch Root { get; }
        public KeyMode Mode { get; }
        public List<Pitch> SignatureAccidentals { get; }

        public Key(Pitch root, KeyMode keyMode)
        {
            if (root.Accidental.Value == -2 || root.Accidental.Value == 2)
                throw new BravuraException("Invalid Key: Signature cannot have double sharps or double flats.");
            Root = root;
            Mode = keyMode;
            SignatureAccidentals = GetSignatureAccidentals(root, keyMode);
        }

        private static List<Pitch> GetSignatureAccidentals(Pitch root, KeyMode keyMode)
        {
            var actualMode = keyMode == KeyMode.Major ? Modes.Major : Modes.NaturalMinor;
            var scale = new Scale(root, actualMode);
            var accidentals = new List<Pitch>();

            Pitches.SignatureAccidentals.ForEach(s =>
            {
                if (scale.Pitches.Contains(s))
                    accidentals.Add(s);
            });

            if (accidentals.Any())
            {
                var accidentalValue = accidentals.First().Accidental.Value;
                var sequence = accidentalValue == -1 ? Pitches.SignatureFlats : Pitches.SignatureSharps;

                if (accidentals.Any(a => a.Accidental.Value == -2 || a.Accidental.Value == 2 || a.Accidental.Value == 0))
                    throw new BravuraException("Invalid Key: Signature cannot have double sharps or double flats.");
                if (accidentals.Any(a => a.Accidental.Value != accidentalValue))
                    throw new BravuraException("Invalid Key: Signature cannot contain both sharps and flats.");
                if (accidentals.Count > 7)
                    throw new BravuraException("Invalid Key: Signatures cannot have more than 7 accidentals.");
                if (accidentals.Where((t, i) => t != sequence[i]).Any())
                    throw new BravuraException("Invalid Key: Signature accidentals are not in the correct sequence.");
            }

            return accidentals;
        }
    }

    public enum KeyMode { Major, Minor, }
}