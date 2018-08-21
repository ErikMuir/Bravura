using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Bravura.Exceptions;
using Bravura.Extensions;

namespace Bravura
{
    public static partial class Theory
    {
        public class Pitch
        {
            #region -- Constructor --

            internal Pitch(Note note, Accidental accidental)
            {
                Note = note;

                Accidental = accidental;
            }

            #endregion

            #region -- Properties --

            public Note Note { get; }
            public Accidental Accidental { get; }
            public short SemitonesAboveC
                => (short)(Note.SemitonesAboveC + Accidental.SemitonesAwayFromNatural).RollingRange(11);

            #endregion

            #region -- Methods --

            public Pitch Logical()
            {
                switch (Accidental.SemitonesAwayFromNatural)
                {
                    case -2:
                        return new Pitch(
                            Note.LowerNeighbor(),
                            Note.IsLowerNeighborNatural()
                                ? Flat
                                : Natural);
                    case -1:
                        return Note.IsLowerNeighborNatural()
                            ? new Pitch(Note.LowerNeighbor(), Natural)
                            : new Pitch(Note, Accidental);
                    case 0:
                        return new Pitch(Note, Accidental);
                    case 1:
                        return Note.IsHigherNeighborNatural()
                            ? new Pitch(Note.HigherNeighbor(), Natural)
                            : new Pitch(Note, Accidental);
                    case 2:
                        return new Pitch(
                            Note.HigherNeighbor(),
                            Note.IsHigherNeighborNatural()
                                ? Sharp
                                : Natural);
                    default:
                        throw new BravuraException("Invalid accidental");
                }
            }

            public Pitch GetPitchByIntervalAbove(Interval interval)
            {
                var noteIndex = (Note.Index() + (interval.NoteIndex - 1)).RollingRange(6);
                var note = Utilities.GetNoteByIndex(noteIndex);

                var semitones = SemitonesAboveC + interval.Semitones - note.SemitonesAboveC;
                if (semitones < -2) semitones += 12;
                else if (semitones > 2) semitones -= 12;
                var accidental = Accidentals.Single(a => a.SemitonesAwayFromNatural == semitones);

                return new Pitch(note, accidental);
            }

            public Pitch GetPitchByIntervalBelow(Interval interval)
            {
                var noteIndex = (Note.Index() - (interval.NoteIndex - 1)).RollingRange(6);
                var note = Utilities.GetNoteByIndex(noteIndex);

                var semitones = SemitonesAboveC - interval.Semitones - note.SemitonesAboveC;
                if (semitones < -2) semitones += 12;
                else if (semitones > 2) semitones -= 12;
                var accidental = Accidentals.Single(a => a.SemitonesAwayFromNatural == semitones);

                return new Pitch(note, accidental);
            }

            public bool EnharmonicallyEquals(object obj)
            {
                if (!(obj is Pitch)) return false;
                var pitch = (Pitch)obj;
                return SemitonesAboveC == pitch.SemitonesAboveC;
            }

            public string ToString(bool showActual = false)
                => $"{Note.Letter}{(Accidental.SemitonesAwayFromNatural == 0 && !showActual ? "" : Accidental.Symbol)}";

            public string ToAsciiString()
                => $"{Note.Letter}{Accidental.AsciiSymbol}";

            #endregion
        }

        #region -- Pitches --

        #region -- Double Flats --

        public static Pitch CDoubleFlat { get; private set; }
        public static Pitch DDoubleFlat { get; private set; }
        public static Pitch EDoubleFlat { get; private set; }
        public static Pitch FDoubleFlat { get; private set; }
        public static Pitch GDoubleFlat { get; private set; }
        public static Pitch ADoubleFlat { get; private set; }
        public static Pitch BDoubleFlat { get; private set; }

        #endregion

        #region -- Flats --

        public static Pitch CFlat { get; private set; }
        public static Pitch DFlat { get; private set; }
        public static Pitch EFlat { get; private set; }
        public static Pitch FFlat { get; private set; }
        public static Pitch GFlat { get; private set; }
        public static Pitch AFlat { get; private set; }
        public static Pitch BFlat { get; private set; }

        #endregion

        #region -- Naturals --

        public static Pitch CNatural { get; private set; }
        public static Pitch DNatural { get; private set; }
        public static Pitch ENatural { get; private set; }
        public static Pitch FNatural { get; private set; }
        public static Pitch GNatural { get; private set; }
        public static Pitch ANatural { get; private set; }
        public static Pitch BNatural { get; private set; }

        #endregion

        #region -- Sharps --

        public static Pitch CSharp { get; private set; }
        public static Pitch DSharp { get; private set; }
        public static Pitch ESharp { get; private set; }
        public static Pitch FSharp { get; private set; }
        public static Pitch GSharp { get; private set; }
        public static Pitch ASharp { get; private set; }
        public static Pitch BSharp { get; private set; }

        #endregion

        #region -- Double Sharps --

        public static Pitch CDoubleSharp { get; private set; }
        public static Pitch DDoubleSharp { get; private set; }
        public static Pitch EDoubleSharp { get; private set; }
        public static Pitch FDoubleSharp { get; private set; }
        public static Pitch GDoubleSharp { get; private set; }
        public static Pitch ADoubleSharp { get; private set; }
        public static Pitch BDoubleSharp { get; private set; }

        #endregion

        #region -- Collections --

        public static ReadOnlyCollection<Pitch> DoubleFlats { get; private set; }
        public static ReadOnlyCollection<Pitch> Flats { get; private set; }
        public static ReadOnlyCollection<Pitch> Naturals { get; private set; }
        public static ReadOnlyCollection<Pitch> Sharps { get; private set; }
        public static ReadOnlyCollection<Pitch> DoubleSharps { get; private set; }
        public static ReadOnlyCollection<Pitch> SignatureFlats { get; private set; }
        public static ReadOnlyCollection<Pitch> SignatureSharps { get; private set; }
        public static ReadOnlyCollection<Pitch> SignatureAccidentals { get; private set; }
        public static ReadOnlyCollection<Pitch> Pitches { get; private set; }

        #endregion

        #endregion 

        static partial void SetPitches()
        {
            #region -- Double Flats --

            CDoubleFlat = new Pitch(C, DoubleFlat);
            DDoubleFlat = new Pitch(D, DoubleFlat);
            EDoubleFlat = new Pitch(E, DoubleFlat);
            FDoubleFlat = new Pitch(F, DoubleFlat);
            GDoubleFlat = new Pitch(G, DoubleFlat);
            ADoubleFlat = new Pitch(A, DoubleFlat);
            BDoubleFlat = new Pitch(B, DoubleFlat);

            #endregion

            #region -- Flats --

            CFlat = new Pitch(C, Flat);
            DFlat = new Pitch(D, Flat);
            EFlat = new Pitch(E, Flat);
            FFlat = new Pitch(F, Flat);
            GFlat = new Pitch(G, Flat);
            AFlat = new Pitch(A, Flat);
            BFlat = new Pitch(B, Flat);

            #endregion

            #region -- Naturals --

            CNatural = new Pitch(C, Natural);
            DNatural = new Pitch(D, Natural);
            ENatural = new Pitch(E, Natural);
            FNatural = new Pitch(F, Natural);
            GNatural = new Pitch(G, Natural);
            ANatural = new Pitch(A, Natural);
            BNatural = new Pitch(B, Natural);

            #endregion

            #region -- Sharps --

            CSharp = new Pitch(C, Sharp);
            DSharp = new Pitch(D, Sharp);
            ESharp = new Pitch(E, Sharp);
            FSharp = new Pitch(F, Sharp);
            GSharp = new Pitch(G, Sharp);
            ASharp = new Pitch(A, Sharp);
            BSharp = new Pitch(B, Sharp);

            #endregion

            #region -- Double Sharps --

            CDoubleSharp = new Pitch(C, DoubleSharp);
            DDoubleSharp = new Pitch(D, DoubleSharp);
            EDoubleSharp = new Pitch(E, DoubleSharp);
            FDoubleSharp = new Pitch(F, DoubleSharp);
            GDoubleSharp = new Pitch(G, DoubleSharp);
            ADoubleSharp = new Pitch(A, DoubleSharp);
            BDoubleSharp = new Pitch(B, DoubleSharp);

            #endregion

            #region -- Collections --

            DoubleFlats = new List<Pitch>
            {
                CDoubleFlat,
                DDoubleFlat,
                EDoubleFlat,
                FDoubleFlat,
                GDoubleFlat,
                ADoubleFlat,
                BDoubleFlat,
            }.AsReadOnly();

            Flats = new List<Pitch>
            {
                CFlat,
                DFlat,
                EFlat,
                FFlat,
                GFlat,
                AFlat,
                BFlat,
            }.AsReadOnly();

            Naturals = new List<Pitch>
            {
                CNatural,
                DNatural,
                ENatural,
                FNatural,
                GNatural,
                ANatural,
                BNatural,
            }.AsReadOnly();

            Sharps = new List<Pitch>
            {
                CSharp,
                DSharp,
                ESharp,
                FSharp,
                GSharp,
                ASharp,
                BSharp,
            }.AsReadOnly();

            DoubleSharps = new List<Pitch>
            {
                CDoubleSharp,
                DDoubleSharp,
                EDoubleSharp,
                FDoubleSharp,
                GDoubleSharp,
                ADoubleSharp,
                BDoubleSharp,
            }.AsReadOnly();

            SignatureFlats = new List<Pitch>
            {
                BFlat,
                EFlat,
                AFlat,
                DFlat,
                GFlat,
                CFlat,
                FFlat,
            }.AsReadOnly();

            SignatureSharps = new List<Pitch>
            {
                FSharp,
                CSharp,
                GSharp,
                DSharp,
                ASharp,
                ESharp,
                BSharp,
            }.AsReadOnly();

            SignatureAccidentals = new List<Pitch>
            {
                BFlat,
                EFlat,
                AFlat,
                DFlat,
                GFlat,
                CFlat,
                FFlat,
                FSharp,
                CSharp,
                GSharp,
                DSharp,
                ASharp,
                ESharp,
                BSharp,
            }.AsReadOnly();

            Pitches = new List<Pitch>
            {
                CDoubleFlat,
                DDoubleFlat,
                EDoubleFlat,
                FDoubleFlat,
                GDoubleFlat,
                ADoubleFlat,
                BDoubleFlat,
                CFlat,
                DFlat,
                EFlat,
                FFlat,
                GFlat,
                AFlat,
                BFlat,
                CNatural,
                DNatural,
                ENatural,
                FNatural,
                GNatural,
                ANatural,
                BNatural,
                CSharp,
                DSharp,
                ESharp,
                FSharp,
                GSharp,
                ASharp,
                BSharp,
                CDoubleSharp,
                DDoubleSharp,
                EDoubleSharp,
                FDoubleSharp,
                GDoubleSharp,
                ADoubleSharp,
                BDoubleSharp,
            }.AsReadOnly();

            #endregion
        }
    }
}