using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality
{
    public record Chord(Pitch Root, ChordQuality Quality)
    {
        public List<Pitch> Pitches => Quality.Intervals.Select(Root.GetPitchByIntervalAbove).ToList();

        public List<string> NoteSymbols => Pitches.Select(p => p.ToString()).ToList();

        public List<string> AsciiNoteSymbols => Pitches.Select(p => p.ToAsciiString()).ToList();

        public List<string> ChordTones => Quality.Intervals.Select(i => i.ToString()).ToList();

        public List<string> AsciiChordTones => Quality.Intervals.Select(i => i.ToAsciiString()).ToList();

        public List<Pitch> CommonTones(Chord other) => Pitches.Where(pitch => other.Pitches.Contains(pitch)).ToList();

        public bool EnharmonicallyEquals(Chord other) => other != null && Root.EnharmonicallyEquals(other.Root) && Quality.EffectivelyEquals(other.Quality);

        public bool HasSamePitches(Chord other)
        {
            if (Pitches.Count != other.Pitches.Count) return false;
            foreach (var pitch in Pitches)
            {
                if (!other.Pitches.Contains(pitch)) return false;
            }
            return true;
        }

        public override string ToString() => $"{ Root }{ Quality }";

        public string ToAsciiString() => $"{ Root.ToAsciiString() }{ Quality.ToString() }";

        public static bool TryParse(string val, out Chord chord)
        {
            chord = null;
            if (string.IsNullOrWhiteSpace(val)) return false;

            var input = val.Trim();

            Pitch root = null;
            int rootLength;
            for (rootLength = 1; rootLength <= Math.Min(input.Length, 3); rootLength++)
            {
                if (!Pitch.TryParse(input.Substring(0, rootLength), out var iRoot)) break;
                root = iRoot;
            }
            if (root == null) return false;

            ChordQuality quality;
            if (!ChordQuality.TryParse(input.Substring(rootLength - 1), out quality)) return false;

            chord = new Chord(root, quality);
            return true;
        }
    }
}
