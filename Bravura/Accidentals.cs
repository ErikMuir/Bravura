using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bravura.Constants;
using Bravura.Theory;

namespace Bravura
{
    public static class Accidentals
    {
        public static readonly Accidental DoubleFlat = new Accidental(
            -2,
            AccidentalNames.DoubleFlat,
            AccidentalSymbols.DoubleFlat,
            AccidentalSymbols.DoubleFlat,
            AccidentalAsciiSymbols.DoubleFlat);

        public static readonly Accidental Flat = new Accidental(
            -1,
            AccidentalNames.Flat,
            AccidentalSymbols.Flat,
            AccidentalSymbols.Flat,
            AccidentalAsciiSymbols.Flat);

        public static readonly Accidental Natural = new Accidental(
            0,
            AccidentalNames.Natural,
            string.Empty,
            AccidentalSymbols.Natural,
            AccidentalAsciiSymbols.Natural);

        public static readonly Accidental Sharp = new Accidental(
            1,
            AccidentalNames.Sharp,
            AccidentalSymbols.Sharp,
            AccidentalSymbols.Sharp,
            AccidentalAsciiSymbols.Sharp);

        public static readonly Accidental DoubleSharp = new Accidental(
            2,
            AccidentalNames.DoubleSharp,
            AccidentalSymbols.DoubleSharp,
            AccidentalSymbols.DoubleSharp,
            AccidentalAsciiSymbols.DoubleSharp);

        public static readonly ReadOnlyCollection<Accidental> AllAccidentals =
            new List<Accidental>
            {
                DoubleFlat,
                Flat,
                Natural,
                Sharp,
                DoubleSharp,
            }.AsReadOnly();
    }
}