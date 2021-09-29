using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public record Pitch(Note Note, Accidental Accidental)
    {
        public short SemitonesAboveC
            => (short)(Note.SemitonesAboveC + Accidental.SemitonesAwayFromNatural).RollingRange(11);
        public bool IsFlat => Accidental.SemitonesAwayFromNatural < 0;
        public bool IsSharp => Accidental.SemitonesAwayFromNatural > 0;

        public Pitch Logical()
        {
            switch (Accidental.SemitonesAwayFromNatural)
            {
                case -2:
                    return new Pitch(
                        Note.PreviousNote,
                        Note.IsPreviousNoteOneSemitoneAway()
                            ? Accidentals.Flat
                            : Accidentals.Natural);
                case -1:
                    return Note.IsPreviousNoteOneSemitoneAway()
                        ? new Pitch(Note.PreviousNote, Accidentals.Natural)
                        : new Pitch(Note, Accidental);
                case 0:
                    return new Pitch(Note, Accidental);
                case 1:
                    return Note.IsNextNoteOneSemitoneAway()
                        ? new Pitch(Note.NextNote, Accidentals.Natural)
                        : new Pitch(Note, Accidental);
                case 2:
                    return new Pitch(
                        Note.NextNote,
                        Note.IsNextNoteOneSemitoneAway()
                            ? Accidentals.Sharp
                            : Accidentals.Natural);
                default:
                    throw new BravuraTonalityException("Invalid accidental");
            }
        }

        public Pitch GetPitchByIntervalAbove(Interval interval)
        {
            var noteIndex = (Note.Index + interval.Degree).RollingRange(6);
            var note = Note.GetNoteByIndex(noteIndex);

            var semitones = SemitonesAboveC + interval.Semitones - note.SemitonesAboveC;
            if (semitones < -2) semitones += 12;
            else if (semitones > 2) semitones -= 12;
            var accidental = Accidentals.AllAccidentals.Single(a => a.SemitonesAwayFromNatural == semitones);

            return new Pitch(note, accidental);
        }

        public Pitch GetPitchByIntervalBelow(Interval interval)
        {
            var noteIndex = (Note.Index - interval.Degree).RollingRange(6);
            var note = Note.GetNoteByIndex(noteIndex);

            var semitones = SemitonesAboveC - interval.Semitones - note.SemitonesAboveC;
            if (semitones < -2) semitones += 12;
            else if (semitones > 2) semitones -= 12;
            var accidental = Accidentals.AllAccidentals.Single(a => a.SemitonesAwayFromNatural == semitones);

            return new Pitch(note, accidental);
        }

        public string ToString(bool showActual = false)
            => $"{Note.Letter}{(Accidental.SemitonesAwayFromNatural == 0 && !showActual ? "" : Accidental.Symbol)}";

        public string ToAsciiString()
            => $"{Note.Letter}{Accidental.AsciiSymbol}";

        public bool EnharmonicallyEquals(Pitch other)
            => SemitonesAboveC == other?.SemitonesAboveC;

        public static bool TryParse(string val, out Pitch pitch)
        {
            pitch = null;
            if (val == null) return false;
            var trimmedVal = val.Trim();
            foreach (var p in Pitches.AllPitches)
            {
                if (p.ToString() != trimmedVal && p.ToAsciiString() != trimmedVal) continue;
                pitch = p;
                return true;
            }
            return false;
        }
    }
}
