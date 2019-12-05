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
                Name = name.TrimToNull() ?? throw new Exception($"{nameof(name)} is required.");
                NoteIndices = noteIndices ?? throw new Exception($"{nameof(noteIndices)} is required.");
                ModeIntervals = modeIntervals ?? throw new Exception($"{nameof(modeIntervals)} is required.");
                if (noteIndices.Count != modeIntervals.Count) throw new Exception($"{nameof(noteIndices)} and {nameof(modeIntervals)} must be the same length.");
                if (noteIndices.Count < 5) throw new Exception($"{nameof(noteIndices)} length cannot be less than 5.");
                if (noteIndices.Count > 12) throw new Exception($"{nameof(noteIndices)} length cannot be greater than 12.");
                if (noteIndices.Any(i => i < 0)) throw new Exception($"{nameof(noteIndices)} elements cannot be less than 0.");
                if (noteIndices.Any(i => i > 6)) throw new Exception($"{nameof(noteIndices)} elements cannot be more than 6.");
                if (modeIntervals.Count < 5) throw new Exception($"{nameof(modeIntervals)} length cannot be less than 5.");
                if (modeIntervals.Count > 12) throw new Exception($"{nameof(modeIntervals)} length cannot be greater than 12.");
            }
            catch (Exception ex)
            {
                throw new BravuraTonalityException($"{nameof(Mode)} is invalid: {ex.Message}");
            }
        }

        public string Name { get; }
        public List<int> NoteIndices { get; }
        public List<Interval> ModeIntervals { get; }
    }
}