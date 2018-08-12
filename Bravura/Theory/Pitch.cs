﻿using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Exceptions;
using Bravura.Extensions;

namespace Bravura
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
                            ? Theory.Flat
                            : Theory.Natural);
                case -1:
                    return Note.IsLowerNeighborNatural()
                        ? new Pitch(Note.LowerNeighbor(), Theory.Natural)
                        : new Pitch(Note, Accidental);
                case 0:
                    return new Pitch(Note, Accidental);
                case 1:
                    return Note.IsHigherNeighborNatural()
                        ? new Pitch(Note.HigherNeighbor(), Theory.Natural)
                        : new Pitch(Note, Accidental);
                case 2:
                    return new Pitch(
                        Note.HigherNeighbor(),
                        Note.IsHigherNeighborNatural()
                            ? Theory.Sharp
                            : Theory.Natural);
                default:
                    throw new BravuraException("Invalid accidental");
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
                            ? Theory.Flat
                            : Theory.Natural);
                case -1:
                    return Note.IsLowerNeighborNatural()
                        ? new Pitch(Note.LowerNeighbor(), Theory.Natural)
                        : new Pitch(Note, Accidental);
                case 0:
                    return Note.IsLowerNeighborNatural()
                        ? new Pitch(Note.LowerNeighbor(), Theory.Sharp)
                        : new Pitch(Note, Accidental);
                case 1:
                    return new Pitch(Note, Accidental);
                case 2:
                    return new Pitch(Note, Accidental);
                default:
                    throw new BravuraException("Invalid accidental");
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
                        ? new Pitch(Note.HigherNeighbor(), Theory.Flat)
                        : new Pitch(Note, Accidental);
                case 1:
                    return Note.IsHigherNeighborNatural()
                        ? new Pitch(Note.HigherNeighbor(), Theory.Natural)
                        : new Pitch(Note, Accidental);
                case 2:
                    return new Pitch(
                        Note.HigherNeighbor(),
                        Note.IsHigherNeighborNatural()
                            ? Theory.Sharp
                            : Theory.Natural);
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
            var accidental = Theory.AllAccidentals.Single(a => a.SemitonesAwayFromNatural == semitones);

            return new Pitch(note, accidental);
        }

        public Pitch GetPitchByIntervalBelow(Interval interval)
        {
            var noteIndex = (Note.Index() - (interval.NoteIndex - 1)).RollingRange(6);
            var note = Utilities.GetNoteByIndex(noteIndex);

            var semitones = SemitonesAboveC - interval.Semitones - note.SemitonesAboveC;
            if (semitones < -2) semitones += 12;
            else if (semitones > 2) semitones -= 12;
            var accidental = Theory.AllAccidentals.Single(a => a.SemitonesAwayFromNatural == semitones);

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