using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality
{
    public record Scale(Pitch Root, Mode Mode)
    {
        public List<Pitch> Pitches => Mode.Intervals.Select(i => Root.GetPitchByIntervalAbove(i)).ToList();
        public bool EnharmonicallyEquals(Scale other) => other != null && Root.EnharmonicallyEquals(other.Root) && Mode.Equals(other.Mode);

        public override string ToString() => $"{ Root } { Mode }";
        public string ToAsciiString() => $"{ Root.ToAsciiString() } { Mode }";
        public string ToStringWithPitches() => $"{ Root } { Mode } {{ { string.Join(" ", Pitches.Select(p => p.ToString()))} }}";
        public string ToAsciiStringWithPitches() => $"{ Root.ToAsciiString() } { Mode } {{ { string.Join(" ", Pitches.Select(p => p.ToAsciiString())) } }}";
    }
}
