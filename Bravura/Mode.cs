using System;
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
            Name = name ?? throw new NullReferenceException("Name cannot be null.");
            NoteIndices = noteIndices;
            Intervals = intervals;
        }
    }
}