using System;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality.Analysis;

public class AnalyzedChord
{
    public AnalyzedChord(Chord chord, Key key)
    {
        Chord = chord;

        Key = key;

        var chordSemitonesAboveKey = (Chord.Root.SemitonesAboveC - Key.Root.SemitonesAboveC).RollingRange(11);
        Interval = Intervals.Diatonic
            .Where(interval => interval.Semitones == chordSemitonesAboveKey)
            .MinBy(interval => Math.Abs(interval.Accidental.SemitonesAwayFromNatural));
        if (Interval is null)
            throw new BravuraException("Failed to analyze chord");

        _accidental = Interval.Accidental.SemitonesAwayFromNatural == 0 ? "" : $"{Interval.Accidental}";

        _romanNumeral = $"{(RomanNumeral)Interval.Degree}";
        if (Chord.Contains(Intervals.MinorThird)) _romanNumeral = _romanNumeral.ToLower();

        _quality = $"{Chord.Quality}";
        if (_quality.StartsWith('m')) _quality = _quality[1..];
    }

    public Chord Chord { get; }

    public Key Key { get; }

    public bool IsDiatonic => Chord.Pitches.All(Key.Scale.Pitches.Contains);

    public Interval Interval { get; }

    public string RomanNumeralAnalysis => $"{_accidental}{_romanNumeral}{_quality}";

    public override string ToString() => RomanNumeralAnalysis;

    private readonly string _accidental;

    private readonly string _romanNumeral;

    private readonly string _quality;
}
