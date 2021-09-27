using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class ChromaticScale : IEquatable<ChromaticScale>
    {
        public ChromaticScale(Pitch root)
        {
            Root = root;

            Validate();

            Pref = GetEnharmonicPreference();
            Pitches = new Scale(Root, Mode)
                .Pitches
                .Select(PreferredPitch)
                .ToList();
        }

        public Pitch Root { get; }
        public Mode Mode => Modes.Chromatic;
        public EnharmonicPreference Pref { get; }
        public List<Pitch> Pitches { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Root == null)
                errors.Add($"{nameof(Root)} is required.");

            if (errors.Count > 0)
                throw new ScaleException(errors);
        }

        private EnharmonicPreference GetEnharmonicPreference()
        {
            if (Root.IsFlat)
                return EnharmonicPreference.Flat;
            if (Root.IsSharp)
                return EnharmonicPreference.Sharp;
            var letter = Root.Note.Letter;
            return letter == 'F' || letter == 'C'
                ? EnharmonicPreference.Flat
                : EnharmonicPreference.Sharp;
        }

        private Pitch PreferredPitch(Pitch pitch)
        {
            var logicalPitch = pitch.Equals(Root) ? pitch : pitch.Logical();
            switch (Pref)
            {
                case EnharmonicPreference.Flat:
                    return logicalPitch.IsSharp
                        ? Bravura.Tonality.Pitches.Flats.Single(p => p.EnharmonicallyEquals(logicalPitch))
                        : logicalPitch;
                case EnharmonicPreference.Sharp:
                    return logicalPitch.IsFlat
                        ? Bravura.Tonality.Pitches.Sharps.Single(p => p.EnharmonicallyEquals(logicalPitch))
                        : logicalPitch;
                default:
                    return logicalPitch;
            }
        }

        public bool EnharmonicallyEquals(ChromaticScale other)
            => other != null
                && Root.EnharmonicallyEquals(other.Root)
                && Mode.Equals(other.Mode);

        public bool Equals(ChromaticScale other)
        {
            if (other == null) return false;
            if (!Root.Equals(other.Root)) return false;
            if (!Mode.Equals(other.Mode)) return false;
            if (Pitches.Count != other.Pitches.Count) return false;
            for (var i = 0; i < Pitches.Count; i++)
            {
                if (!Pitches[i].Equals(other.Pitches[i])) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
            => (obj is ChromaticScale) && Equals((ChromaticScale)obj);

        public override int GetHashCode()
        {
            var hashCode = Bravura.Common.HashCode.Start
                .Hash(Root)
                .Hash(Mode);
            for (var i = 0; i < Pitches.Count; i++)
            {
                hashCode = hashCode.Hash(Pitches[i]);
            }
            return hashCode;
        }
    }
}
