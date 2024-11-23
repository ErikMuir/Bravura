using System.Collections.Generic;

namespace Bravura.Tonality.Analysis;

public class ChordProgression
{
    public ChordProgression(List<Chord> chords)
    {
        Chords = chords;
        Analysis = new ChordProgressionAnalyzer(Chords).Analysis;
    }

    public List<Chord> Chords { get; }

    public List<ChordProgressionAnalysis> Analysis { get; }
}
