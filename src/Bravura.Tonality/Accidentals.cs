using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Bravura.Tonality;

public static class Accidentals
{
    public static readonly Accidental DoubleFlat = new(-2, "Double Flat", "♭♭");
    public static readonly Accidental Flat = new(-1, "Flat", "♭");
    public static readonly Accidental Natural = new(0, "Natural", "♮");
    public static readonly Accidental Sharp = new(1, "Sharp", "♯");
    public static readonly Accidental DoubleSharp = new(2, "Double Sharp", "♯♯");

    public static readonly ReadOnlyCollection<Accidental> AllAccidentals = new List<Accidental>
    {
        DoubleFlat,
        Flat,
        Natural,
        Sharp,
        DoubleSharp,
    }.AsReadOnly();
}
