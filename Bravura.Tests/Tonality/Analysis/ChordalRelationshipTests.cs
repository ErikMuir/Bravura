using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality;
using Bravura.Tonality.Analysis;
using Xunit;

namespace Bravura.Tests.Tonality.Analysis;

public class ChordalRelationshipTests
{
    [Fact]
    public void Analysis_Test()
    {
        var gMajorChord = new Chord(Pitches.GNatural, ChordQualities.Maj);
        var cMajorChord = new Chord(Pitches.CNatural, ChordQualities.Maj);
        var relationship = new ChordalRelationship(gMajorChord, cMajorChord);

        var analysis = relationship.Analysis;
        Assert.Equal(8, analysis.Keys.Count);

        var gMajorAnalysis = analysis.GetValueOrDefault(Keys.GMajor)?.AnalyzedChords;
        Assert.NotEmpty(gMajorAnalysis);
        Assert.Equal("I", gMajorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("IV", gMajorAnalysis[1].RomanNumeralAnalysis());

        var eMinorAnalysis = analysis.GetValueOrDefault(Keys.EMinor)?.AnalyzedChords;
        Assert.NotEmpty(eMinorAnalysis);
        Assert.Equal("♭III", eMinorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("♭VI", eMinorAnalysis[1].RomanNumeralAnalysis());

        var cMajorAnalysis = analysis.GetValueOrDefault(Keys.CMajor)?.AnalyzedChords;
        Assert.NotEmpty(cMajorAnalysis);
        Assert.Equal("V", cMajorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("I", cMajorAnalysis[1].RomanNumeralAnalysis());

        var aMinorAnalysis = analysis.GetValueOrDefault(Keys.AMinor)?.AnalyzedChords;
        Assert.NotEmpty(aMinorAnalysis);
        Assert.Equal("♭VII", aMinorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("♭III", aMinorAnalysis[1].RomanNumeralAnalysis());

        var dMajorAnalysis = analysis.GetValueOrDefault(Keys.DMajor)?.AnalyzedChords;
        Assert.NotEmpty(dMajorAnalysis);
        Assert.Equal("IV", dMajorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("♭VII", dMajorAnalysis[1].RomanNumeralAnalysis());

        var bMinorAnalysis = analysis.GetValueOrDefault(Keys.BMinor)?.AnalyzedChords;
        Assert.NotEmpty(bMinorAnalysis);
        Assert.Equal("♭VI", bMinorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("♭II", bMinorAnalysis[1].RomanNumeralAnalysis());

        var fMajorAnalysis = analysis.GetValueOrDefault(Keys.FMajor)?.AnalyzedChords;
        Assert.NotEmpty(fMajorAnalysis);
        Assert.Equal("II", fMajorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("V", fMajorAnalysis[1].RomanNumeralAnalysis());

        var dMinorAnalysis = analysis.GetValueOrDefault(Keys.DMinor)?.AnalyzedChords;
        Assert.NotEmpty(dMinorAnalysis);
        Assert.Equal("IV", dMinorAnalysis[0].RomanNumeralAnalysis());
        Assert.Equal("♭VII", dMinorAnalysis[1].RomanNumeralAnalysis());
    }

    [Fact]
    public void BestKeys_Multiple_Test()
    {
        var aMinorChord = new Chord(Pitches.ANatural, ChordQualities.Min);
        var gMajorChord = new Chord(Pitches.GNatural, ChordQualities.Maj);
        var relationship = new ChordalRelationship(aMinorChord, gMajorChord);

        Assert.Equal(2, relationship.BestKeys.Count);
        Assert.Contains(Keys.AMinor, relationship.BestKeys);
        Assert.Contains(Keys.GMajor, relationship.BestKeys);
    }

    [Fact]
    public void BestKeys_Single_Test()
    {
        var aDom7 = new Chord(Pitches.ANatural, ChordQualities.Dom7);
        var dMin7 = new Chord(Pitches.DNatural, ChordQualities.Min7);
        var relationship = new ChordalRelationship(aDom7, dMin7);
        Assert.Single(relationship.BestKeys);
        Assert.Equal(Keys.DMinor, relationship.BestKeys.Single());
    }
}
