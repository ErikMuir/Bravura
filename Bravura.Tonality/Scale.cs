using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Scale : IEquatable<Scale>
    {
        public Scale(Pitch root, Mode mode)
        {
            Root = root;
            Mode = mode;

            Validate();

            Pitches = Mode.Intervals.Select(i => Root.GetPitchByIntervalAbove(i)).ToList();
        }

        public Pitch Root { get; }
        public Mode Mode { get; }
        public List<Pitch> Pitches { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Root == null)
                errors.Add($"{nameof(Root)} is required.");
            if (Mode == null)
                errors.Add($"{nameof(Mode)} is required.");

            if (errors.Count > 0)
                throw new ScaleException(errors);
        }

        public bool EnharmonicallyEquals(Scale other)
            => other != null
                && Root.EnharmonicallyEquals(other.Root)
                && Mode.Equals(other.Mode);

        public bool Equals(Scale other)
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
            => (obj is Scale) && Equals((Scale)obj);

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
