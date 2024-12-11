using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordRelationship
{
    public ChordRelationship(Chord chord1, Chord chord2)
    {
        Chord1 = chord1;
        Chord2 = chord2;
        PotentialKeys = Chord1.PotentialKeys.Concat(Chord2.PotentialKeys).Distinct().ToList();
        Analysis = PotentialKeys
            .Select(key => new KeyValuePair<Key, ChordProgressionAnalysis>(
                key,
                new ChordProgressionAnalysis([new AnalyzedChord(Chord1, key), new AnalyzedChord(Chord2, key)])))
            .ToDictionary();
        var maxWeight = Analysis.Select(kvp => kvp.Value.Weight).Max();
        BestKeys = Analysis
            .Where(kvp => kvp.Value.Weight == maxWeight)
            .Select(kvp => kvp.Key)
            .ToList();
    }

    public Chord Chord1 { get; }

    public Chord Chord2 { get; }

    public Dictionary<Key, ChordProgressionAnalysis> Analysis { get; }

    public List<Key> PotentialKeys { get; }

    public List<Key> BestKeys { get; }

    public override string ToString() => $"{Chord1}:{Chord2}";
}
