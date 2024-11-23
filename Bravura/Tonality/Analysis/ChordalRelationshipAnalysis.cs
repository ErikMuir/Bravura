using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordalRelationshipAnalysis
{
    public ChordalRelationshipAnalysis(Key key, List<AnalyzedChord> analyzedChords)
    {
        Key = key;
        AnalyzedChords = analyzedChords;

        // for each chord
        foreach (var analyzedChord in AnalyzedChords)
        {
            // add one for each diatonic pitch
            AppliedWeight.Apply(analyzedChord.Chord.Pitches.Count(Key.Scale.Pitches.Contains));

            // don't forget about major sevenths in harmonic and melodic minor keys, especially when it's the 5 chord
            var majorSeventh = Key.Root.Transpose(Direction.Up, Intervals.MajorSeventh);
            var fiveChordBonus = analyzedChord.Interval == Intervals.PerfectFifth ? 1 : 0;
            AppliedWeight.ApplyIf(1 + fiveChordBonus, Key.Modality == Modality.Minor && analyzedChord.Chord.Pitches.Contains(majorSeventh));

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
            AppliedWeight.ApplyIf(3, isTwoFive);

            // V7-(I/i)
            var isFiveOne = AnalyzedChords[pairIndex].Interval == Intervals.PerfectFifth &&
                AnalyzedChords[pairIndex].Chord.IsMajor &&
                AnalyzedChords[pairIndex].Chord.IsDominant &&
                AnalyzedChords[pairIndex + 1].Interval == Intervals.PerfectUnison &&
                (AnalyzedChords[pairIndex + 1].Chord.IsMajor || AnalyzedChords[pairIndex + 1].Chord.IsMinor) &&
                !AnalyzedChords[pairIndex + 1].Chord.IsDominant;
            AppliedWeight.ApplyIf(3, isFiveOne);
        }
    }

    public Key Key { get; set; }

    public List<AnalyzedChord> AnalyzedChords { get; set; }

    private readonly AppliedWeight AppliedWeight = new();

    public int Weight => AppliedWeight.Weight;
}
