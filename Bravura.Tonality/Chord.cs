using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Chord : IEquatable<Chord>
    {
        public Chord(Pitch root, ChordQuality quality)
        {
            Root = root;
            Quality = quality;

            Validate();
        }

        public Pitch Root { get; }
        public ChordQuality Quality { get; }

        public List<Pitch> Pitches
            => Quality.Intervals
                .Select(Root.GetPitchByIntervalAbove)
                .ToList();
        public List<string> NoteSymbols
            => Pitches
                .Select(p => p.ToString())
                .ToList();
        public List<string> AsciiNoteSymbols
            => Pitches
                .Select(p => p.ToAsciiString())
                .ToList();
        public List<string> ChordTones
            => Quality.Intervals
                .Select(i => i.ToString())
                .ToList();
        public List<string> AsciiChordTones
            => Quality.Intervals
                .Select(i => i.ToAsciiString())
                .ToList();

        private void Validate()
        {
            var errors = new List<string>();

            if (Root == null)
                errors.Add($"{nameof(Root)} is required.");
            if (Quality == null)
                errors.Add($"{nameof(Quality)} is required.");

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
                && Quality.EffectivelyEquals(other.Quality);

        public bool Equals(Chord other)
            => other != null
                && Root.Equals(other.Root)
                && Quality.Equals(other.Quality);

        public override bool Equals(object obj)
            => (obj is Chord) && Equals((Chord)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Root)
                .Hash(Quality);
    }
}