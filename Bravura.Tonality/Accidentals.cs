using System.Collections.Generic;
using System.Collections.ObjectModel;

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

        public static Accidental DoubleFlat { get; }
        public static Accidental Flat { get; }
        public static Accidental Natural { get; }
        public static Accidental Sharp { get; }
        public static Accidental DoubleSharp { get; }
        public static ReadOnlyCollection<Accidental> AllAccidentals { get; }
    }

    public static class AccidentalNames
    {
        public const string DoubleFlat = "Double Flat";
        public const string Flat = "Flat";
        public const string Natural = "Natural";
        public const string Sharp = "Sharp";
        public const string DoubleSharp = "Double Sharp";
    }

    public static class AccidentalSymbols
    {
        public const string DoubleFlat = "♭♭";
        public const string Flat = "♭";
        public const string Natural = "♮";
        public const string Sharp = "♯";
        public const string DoubleSharp = "♯♯";
    }

    public static class AccidentalAsciiSymbols
    {
        public const string DoubleFlat = "bb";
        public const string Flat = "b";
        public const string Natural = "";
        public const string Sharp = "#";
        public const string DoubleSharp = "##";
    }
}