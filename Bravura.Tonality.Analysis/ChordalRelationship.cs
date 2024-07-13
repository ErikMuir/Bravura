using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordalRelationshipAnalysis
{
    public Key Key { get; set; }
    public int Weight { get; set; }
    public List<AnalyzedChord> AnalyzedChords { get; set; }
}

public class ChordalRelationship : IBaseTonality
{
    public ChordalRelationship(Chord chord1, Chord chord2)
    {
        Chord1 = chord1;
        Chord2 = chord2;
        Analysis = Chord1.PotentialKeys
            .Append(Chord2.PotentialKeys)
            .Distinct()
            .Select(key => new KeyValuePair<Key, ChordalRelationshipAnalysis>(key, new ChordalRelationshipAnalysis()
            {
                Key = key,
                Weight = 0,
                AnalyzedChords = [new(Chord1, key), new(Chord2, key)],
            }))
            .ToDictionary();

        // TODO : implement logic for setting weight
        // - prefer ii-V
        // - prefer V-I
        // - prefer V-i

        var maxWeight = Analysis.MaxBy(kvp => kvp.Value.Weight).Value.Weight;
        var bestKeys = Analysis.Where(kvp => kvp.Value.Weight == maxWeight).Select(kvp => kvp.Key).ToList();
        if (bestKeys.Count > 1)
        {
            // TODO : sort by something
        }
        BestKey = bestKeys[0];
    }

    public Chord Chord1 { get; }

    public Chord Chord2 { get; }

    public Dictionary<Key, ChordalRelationshipAnalysis> Analysis { get; }

    public Key BestKey { get; }

    public string DisplayValue(bool onlyAscii = false)
    {
        return $"{Chord1.DisplayValue(onlyAscii)} - {Chord2.DisplayValue(onlyAscii)}";
    }
}
