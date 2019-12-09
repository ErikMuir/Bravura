using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality.Exceptions;

namespace Bravura.Tonality
{
    public class Chord
    {
        public Chord(Pitch root, ChordQuality quality)
        {
            Root = root ?? throw new BravuraTonalityException($"{nameof(Root)} is required.");
            ChordQuality = quality ?? throw new BravuraTonalityException($"{nameof(ChordQuality)} is required."); ;
        }

        public Pitch Root { get; }
        public ChordQuality ChordQuality { get; }

        public List<Pitch> Pitches
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

        public List<Pitch> CommonTones(Chord chord)
            => Pitches.Where(pitch => chord.Pitches.Contains(pitch)).ToList();

        public bool HasSamePitches(Chord chord)
        {
            if (Pitches.Count != chord.Pitches.Count) return false;
            foreach (var pitch in Pitches)
            {
                if (!chord.Pitches.Contains(pitch)) return false;
            }
            return true;
        }

        public bool ChordEquals(Chord chord)
            => Root.EnharmonicallyEquals(chord.Root)
                && ChordQuality.QualityEquals(chord.ChordQuality);

        public override bool Equals(object obj)
        {
            if (!(obj is Chord)) return false;
            var chord = (Chord)obj;
            if (Root != chord.Root) return false;
            return ChordQuality.Equals(chord.ChordQuality);
        }

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Root)
                .Hash(ChordQuality);
    }
}