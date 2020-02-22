using System;
using System.Collections.Generic;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Mode : IEquatable<Mode>
    {
        public Mode(
            string name,
            List<Interval> modeIntervals)
        {
            Name = name.TrimToNull();
            ModeIntervals = modeIntervals;

            Validate();
        }

        public string Name { get; }
        public List<Interval> ModeIntervals { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Name == null)
                errors.Add($"{nameof(Name)} is required.");

            if (ModeIntervals == null)
                errors.Add($"{nameof(ModeIntervals)} is required.");
            else
            {
                if (ModeIntervals.Count < 5)
                    errors.Add($"{nameof(ModeIntervals)} length cannot be less than 5.");
                if (ModeIntervals.Count > 12)
                    errors.Add($"{nameof(ModeIntervals)} length cannot be greater than 12.");
            }

            if (errors.Count > 0)
                throw new ModeException(errors);
        }

        public bool EffectivelyEquals(Mode other)
        {
            if (other == null) return false;
            for (var i = 0; i < ModeIntervals.Count; i++)
            {
                if (!ModeIntervals[i].Equals(other.ModeIntervals[i])) return false;
            }
            return true;
        }

        public bool Equals(Mode other)
        {
            if (other == null) return false;
            if (Name != other.Name) return false;
            for (var i = 0; i < ModeIntervals.Count; i++)
            {
                if (!ModeIntervals[i].Equals(other.ModeIntervals[i])) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
            => (obj is Mode) && Equals((Mode)obj);

        public override int GetHashCode()
        {
            var hashCode = HashCode.Start.Hash(Name);
            for (var i = 0; i < ModeIntervals.Count; i++)
            {
                hashCode = hashCode.Hash(ModeIntervals[i]);
            }
            return hashCode;
        }
    }
}