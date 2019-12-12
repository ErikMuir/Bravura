using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class Mode : IEquatable<Mode>
    {
        public Mode(string name, List<int> noteIndices, List<Interval> modeIntervals)
        {
            Name = name.TrimToNull();
            NoteIndices = noteIndices;
            ModeIntervals = modeIntervals;

            Validate();
        }

        public string Name { get; }
        public List<int> NoteIndices { get; }
        public List<Interval> ModeIntervals { get; }

        private void Validate()
        {
            var errors = new List<string>();

            if (Name == null)
                errors.Add($"{nameof(Name)} is required.");
            if (NoteIndices == null)
                errors.Add($"{nameof(NoteIndices)} is required.");
            if (ModeIntervals == null)
                errors.Add($"{nameof(ModeIntervals)} is required.");
            if (NoteIndices.Count != ModeIntervals.Count)
                errors.Add($"{nameof(NoteIndices)} and {nameof(ModeIntervals)} must be the same length.");
            if (NoteIndices.Count < 5)
                errors.Add($"{nameof(NoteIndices)} length cannot be less than 5.");
            if (NoteIndices.Count > 12)
                errors.Add($"{nameof(NoteIndices)} length cannot be greater than 12.");
            if (NoteIndices.Any(i => i < 0))
                errors.Add($"{nameof(NoteIndices)} elements cannot be less than 0.");
            if (NoteIndices.Any(i => i > 6))
                errors.Add($"{nameof(NoteIndices)} elements cannot be more than 6.");
            if (ModeIntervals.Count < 5)
                errors.Add($"{nameof(ModeIntervals)} length cannot be less than 5.");
            if (ModeIntervals.Count > 12)
                errors.Add($"{nameof(ModeIntervals)} length cannot be greater than 12.");

            if (errors.Count > 0)
                throw new BravuraTonalityException($"{nameof(Mode)} is invalid: {string.Join(" ", errors)}");
        }

        public bool Equals(Mode other)
        {
            if (other == null) return false;
            if (NoteIndices.Count != other.NoteIndices.Count) return false;
            if (ModeIntervals.Count != other.ModeIntervals.Count) return false;
            for (var i = 0; i < NoteIndices.Count; i++)
            {
                if (NoteIndices[i] != other.NoteIndices[i]) return false;
                if (!ModeIntervals[i].Equals(other.ModeIntervals[i])) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
            => (obj is Mode) && Equals((Mode)obj);

        public override int GetHashCode()
        {
            return HashCode.Start
                .Hash(Name)
                .Hash(NoteIndices) // do we need to hash each item in the list separately?
                .Hash(ModeIntervals); // do we need to hash each item in the list separately?
        }
    }
}