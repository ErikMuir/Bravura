using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public static partial class Tonality
    {
        public class Chord
        {
            #region -- Constructor --

            public Chord(Pitch root, ChordQuality quality)
            {
                Root = root;
                ChordQuality = quality;
            }

            #endregion

            #region -- Properties --

            public Pitch Root { get; }
            public ChordQuality ChordQuality { get; }
            public List<Pitch> Notes
                => ChordQuality.ChordQualityIntervals
                    .Select(Root.GetPitchByIntervalAbove)
                    .ToList();
            public List<string> NoteSymbols
                => ChordQuality.ChordQualityIntervals
                    .Select(Root.GetPitchByIntervalAbove)
                    .Select(p => p.ToString())
                    .ToList();
            public List<string> AsciiNoteSymbols
                => ChordQuality.ChordQualityIntervals
                    .Select(Root.GetPitchByIntervalAbove)
                    .Select(p => p.ToAsciiString())
                    .ToList();
            public List<string> ChordTones
                => ChordQuality.ChordQualityIntervals
                    .Select(i => i.ToString())
                    .ToList();
            public List<string> AsciiChordTones
                => ChordQuality.ChordQualityIntervals
                    .Select(i => i.ToAsciiString())
                    .ToList();

            #endregion
        }
    }
}