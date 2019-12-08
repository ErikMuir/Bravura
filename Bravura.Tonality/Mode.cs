using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class Mode
    {
        public Mode(string name, List<int> noteIndices, List<Interval> modeIntervals)
        {
            try
            {
                Name = name.TrimToNull();
                NoteIndices = noteIndices;
                ModeIntervals = modeIntervals;

                if (Name == null)
                    throw new Exception($"{nameof(Name)} is required.");
                if (NoteIndices == null)
                    throw new Exception($"{nameof(NoteIndices)} is required.");
                if (ModeIntervals == null)
                    throw new Exception($"{nameof(ModeIntervals)} is required.");
                if (NoteIndices.Count != ModeIntervals.Count)
                    throw new Exception($"{nameof(NoteIndices)} and {nameof(ModeIntervals)} must be the same length.");
                if (NoteIndices.Count < 5)
                    throw new Exception($"{nameof(NoteIndices)} length cannot be less than 5.");
                if (NoteIndices.Count > 12)
                    throw new Exception($"{nameof(NoteIndices)} length cannot be greater than 12.");
                if (NoteIndices.Any(i => i < 0))
                    throw new Exception($"{nameof(NoteIndices)} elements cannot be less than 0.");
                if (NoteIndices.Any(i => i > 6))
                    throw new Exception($"{nameof(NoteIndices)} elements cannot be more than 6.");
                if (ModeIntervals.Count < 5)
                    throw new Exception($"{nameof(ModeIntervals)} length cannot be less than 5.");
                if (ModeIntervals.Count > 12)
                    throw new Exception($"{nameof(ModeIntervals)} length cannot be greater than 12.");
            }
            catch (Exception ex)
            {
                throw new BravuraTonalityException($"{nameof(Mode)} is invalid: {ex.Message}");
            }
        }

        public string Name { get; }
        public List<int> NoteIndices { get; }
        public List<Interval> ModeIntervals { get; }

        private static bool AreEqual(Mode a, Mode b)
        {
            if (a.Name != b.Name) return false;
            if (a.NoteIndices.Count != b.NoteIndices.Count) return false;
            if (a.ModeIntervals.Count != b.ModeIntervals.Count) return false;
            for (var i = 0; i < a.NoteIndices.Count; i++)
            {
                if (a.NoteIndices[i] != b.NoteIndices[i]) return false;
                if (a.ModeIntervals[i] != b.ModeIntervals[i]) return false;
            }
            return true;
        }

        public static bool operator ==(Mode a, Mode b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null) return false;
            return AreEqual(a, b);
        }

        public static bool operator !=(Mode a, Mode b)
            => !(a == b);

        public override bool Equals(object obj)
        {
            if (!(obj is Mode)) return false;
            var mode = (Mode)obj;
            return AreEqual(this, mode);
        }

        public override int GetHashCode()
        {
            return HashCode.Start
                .Hash(Name)
                .Hash(NoteIndices)
                .Hash(ModeIntervals);
        }
    }
}