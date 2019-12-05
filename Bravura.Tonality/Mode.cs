using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class Mode
    {
        public Mode(string name, List<int> noteIndices, List<Interval> intervals)
        {
            try
            {
                Name = name ?? throw new Exception();
                NoteIndices = noteIndices ?? throw new Exception();
                if (noteIndices.Count < 5 || noteIndices.Count > 12)
                    throw new Exception();
                if (noteIndices.Any(i => i < 0 || i > 6))
                    throw new Exception();
                ModeIntervals = intervals ?? throw new Exception();
                if (intervals.Count < 5 || intervals.Count > 12)
                    throw new Exception();
                if (intervals.Count != noteIndices.Count)
                    throw new Exception();
            }
            catch (Exception)
            {
                throw new BravuraTonalityException($"{nameof(Mode)} is invalid");
            }
        }

        public string Name { get; }
        public List<int> NoteIndices { get; }
        public List<Interval> ModeIntervals { get; }
    }
}