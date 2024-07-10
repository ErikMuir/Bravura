using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordalRelationship : IBaseTonality
{
    public ChordalRelationship(Chord chord1, Chord chord2)
    {
        Chord1 = chord1;
        Chord2 = chord2;
        Analysis = Chord1.PotentialKeys.Append(Chord2.PotentialKeys)
            .Distinct()
            .Select(key => new KeyValuePair<Key, List<AnalyzedChord>>(key, [new(Chord1, key), new(Chord2, key)]))
            .ToDictionary();
    }

    public Chord Chord1 { get; }

    public Chord Chord2 { get; }

    public Dictionary<Key, List<AnalyzedChord>> Analysis { get; }

    public string DisplayValue(bool onlyAscii = false)
    {
        return $"{Chord1.DisplayValue(onlyAscii)} - {Chord2.DisplayValue(onlyAscii)}";
    }
}
