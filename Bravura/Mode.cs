using System.Collections.Generic;

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
            NoteIndices = noteIndices;
            Intervals = intervals;
        }
    }
}