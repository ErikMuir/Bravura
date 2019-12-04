using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bravura.Constants;

namespace Bravura.Tonality
{
    static class Accidentals
    {
        static Accidentals()
        {
            DoubleFlat = new Accidental(
                -2,
                AccidentalNames.DoubleFlat,
                AccidentalSymbols.DoubleFlat,
                AccidentalAsciiSymbols.DoubleFlat);

            Flat = new Accidental(
                -1,
                AccidentalNames.Flat,
                AccidentalSymbols.Flat,
                AccidentalAsciiSymbols.Flat);

            Natural = new Accidental(
                0,
                AccidentalNames.Natural,
                AccidentalSymbols.Natural,
                AccidentalAsciiSymbols.Natural);

            Sharp = new Accidental(
                1,
                AccidentalNames.Sharp,
                AccidentalSymbols.Sharp,
                AccidentalAsciiSymbols.Sharp);

            DoubleSharp = new Accidental(
                2,
                AccidentalNames.DoubleSharp,
                AccidentalSymbols.DoubleSharp,
                AccidentalAsciiSymbols.DoubleSharp);

            AllAccidentals = new List<Accidental>
            { 
                DoubleFlat,
                Flat,
                Natural,
                Sharp,
                DoubleSharp,
            }.AsReadOnly();
        }

        public static readonly Accidental DoubleFlat;
        public static readonly Accidental Flat;
        public static readonly Accidental Natural;
        public static readonly Accidental Sharp;
        public static readonly Accidental DoubleSharp;
        public static readonly ReadOnlyCollection<Accidental> AllAccidentals;
    }
}