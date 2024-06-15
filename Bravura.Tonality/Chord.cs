using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public record Chord(Pitch Root, ChordQuality Quality) : IBaseTonality
{
    public List<Pitch> Pitches => Quality.Intervals.Select(Root.GetPitchByIntervalAbove).ToList();

    public List<Pitch> CommonTones(Chord other) => Pitches.Where(other.Pitches.Contains).ToList();

    public bool HasSamePitches(Chord other)
    {
        if (Pitches.Count != other.Pitches.Count) return false;
        foreach (var pitch in Pitches)
        {
            if (!other.Pitches.Contains(pitch)) return false;
        }
        return true;
    }

    public bool EnharmonicallyEquals(Chord other) => other != null && Root.EnharmonicallyEquals(other.Root) && Quality.EffectivelyEquals(other.Quality);

    public string DisplayValue(bool onlyAscii = false) => $"{Root.DisplayValue(onlyAscii)}{Quality.DisplayValue(onlyAscii)}";

    public string DisplayValueWithPitches(bool onlyAscii = false) => $"{DisplayValue(onlyAscii)} {{ {Pitches.DisplayValue(onlyAscii)} }}";

    public static bool TryParse(string val, out Chord chord)
    {
        chord = null;
        if (string.IsNullOrWhiteSpace(val)) return false;

        var input = val.Trim();

        Pitch root = null;
        int rootLength;
        for (rootLength = 1; rootLength <= Math.Min(input.Length, 3); rootLength++)
        {
            if (!Pitch.TryParse(input[..rootLength], out var iRoot)) break;
            root = iRoot;
        }
        if (root == null) return false;

        if (!ChordQuality.TryParse(input[(rootLength - 1)..], out var quality)) return false;

        chord = new Chord(root, quality);
        return true;
    }
}
