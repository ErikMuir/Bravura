using System.Collections.Generic;
using System.Linq;
using Bravura.Common.Exceptions;
using Bravura.Common.Types;

namespace Bravura.Tonality.Analysis;

public class ChordProgressionAnalysis
{
    public ChordProgressionAnalysis(IEnumerable<AnalyzedChord> analyzedChords)
    {
        if (analyzedChords is null || !analyzedChords.Any())
            throw new BravuraException("One or more AnalyzedChords are required.");
        if (analyzedChords.Select(ac => ac.Key).Distinct().Count() > 1)
            throw new BravuraException("All AnalyzedChords must have the same Key.");

        AnalyzedChords = analyzedChords.ToList();

        ApplyWeight();
    }

    public List<AnalyzedChord> AnalyzedChords { get; set; }

    public Key Key => AnalyzedChords.Select(ac => ac.Key).Distinct().SingleOrDefault();

    public int Weight => AppliedWeight.Weight;

    private readonly AppliedWeight AppliedWeight = new();

    private void ApplyWeight()
    {
        // add one if the progression is more than 2 chords, and the first chord is a I (or i) chord
        AppliedWeight.ApplyIf(AnalyzedChords.Count > 2 && AnalyzedChords.First().Chord.Root == Key.Root);

        // for each chord
        foreach (var analyzedChord in AnalyzedChords)
        {
            // add one for each diatonic pitch
            AppliedWeight.Apply(analyzedChord.Chord.Pitches.Count(Key.Scale.Pitches.Contains));

            // don't forget about major sevenths in harmonic and melodic minor keys, especially when it's the 5 chord
            var majorSeventh = Key.Root.Transpose(Direction.Up, Intervals.MajorSeventh);
            var fiveChordBonus = analyzedChord.Interval == Intervals.PerfectFifth ? 1 : 0;
            AppliedWeight.ApplyIf(Key.Modality == Modality.Minor && analyzedChord.Chord.Pitches.Contains(majorSeventh), 1 + fiveChordBonus);

            // add another if the chord's root is diatonic
            AppliedWeight.ApplyIf(Key.Scale.Pitches.Contains(analyzedChord.Chord.Root));

            // add another if the chord's root is the same as the key's root
            AppliedWeight.ApplyIf(analyzedChord.Chord.Root == Key.Root);
        }

        // for each pair of chords
        foreach (var pairIndex in Enumerable.Range(0, AnalyzedChords.Count - 1))
        {
            // ii-V
            var isTwoFive = AnalyzedChords[pairIndex].Interval == Intervals.MajorSecond &&
                AnalyzedChords[pairIndex].Chord.IsMinor &&
                AnalyzedChords[pairIndex + 1].Interval == Intervals.PerfectFifth &&
                AnalyzedChords[pairIndex + 1].Chord.IsMajor;
            AppliedWeight.ApplyIf(isTwoFive, 3);

            // V7-(I/i)
            var isFiveOne = AnalyzedChords[pairIndex].Interval == Intervals.PerfectFifth &&
                AnalyzedChords[pairIndex].Chord.IsMajor &&
                AnalyzedChords[pairIndex].Chord.IsDominant &&
                AnalyzedChords[pairIndex + 1].Interval == Intervals.PerfectUnison &&
                (AnalyzedChords[pairIndex + 1].Chord.IsMajor || AnalyzedChords[pairIndex + 1].Chord.IsMinor) &&
                !AnalyzedChords[pairIndex + 1].Chord.IsDominant;
            AppliedWeight.ApplyIf(isFiveOne, 3);
        }
    }
}
