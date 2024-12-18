using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality;

public record Pitch : ITonality
{
    internal Pitch(Note note, Accidental accidental)
    {
        Note = note;
        Accidental = accidental;
    }

    public Note Note { get; init; }
    public Accidental Accidental { get; init; }
    public short SemitonesAboveC => (short)(Note.SemitonesAboveC + Accidental.SemitonesAwayFromNatural).RollingRange(11);
    public bool IsFlat => Accidental.SemitonesAwayFromNatural < 0;
    public bool IsSharp => Accidental.SemitonesAwayFromNatural > 0;
    public Pitch Logical => Accidental.SemitonesAwayFromNatural switch
    {
        -2 => new Pitch(
            Note.PreviousNote,
            Note.IsPreviousNoteOneSemitoneAway()
                ? Accidentals.Flat
                : Accidentals.Natural),
        -1 => Note.IsPreviousNoteOneSemitoneAway()
            ? new Pitch(Note.PreviousNote, Accidentals.Natural)
            : new Pitch(Note, Accidental),
        0 => new Pitch(Note, Accidental),
        1 => Note.IsNextNoteOneSemitoneAway()
            ? new Pitch(Note.NextNote, Accidentals.Natural)
            : new Pitch(Note, Accidental),
        2 => new Pitch(
            Note.NextNote,
            Note.IsNextNoteOneSemitoneAway()
                ? Accidentals.Sharp
                : Accidentals.Natural),
        _ => this,
    };

    public Pitch Transpose(Direction direction, Interval interval)
    {
        var noteIndex = direction == Direction.Up
            ? (Note.Index + (interval.Degree - 1)).RollingRange(6)
            : (Note.Index - (interval.Degree - 1)).RollingRange(6);
        var note = Note.GetNoteByIndex(noteIndex);

        var semitones = direction == Direction.Up
            ? SemitonesAboveC + interval.Semitones - note.SemitonesAboveC
            : SemitonesAboveC - interval.Semitones - note.SemitonesAboveC;
        if (semitones < -2) semitones += 12;
        else if (semitones > 2) semitones -= 12;
        var accidental = Accidentals.AllAccidentals.Single(a => a.SemitonesAwayFromNatural == semitones);

        return new Pitch(note, accidental);
    }

    public bool EnharmonicallyEquals(Pitch other) => SemitonesAboveC == other?.SemitonesAboveC;

    public static bool TryParse(string val, out Pitch pitch)
    {
        pitch = null;
        if (val == null) return false;
        var trimmedVal = val.Trim();
        foreach (var p in Pitches.AllPitches)
        {
            if (p.ToString() != trimmedVal && p.ToString().ToAscii() != trimmedVal) continue;
            pitch = p;
            return true;
        }
        return false;
    }

    public override string ToString() => $"{Note}{(Accidental.SemitonesAwayFromNatural == 0 ? "" : Accidental)}";

    public string ToStringWithNaturals() => $"{Note}{Accidental}";
}
