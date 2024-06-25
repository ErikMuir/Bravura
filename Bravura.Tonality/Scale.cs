using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public record Scale(Pitch Root, Mode Mode) : IBaseTonality
{
    public List<Pitch> Pitches => Mode.Intervals.Select(i => Root.Transpose(Direction.Up, i)).ToList();

    public bool EnharmonicallyEquals(Scale other) => other != null && Root.EnharmonicallyEquals(other.Root) && Mode.Equals(other.Mode);

    public string DisplayValue(bool onlyAscii = false) => $"{Root.DisplayValue(onlyAscii)} {Mode.DisplayValue(onlyAscii)}";

    public string DisplayValueWithPitches(bool onlyAscii = false) => $"{DisplayValue(onlyAscii)} {{ {Pitches.DisplayValue(onlyAscii)} }}";

    public Scale Transpose(Direction direction, Interval interval)
    {
        var newRoot = Root.Transpose(direction, interval);
        return new Scale(newRoot, Mode);
    }
}
