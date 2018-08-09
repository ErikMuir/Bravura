using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Exceptions;
using Bravura.Extensions;

namespace Bravura.Theory
{
    public struct Pitch
    {
        public Note Note { get; }
        public Accidental Accidental { get; }

        internal Pitch(Note note, Accidental accidental)
        {
            Note = note;
            Accidental = accidental;
        }

        public int SemitonesAboveC
            => (Note.SemitonesAboveC + Accidental.SemitonesAwayFromNatural).RollingRange(11);

        public Pitch Logical()
        {
            switch (Accidental.SemitonesAwayFromNatural)
            {
                case -2:
                    return new Pitch(
                        Note.LowerNeighbor(),
                        Note.IsLowerNeighborNatural()
                            ? Accidentals.Flat
                            : Accidentals.Natural);
                case -1:
                    return Note.IsLowerNeighborNatural()
                        ? new Pitch(Note.LowerNeighbor(), Accidentals.Natural)
                        : new Pitch(Note, Accidental);
                case 0:
                    return new Pitch(Note, Accidental);
                case 1:
                    return Note.IsHigherNeighborNatural()
                        ? new Pitch(Note.HigherNeighbor(), Accidentals.Natural)
                        : new Pitch(Note, Accidental);
                case 2:
                    return new Pitch(
                        Note.HigherNeighbor(),
                        Note.IsHigherNeighborNatural()
                            ? Accidentals.Sharp
                            : Accidentals.Natural);
                default:
                    throw new BravuraException("An Accidental's SemitonesAwayFromNatural must be between -2 and 2.");
            }
        }

        public Pitch Lower()
        {
            switch (Accidental.SemitonesAwayFromNatural)
            {
                case -2:
                    return new Pitch(
                        Note.LowerNeighbor(),
                        Note.IsLowerNeighborNatural()
                            ? Accidentals.Flat
                            : Accidentals.Natural);
                case -1:
                    return Note.IsLowerNeighborNatural()
                        ? new Pitch(Note.LowerNeighbor(), Accidentals.Natural)
                        : new Pitch(Note, Accidental);
                case 0:
                    return Note.IsLowerNeighborNatural()
                        ? new Pitch(Note.LowerNeighbor(), Accidentals.Sharp)
                        : new Pitch(Note, Accidental);
                case 1:
                    return new Pitch(Note, Accidental);
                case 2:
                    return new Pitch(Note, Accidental);
                default:
                    throw new BravuraException("An Accidental's SemitonesAwayFromNatural must be between -2 and 2.");
            }
        }

        public Pitch Higher()
        {
            switch (Accidental.SemitonesAwayFromNatural)
            {
                case -2:
                    return new Pitch(Note, Accidental);
                case -1:
                    return new Pitch(Note, Accidental);
                case 0:
                    return Note.IsHigherNeighborNatural()
                        ? new Pitch(Note.HigherNeighbor(), Accidentals.Flat)
                        : new Pitch(Note, Accidental);
                case 1:
                    return Note.IsHigherNeighborNatural()
                        ? new Pitch(Note.HigherNeighbor(), Accidentals.Natural)
                        : new Pitch(Note, Accidental);
                case 2:
                    return new Pitch(
                        Note.HigherNeighbor(),
                        Note.IsHigherNeighborNatural()
                            ? Accidentals.Sharp
                            : Accidentals.Natural);
                default:
                    throw new BravuraException("An Accidental's SemitonesAwayFromNatural must be between -2 and 2.");
            }
        }

        public Pitch GetPitchByInterval(Interval interval)
        {
            // TODO : figure out how this works and document it
            var noteIndex = (Note.Index() + interval.NoteIndex - 1).RollingRange(6);
            var note = Notes.AllNotes[noteIndex];

            var value = SemitonesAboveC + interval.Semitones - note.SemitonesAboveC;
            if (value < -2) value += 12;
            else if (value > 2) value -= 12;
            var accidental = Accidentals.AllAccidentals.Single(a => a.SemitonesAwayFromNatural == value);

            return new Pitch(note, accidental);
        }

        #region -- String Methods --

        public override string ToString()
            => $"{Note.Letter}{Accidental.DefaultSymbol}";

        public string ToAsciiString()
            => $"{Note.Letter}{Accidental.AsciiSymbol}";

        #endregion

        #region -- Equality Methods --

        public static bool operator ==(Pitch a, Pitch b)
            => a.Note == b.Note &&
               a.Accidental == b.Accidental;

        public static bool operator !=(Pitch a, Pitch b)
            => !(a == b);

        public override bool Equals(object obj)
        {
            if (!(obj is Pitch)) return false;
            var pitch = (Pitch)obj;
            return EqualityComparer<Note>.Default.Equals(Note, pitch.Note) &&
                   EqualityComparer<Accidental>.Default.Equals(Accidental, pitch.Accidental);
        }

        public override int GetHashCode()
            => HashCode.Combine(Note, Accidental);

        public bool EnharmonicallyEquals(object obj)
        {
            if (!(obj is Pitch)) return false;
            var pitch = (Pitch)obj;
            return SemitonesAboveC == pitch.SemitonesAboveC;
        }

        #endregion
    }
}