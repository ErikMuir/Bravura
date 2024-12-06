using System;
using System.Linq;
using Bravura.Common.Exceptions;
using Bravura.Common.Utilities;

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
    }

    public Chord Chord { get; }

    public Key Key { get; }

    public bool IsDiatonic => Chord.Pitches.All(Key.Scale.Pitches.Contains);

    public Interval Interval { get; }

    public string RomanNumeralAnalysis()
    {
        var accidental = Interval.Accidental.SemitonesAwayFromNatural == 0
            ? ""
            : $"{Interval.Accidental}";
        var romanNumeral = $"{(RomanNumerals)Interval.Degree}";
        romanNumeral = Chord.Contains(Intervals.MinorThird) ? romanNumeral.ToLower() : romanNumeral.ToUpper();
        var quality = $"{Chord.Quality}";
        if (quality.StartsWith('m')) quality = quality[1..];
        return $"{accidental}{romanNumeral}{quality}";
    }

    public override string ToString() => RomanNumeralAnalysis();
}
