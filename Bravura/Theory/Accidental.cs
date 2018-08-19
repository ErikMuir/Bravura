using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bravura.Constants;

namespace Bravura
{
    public static partial class Theory
    {
        public struct Accidental
        {
            #region -- Constructor --

            internal Accidental(
                short semitonesAwayFromNatural,
                string name,
                string symbol,
                string asciiSymbol)
            {
                SemitonesAwayFromNatural = semitonesAwayFromNatural;
                Name = name;
                Symbol = symbol;
                AsciiSymbol = asciiSymbol;
            }

            #endregion

            #region -- Properties --

            public short SemitonesAwayFromNatural { get; }
            public string Name { get; }
            public string Symbol { get; }
            public string AsciiSymbol { get; }

            #endregion

            #region -- Equality Methods --

            public static bool operator ==(Accidental a, Accidental b)
                => a.SemitonesAwayFromNatural == b.SemitonesAwayFromNatural;

            public static bool operator !=(Accidental a, Accidental b)
                => !(a == b);

            public override bool Equals(object obj)
            {
                if (!(obj is Accidental)) return false;
                var accidental = (Accidental)obj;
                return SemitonesAwayFromNatural == accidental.SemitonesAwayFromNatural;
            }

            public override int GetHashCode()
                => HashCode.Combine(SemitonesAwayFromNatural);

            #endregion
        }

        #region -- Accidental Singletons --

        public static Accidental DoubleFlat { get; private set; }
        public static Accidental Flat { get; private set; }
        public static Accidental Natural { get; private set; }
        public static Accidental Sharp { get; private set; }
        public static Accidental DoubleSharp { get; private set; }
        public static ReadOnlyCollection<Accidental> Accidentals { get; private set; }

        #endregion 

        static partial void SetAccidentals()
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
            Accidentals = new List<Accidental>
            {
                DoubleFlat,
                Flat,
                Natural,
                Sharp,
                DoubleSharp,
            }.AsReadOnly();
        }
    }
}