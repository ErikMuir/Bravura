using Bravura.Common;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordProgression(List<Chord> chords)
{
    public List<Chord> Chords { get; } = chords;

    public List<ChordProgressionAnalysis> Analysis { get; } = AnalyzeChordProgression(chords);

    public Key BestKey => Analysis.MaxBy(a => a.Weight).Key;

    private static List<ChordProgressionAnalysis> AnalyzeChordProgression(List<Chord> chords)
    {
        var relationships = Enumerable.Range(0, chords.Count - 1)
            .Select(i => new ChordRelationship(chords[i], chords[i + 1]))
            .ToList();

        var indexableKeys = Enumerable.Range(0, chords.Count)
            .Select(i =>
            {
                var keys = new List<Key>();
                if (i > 0)
                {
                    keys.AddRange(relationships[i - 1].PotentialKeys);
                }
                if (i < chords.Count - 1)
                {
                    keys.AddRange(relationships[i].PotentialKeys);
                }
                return new Indexable<Key>(keys.DistinctBy(k => k));
            })
            .ToList();

        var chordIndex = chords.Count - 1;
        var analysis = new List<ChordProgressionAnalysis>();
        var analysisCount = indexableKeys.Select(keys => keys.Count).Aggregate(1, (total, next) => total * next);
        for (var analysisIndex = 0; analysisIndex < analysisCount; analysisIndex++)
        {
            var keys = indexableKeys[chordIndex];

            var analyzedChords = Enumerable.Range(0, chords.Count)
                .Select(i => new AnalyzedChord(chords[i], keys.Current))
                .ToList();

            var existingAnalysis = analysis.SingleOrDefault(a => a.Key == keys.Current);
            if (existingAnalysis is null)
                analysis.Add(new ChordProgressionAnalysis(analyzedChords));

            if (keys.Index < keys.Count - 1)
                keys.MoveNext();
            else if (chordIndex == 0)
                break;
            else
            {
                keys.Reset();
                chordIndex--;
            }
        }

        return analysis;
    }
}
