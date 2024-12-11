using System.Collections.Generic;

namespace Bravura.Tonality.Tests;

public class TonalityExtensionsTests
{
    [Fact]
    public void ToJoinedString_Accidentals_Test()
    {
        List<Accidental> accidentals =
        [
            Accidentals.Flat,
            Accidentals.Natural,
            Accidentals.Sharp,
        ];
        Assert.Equal("♭ ♮ ♯", accidentals.ToJoinedString());
    }

    [Fact]
    public void ToJoinedString_Chords_Test()
    {
        List<Chord> chords =
        [
            new Chord(Pitches.DNatural, ChordQualities.Min7),
            new Chord(Pitches.BFlat, ChordQualities.Maj7),
            new Chord(Pitches.ENatural, ChordQualities.Min7Flat5),
            new Chord(Pitches.ANatural, ChordQualities.Dom7Flat9),
        ];
        Assert.Equal("Dm7 B♭Maj7 Em7♭5 A7♭9", chords.ToJoinedString());
    }

    [Fact]
    public void ToJoinedString_ChordQualities_Test()
    {
        List<ChordQuality> qualities =
        [
            ChordQualities.Sus4,
            ChordQualities.Dim7,
            ChordQualities.Maj9,
        ];
        Assert.Equal("sus4 dim7 Maj9", qualities.ToJoinedString());
    }

    [Fact]
    public void ToJoinedString_Intervals_Test()
    {
        List<Interval> intervals =
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
        ];
        Assert.Equal("♮1 ♭3 ♭5 ♭7", intervals.ToJoinedString());
    }

    [Fact]
    public void ToJoinedString_Keys_Test()
    {
        List<Key> keys =
        [
            Keys.DMinor,
            Keys.FMajor,
            Keys.EMinor,
        ];
        Assert.Equal("D Minor, F Major, E Minor", keys.ToJoinedString(", "));
    }

    [Fact]
    public void ToJoinedString_Modes_Test()
    {
        List<Mode> modes =
        [
            Modes.Ionian,
            Modes.Dorian,
            Modes.HarmonicMinor,
        ];
        Assert.Equal("Ionian, Dorian, Harmonic Minor", modes.ToJoinedString(", "));
    }

    [Fact]
    public void ToJoinedString_Notes_Test()
    {
        List<Note> notes =
        [
            Notes.A,
            Notes.C,
            Notes.E,
        ];
        Assert.Equal("A C E", notes.ToJoinedString());
    }

    [Fact]
    public void ToJoinedString_Pitches_Test()
    {
        List<Pitch> pitches =
        [
            Pitches.CSharp,
            Pitches.ENatural,
            Pitches.GSharp,
            Pitches.BNatural,
        ];
        Assert.Equal("C♯ E G♯ B", pitches.ToJoinedString());
    }

    [Fact]
    public void ToJoinedString_Scales_Test()
    {
        List<Scale> scales =
        [
            new Scale(Pitches.DNatural, Modes.HarmonicMinor),
            new Scale(Pitches.GNatural, Modes.Mixolydian),
            new Scale(Pitches.EFlat, Modes.Phrygian),
        ];
        Assert.Equal("D Harmonic Minor | G Mixolydian | E♭ Phrygian", scales.ToJoinedString(" | "));
    }
}
