using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality.Analysis;

public class ChordProgressionAnalysis(IEnumerable<AnalyzedChord> analyzedChords)
{
    private readonly AppliedWeight AppliedWeight = new();

    public List<AnalyzedChord> AnalyzedChords { get; set; } = analyzedChords.ToList();

    public int Weight => AppliedWeight.Weight;
}
