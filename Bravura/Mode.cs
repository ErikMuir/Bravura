using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public struct Mode
    {
        public string Name { get; }
        public List<int> NoteIndices { get; }
        public List<Interval> Intervals { get; }

        public Mode(string name, List<int> noteIndices, List<Interval> intervals)
        {
            Name = name ?? throw new BravuraException("A Mode's Name cannot be null.");
            NoteIndices = noteIndices ?? throw new BravuraException("A Mode's NoteIndices cannot be null.");
            if (noteIndices.Count < 5 || noteIndices.Count > 12)
                throw new BravuraException("A Mode must have between 5 and 12 NoteIndices.");
            if (noteIndices.Any(i => i < 0 || i > 6))
                throw new BravuraException("All NoteIndices must be between 0 and 6.");
            Intervals = intervals ?? throw new BravuraException("A Mode's Intervals cannot be null.");
            if (intervals.Count < 5 || intervals.Count > 12)
                throw new BravuraException("A Mode must have between 5 and 12 Intervals.");
            if (intervals.Count != noteIndices.Count)
                throw new BravuraException("A Mode must have the same number of NoteIndices and Intervals.");
        }
    }
}