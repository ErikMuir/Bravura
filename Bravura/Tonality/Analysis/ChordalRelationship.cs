using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordalRelationship : IBaseTonality
{
    public ChordalRelationship(Chord chord1, Chord chord2)
    {
        Chord1 = chord1;
        Chord2 = chord2;
        Analysis = Chord1.PotentialKeys
            .AppendDistinct(Chord2.PotentialKeys)
            .Select(key => new KeyValuePair<Key, ChordalRelationshipAnalysis>(
                key,
                new ChordalRelationshipAnalysis(key, [new(Chord1, key), new(Chord2, key)])))
            .ToDictionary();
        BestKeys = Analysis
            .Where(kvp => kvp.Value.Weight == MaxWeight)
            .Select(kvp => kvp.Key)
            .ToList();
    }

    public Chord Chord1 { get; }

    public Chord Chord2 { get; }

    public Dictionary<Key, ChordalRelationshipAnalysis> Analysis { get; }

    public int MaxWeight => Analysis.Select(kvp => kvp.Value.Weight).Max();

    public List<Key> BestKeys { get; }

    public string DisplayValue(bool onlyAscii = false)
    {
        return $"{Chord1.DisplayValue(onlyAscii)} - {Chord2.DisplayValue(onlyAscii)}";
    }
}
