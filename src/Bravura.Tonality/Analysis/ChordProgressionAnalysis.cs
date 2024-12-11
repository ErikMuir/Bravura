using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality.Analysis;

public class ChordProgressionAnalysis
{
    public ChordProgressionAnalysis(IEnumerable<AnalyzedChord> analyzedChords)
    {
        AnalyzedChords = analyzedChords?.ToList();

        if (AnalyzedChords is null || AnalyzedChords.Count == 0)
            throw new BravuraException("One or more AnalyzedChords are required.");
        if (AnalyzedChords.Select(ac => ac.Key).Distinct().Count() > 1)
            throw new BravuraException("All AnalyzedChords must have the same Key.");

        Weight = CalculateWeight(AnalyzedChords);
    }

    public List<AnalyzedChord> AnalyzedChords { get; }

    public int Weight { get; }

    public Key Key => AnalyzedChords.Select(ac => ac.Key).Distinct().Single();

    private static int CalculateWeight(List<AnalyzedChord> analyzedChords)
    {
        var key = analyzedChords.Select(ac => ac.Key).Distinct().Single();
        var weight = new Incrementable();

        // add one if the progression is more than 2 chords, and the first chord is a I (or i) chord
        weight.IncrementIf(analyzedChords.Count > 2 && analyzedChords.First().Chord.Root == key.Root);

        // for each chord
        foreach (var analyzedChord in analyzedChords)
        {
            // add one for each diatonic pitch
            weight.Increment(analyzedChord.Chord.Pitches.Count(key.Scale.Pitches.Contains));

            // don't forget about major sevenths in harmonic and melodic minor keys, especially when it's the 5 chord
            var majorSeventh = key.Root.Transpose(Direction.Up, Intervals.MajorSeventh);
            var fiveChordBonus = analyzedChord.Interval == Intervals.PerfectFifth ? 1 : 0;
            weight.IncrementIf(key.Modality == Modality.Minor && analyzedChord.Chord.Pitches.Contains(majorSeventh), 1 + fiveChordBonus);

            // add another if the chord's root is diatonic
            weight.IncrementIf(key.Scale.Pitches.Contains(analyzedChord.Chord.Root));

            // add another if the chord's root is the same as the key's root
            weight.IncrementIf(analyzedChord.Chord.Root == key.Root);
        }

        // for each pair of chords
        foreach (var pairIndex in Enumerable.Range(0, analyzedChords.Count - 1))
        {
            // ii-V
            var isTwoFive = analyzedChords[pairIndex].Interval == Intervals.MajorSecond &&
                analyzedChords[pairIndex].Chord.IsMinor &&
                analyzedChords[pairIndex + 1].Interval == Intervals.PerfectFifth &&
                analyzedChords[pairIndex + 1].Chord.IsMajor;
            weight.IncrementIf(isTwoFive, 3);

            // V7-(I/i)
            var isFiveOne = analyzedChords[pairIndex].Interval == Intervals.PerfectFifth &&
                analyzedChords[pairIndex].Chord.IsMajor &&
                analyzedChords[pairIndex].Chord.IsDominant &&
                analyzedChords[pairIndex + 1].Interval == Intervals.PerfectUnison &&
                (analyzedChords[pairIndex + 1].Chord.IsMajor || analyzedChords[pairIndex + 1].Chord.IsMinor) &&
                !analyzedChords[pairIndex + 1].Chord.IsDominant;
            weight.IncrementIf(isFiveOne, 3);
        }

        return weight.Value;
    }
}
