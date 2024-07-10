using System;
using System.Linq;
using Bravura.Common.Exceptions;
using Bravura.Common.Extensions;

namespace Bravura.Tonality.Analysis;

public class AnalyzedChord : IBaseTonality
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

    public Interval Interval { get; }

    public string RomanNumeralAnalysis(bool onlyAscii = false)
    {
        var accidental = Interval.Accidental.SemitonesAwayFromNatural == 0
            ? ""
            : Interval.Accidental.DisplayValue(onlyAscii);
        var romanNumeral = $"{(RomanNumerals)Interval.Degree}";
        romanNumeral = Chord.Contains(Intervals.MinorThird) ? romanNumeral.ToLower() : romanNumeral.ToUpper();
        var quality = Chord.Quality.DisplayValue(onlyAscii);
        if (quality.StartsWith('m')) quality = quality[1..];
        return $"{accidental}{romanNumeral}{quality}";
    }

    public string DisplayValue(bool onlyAscii = false) => RomanNumeralAnalysis(onlyAscii);

    public override string ToString() => DisplayValue(true);
}
