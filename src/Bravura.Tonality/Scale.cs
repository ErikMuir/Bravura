using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public record Scale(Pitch Root, Mode Mode) : ITonality
{
    public List<Pitch> Pitches => Mode.Intervals.Select(i => Root.Transpose(Direction.Up, i)).ToList();

    public bool EnharmonicallyEquals(Scale other) => other != null && Root.EnharmonicallyEquals(other.Root) && Mode.Equals(other.Mode);

    public Scale Transpose(Direction direction, Interval interval)
    {
        var newRoot = Root.Transpose(direction, interval);
        return new Scale(newRoot, Mode);
    }

    public override string ToString() => $"{Root} {Mode}";
}
