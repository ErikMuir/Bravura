using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public record ChromaticScale(Pitch Root)
{
    public static Mode Mode => Modes.Chromatic;

    public List<Pitch> Pitches => new Scale(Root, Mode).Pitches.Select(PreferredPitch).ToList();

    public bool EnharmonicallyEquals(ChromaticScale other)
        => other != null
            && Root.EnharmonicallyEquals(other.Root)
            && Mode.Equals(Mode);

    private Pitch PreferredPitch(Pitch pitch)
    {
        var logicalPitch = pitch.Equals(Root) ? pitch : pitch.Logical;
        return Root.IsFlat || Root.Note.Letter == 'C' || Root.Note.Letter == 'F'
            ? logicalPitch.IsSharp
                ? Bravura.Tonality.Pitches.Flats.Single(p => p.EnharmonicallyEquals(logicalPitch))
                : logicalPitch
            : logicalPitch.IsFlat
                ? Bravura.Tonality.Pitches.Sharps.Single(p => p.EnharmonicallyEquals(logicalPitch))
                : logicalPitch;
    }
}
