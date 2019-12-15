using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality
{
    public class Chord : IEquatable<Chord>
    {
        public Chord(Pitch root, ChordQuality quality)
        {
            Root = root;
            ChordQuality = quality;

            Validate();
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

        private void Validate()
        {
            var errors = new List<string>();

            if (Root == null)
                errors.Add($"{nameof(Root)} is required.");
            if (ChordQuality == null)
                errors.Add($"{nameof(ChordQuality)} is required.");

            if (errors.Count > 0)
                throw new ChordException(errors);
        }

        public List<Pitch> CommonTones(Chord other)
            => Pitches.Where(pitch => other.Pitches.Contains(pitch)).ToList();

        public bool HasSamePitches(Chord other)
        {
            if (Pitches.Count != other.Pitches.Count) return false;
            foreach (var pitch in Pitches)
            {
                if (!other.Pitches.Contains(pitch)) return false;
            }
            return true;
        }

        public bool EnharmonicallyEquals(Chord other)
            => other != null
                && Root.EnharmonicallyEquals(other.Root)
                && ChordQuality.EffectivelyEquals(other.ChordQuality);

        public bool Equals(Chord other)
            => other != null
                && Root.Equals(other.Root)
                && ChordQuality.Equals(other.ChordQuality);

        public override bool Equals(object obj)
            => (obj is Chord) && Equals((Chord)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Root)
                .Hash(ChordQuality);
    }
}