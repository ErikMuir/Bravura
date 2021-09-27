using System;
using System.Collections.Generic;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Mode : IEquatable<Mode>
    {
        public Mode(
            string name,
            List<Interval> intervals)
        {
            Name = name.TrimToNull();
            Intervals = intervals;

            Validate();
        }

        public string Name { get; }
        public List<Interval> Intervals { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Name == null)
                errors.Add($"{nameof(Name)} is required.");

            if (Intervals == null)
                errors.Add($"{nameof(Intervals)} is required.");
            else
            {
                if (Intervals.Count < 5)
                    errors.Add($"{nameof(Intervals)} length cannot be less than 5.");
                if (Intervals.Count > 12)
                    errors.Add($"{nameof(Intervals)} length cannot be greater than 12.");
            }

            if (errors.Count > 0)
                throw new ModeException(errors);
        }

        public bool EffectivelyEquals(Mode other)
        {
            if (other == null) return false;
            for (var i = 0; i < Intervals.Count; i++)
            {
                if (!Intervals[i].Equals(other.Intervals[i])) return false;
            }
            return true;
        }

        public bool Equals(Mode other)
        {
            if (other == null) return false;
            if (Name != other.Name) return false;
            for (var i = 0; i < Intervals.Count; i++)
            {
                if (!Intervals[i].Equals(other.Intervals[i])) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
            => (obj is Mode) && Equals((Mode)obj);

        public override int GetHashCode()
        {
            var hashCode = Bravura.Common.HashCode.Start.Hash(Name);
            for (var i = 0; i < Intervals.Count; i++)
            {
                hashCode = hashCode.Hash(Intervals[i]);
            }
            return hashCode;
        }
    }
}
