using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordalRelationshipAnalysis
{
    public ChordalRelationshipAnalysis(Key key, List<AnalyzedChord> analyzedChords)
    {
        Key = key;
        AnalyzedChords = analyzedChords;
        Weight = 0;

        foreach (var analyzedChord in AnalyzedChords)
        {
            // add one for each diatonic pitch
            Weight += analyzedChord.Chord.Pitches.Count(Key.Scale.Pitches.Contains);

            // add another if the root is diatonic
            if (Key.Scale.Pitches.Contains(analyzedChord.Chord.Root))
                Weight++;
        }

        // ii-V
        if (AnalyzedChords[0].Interval == Intervals.MajorSecond &&
            AnalyzedChords[0].Chord.IsMinor &&
            AnalyzedChords[1].Interval == Intervals.PerfectFifth &&
            AnalyzedChords[1].Chord.IsMajor)
        {
            Weight += 3;
        }

        // V7-(I/i)
        if (AnalyzedChords[0].Interval == Intervals.PerfectFifth &&
            AnalyzedChords[0].Chord.IsMajor &&
            AnalyzedChords[0].Chord.IsDominant &&
            AnalyzedChords[1].Interval == Intervals.PerfectUnison &&
            (AnalyzedChords[1].Chord.IsMajor || AnalyzedChords[1].Chord.IsMinor) &&
            !AnalyzedChords[1].Chord.IsDominant)
        {
            Weight += 3;
        }
    }

    public Key Key { get; set; }

    public List<AnalyzedChord> AnalyzedChords { get; set; }

    public int Weight { get; set; }
}
