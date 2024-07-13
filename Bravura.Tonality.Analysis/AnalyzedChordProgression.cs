using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class AnalyzedChordProgression
{
    public AnalyzedChordProgression(List<Chord> progression)
    {
        Progression = progression;

        Relationships = [];
        for (var i = 0; i < Progression.Count - 1; i++)
            Relationships.Add(new ChordalRelationship(Progression[i], Progression[i + 1]));

        KeyCounts = [];
        Relationships.ForEach(cr =>
        {
            cr.Analysis.Keys.ToList().ForEach(key =>
            {
                KeyCounts.TryAdd(key, 0);
                KeyCounts[key]++;
            });
        });

        var maxKeyCount = KeyCounts.Values.Max();
        BestKeys = KeyCounts
            .Where(kvp => kvp.Value == maxKeyCount)
            .Select(kvp => kvp.Key)
            .ToList();

        // improve logic for BestKeys:
        // - prefer ii-V
        // - prefer V-I
        // - prefer V-i
        // - prefer first chord
    }

    public List<Chord> Progression { get; }

    public List<ChordalRelationship> Relationships { get; }

    public Dictionary<Key, int> KeyCounts { get; }

    public List<Key> BestKeys { get; }
}
