using System.Collections.Generic;
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

        var gMajorKey = analysis.GetValueOrDefault(Keys.GMajor);
        Assert.NotEmpty(gMajorKey);
        Assert.Equal("I", gMajorKey[0].RomanNumeralAnalysis());
        Assert.Equal("IV", gMajorKey[1].RomanNumeralAnalysis());

        var eMinorKey = analysis.GetValueOrDefault(Keys.EMinor);
        Assert.NotEmpty(eMinorKey);
        Assert.Equal("♭III", eMinorKey[0].RomanNumeralAnalysis());
        Assert.Equal("♭VI", eMinorKey[1].RomanNumeralAnalysis());

        var cMajorKey = analysis.GetValueOrDefault(Keys.CMajor);
        Assert.NotEmpty(cMajorKey);
        Assert.Equal("V", cMajorKey[0].RomanNumeralAnalysis());
        Assert.Equal("I", cMajorKey[1].RomanNumeralAnalysis());

        var aMinorKey = analysis.GetValueOrDefault(Keys.AMinor);
        Assert.NotEmpty(aMinorKey);
        Assert.Equal("♭VII", aMinorKey[0].RomanNumeralAnalysis());
        Assert.Equal("♭III", aMinorKey[1].RomanNumeralAnalysis());

        var dMajorKey = analysis.GetValueOrDefault(Keys.DMajor);
        Assert.NotEmpty(dMajorKey);
        Assert.Equal("IV", dMajorKey[0].RomanNumeralAnalysis());
        Assert.Equal("♭VII", dMajorKey[1].RomanNumeralAnalysis());

        var bMinorKey = analysis.GetValueOrDefault(Keys.BMinor);
        Assert.NotEmpty(bMinorKey);
        Assert.Equal("♭VI", bMinorKey[0].RomanNumeralAnalysis());
        Assert.Equal("♭II", bMinorKey[1].RomanNumeralAnalysis());

        var fMajorKey = analysis.GetValueOrDefault(Keys.FMajor);
        Assert.NotEmpty(fMajorKey);
        Assert.Equal("II", fMajorKey[0].RomanNumeralAnalysis());
        Assert.Equal("V", fMajorKey[1].RomanNumeralAnalysis());

        var dMinorKey = analysis.GetValueOrDefault(Keys.DMinor);
        Assert.NotEmpty(dMinorKey);
        Assert.Equal("IV", dMinorKey[0].RomanNumeralAnalysis());
        Assert.Equal("♭VII", dMinorKey[1].RomanNumeralAnalysis());
    }
}
