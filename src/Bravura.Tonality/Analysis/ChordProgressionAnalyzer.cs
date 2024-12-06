using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common.Types;

namespace Bravura.Tonality.Analysis;

public class ChordProgressionAnalyzer
{
    private static readonly bool Debug = false;

    public ChordProgressionAnalyzer(List<Chord> progression)
    {
        Progression = progression;
        Log($"Progression: {Progression}");

        Relationships = Enumerable.Range(0, ChordCount - 1)
            .Select(i => new ChordRelationship(Progression[i], Progression[i + 1]))
            .ToList();
        Log($"Relationships: {string.Join(" | ", Relationships.Select(r => r.BestKeys))}");

        IndexableKeys = Enumerable.Range(0, ChordCount)
            .Select(i =>
            {
                var keys = new List<Key>();
                if (i > 0)
                {
                    keys.AddRange(Relationships[i - 1].PotentialKeys);
                }
                if (i < ChordCount - 1)
                {
                    keys.AddRange(Relationships[i].PotentialKeys);
                }
                return new Indexable<Key>(keys.DistinctBy(k => k.ToString()));
            })
            .ToList();
        Log($"IndexableKeys: {string.Join(" | ", IndexableKeys.Select(k => k.ToString()))}");

        ChordIndex = ChordCount - 1;

        var analysisCount = IndexableKeys.Select(keys => keys.Count).Aggregate(1, (total, next) => total * next);
        for (int analysisIndex = 0; analysisIndex < analysisCount; analysisIndex++)
        {
            var keys = IndexableKeys[ChordIndex];

            var analyzedChords = Enumerable.Range(0, ChordCount)
                .Select(chordIndex => new AnalyzedChord(Progression[chordIndex], keys.Current))
                .ToList();

            var existingAnalysis = Analysis.SingleOrDefault(a => a.Key.ToString() == keys.Current.ToString());
            if (existingAnalysis is null)
                Analysis.Add(new ChordProgressionAnalysis(analyzedChords));

            if (!keys.IsLast)
                keys.MoveNext();
            else if (ChordIndex == 0)
                break;
            else
            {
                keys.Reset();
                ChordIndex = ChordIndex == 0 ? ChordCount - 1 : ChordIndex - 1;
            }
        }
        Log($"Analysis: {string.Join(" | ", Analysis.Select(a => $"{a.AnalyzedChords.ToString()} [{a.Weight}]"))}");
    }

    public readonly List<Chord> Progression = [];

    public readonly List<ChordRelationship> Relationships = [];

    public readonly List<Indexable<Key>> IndexableKeys = [];

    public readonly List<ChordProgressionAnalysis> Analysis = [];

    private int ChordCount => Progression.Count;

    private int ChordIndex { get; set; }

    private static void Log(string log)
    {
        if (Debug) Console.WriteLine(log);
    }
}
