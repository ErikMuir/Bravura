using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public struct Chord
    {
        public Pitch Root { get; }
        public ChordQuality ChordQuality { get; }

        public Chord(Pitch root, ChordQuality quality)
        {
            Root = root;
            ChordQuality = quality;
        }

        public List<Pitch> Notes
            => ChordQuality.Intervals
                .Select(Root.GetPitchByIntervalAbove)
                .ToList();

        public List<string> NoteSymbols
            => ChordQuality.Intervals
                .Select(Root.GetPitchByIntervalAbove)
                .Select(p => p.ToString())
                .ToList();

        public List<string> AsciiNoteSymbols
            => ChordQuality.Intervals
                .Select(Root.GetPitchByIntervalAbove)
                .Select(p => p.ToAsciiString())
                .ToList();

        public List<string> ChordTones
            => ChordQuality.Intervals
                .Select(i => i.ToString())
                .ToList();

        public List<string> AsciiChordTones
            => ChordQuality.Intervals
                .Select(i => i.ToAsciiString())
                .ToList();
    }
}