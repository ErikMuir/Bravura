namespace Bravura.Tonality.Analysis;

public class ChordProgressionAnalysis
{
    public ChordProgressionAnalysis(List<ChordalRelationship> relationships)
    {
        Relationships = relationships;
    }

    public List<ChordalRelationship> Relationships { get; set; }
}
