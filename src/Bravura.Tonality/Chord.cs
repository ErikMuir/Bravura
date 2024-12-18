using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public class Chord : ITonality
{
    public Chord(Pitch root, ChordQuality quality)
    {
        Root = root;
        Quality = quality;
        Pitches = Quality.Intervals.Select(i => Root.Transpose(Direction.Up, i)).ToList();
        PotentialKeys = Keys.AllKeys.Where(key => !Pitches.Except(key.Scale.Pitches).Any()).ToList();
    }

    public Pitch Root { get; }

    public ChordQuality Quality { get; }

    public List<Pitch> Pitches { get; }

    public List<Key> PotentialKeys { get; }

    public bool IsMajor => Quality.IsMajor;

    public bool IsMinor => Quality.IsMinor;

    public bool IsDiminished => Quality.IsDiminished;

    public bool IsAugmented => Quality.IsAugmented;

    public bool IsDominant => Quality.IsDominant;

    public bool IsAltered => Quality.IsAltered;

    public bool IsSuspended => Quality.IsSuspended;

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

    public bool Contains(Interval interval) => Quality.Contains(interval);

    public Chord Transpose(Direction direction, Interval interval)
    {
        var newRoot = Root.Transpose(direction, interval);
        return new Chord(newRoot, Quality);
    }

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

    public override string ToString() => $"{Root}{Quality}";
}
