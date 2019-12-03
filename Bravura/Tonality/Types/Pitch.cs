using System.Linq;
using Bravura.Exceptions;
using Bravura.Extensions;

namespace Bravura
{
    public static partial class Tonality
    {
        public class Pitch
        {
            internal Pitch(Note note, Accidental accidental)
            {
                Note = note;

                Accidental = accidental;
            }

            public Note Note { get; }

            public Accidental Accidental { get; }

            public short SemitonesAboveC
                => (short)(Note.SemitonesAboveC + Accidental.SemitonesAwayFromNatural).RollingRange(11);

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
        }
    }
}