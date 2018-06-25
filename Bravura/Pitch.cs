using System.Linq;

namespace Bravura
{
    public struct Pitch
    {
        public NoteName NoteName { get; }
        public Accidental Accidental { get; }
        public int Value { get; }
        public NoteSymbol InitialSymbol { get; }
        public NoteSymbol LogicalSymbol { get; }
        public NoteSymbol LowerSymbol { get; }
        public NoteSymbol HigherSymbol { get; }

        public Pitch(NoteName note, Accidental accidental)
        {
            var value = (note.Value + accidental.Value);
            if (value < 0) value += 12;
            else if (value >= 12) value -= 12;

            var logicalAlphabet = note;
            var lowerAlphabet = note;
            var higherAlphabet = note;
            var logicalAccidental = accidental;
            var lowerAccidental = accidental;
            var higherAccidental = accidental;

            switch (accidental.Value)
            {
                case -2:
                    logicalAlphabet = note.LowerNeighbor;
                    logicalAccidental = note.IsLowerNeighborHalfstep 
                        ? Accidentals.Flat 
                        : Accidentals.Natural;
                    lowerAlphabet = logicalAlphabet;
                    lowerAccidental = logicalAccidental;
                    break;
                case -1:
                    if (note.IsLowerNeighborHalfstep)
                    {
                        logicalAlphabet = note.LowerNeighbor;
                        logicalAccidental = Accidentals.Natural;
                        lowerAlphabet = logicalAlphabet;
                        lowerAccidental = logicalAccidental;
                    }
                    break;
                case 0:
                    if (note.IsLowerNeighborHalfstep)
                    {
                        lowerAlphabet = note.LowerNeighbor;
                        lowerAccidental = Accidentals.Sharp;
                    }
                    if (note.IsHigherNeighborHalfstep)
                    {
                        higherAlphabet = note.HigherNeighbor;
                        higherAccidental = Accidentals.Flat;
                    }
                    break;
                case 1:
                    if (note.IsHigherNeighborHalfstep)
                    {
                        logicalAlphabet = note.HigherNeighbor;
                        logicalAccidental = Accidentals.Natural;
                        higherAlphabet = logicalAlphabet;
                        higherAccidental = logicalAccidental;
                    }
                    break;
                case 2:
                    logicalAlphabet = note.HigherNeighbor;
                    logicalAccidental = note.IsHigherNeighborHalfstep 
                        ? Accidentals.Sharp 
                        : Accidentals.Natural;
                    higherAlphabet = logicalAlphabet;
                    higherAccidental = logicalAccidental;
                    break;
            }

            NoteName = note;
            Accidental = accidental;
            Value = value;
            InitialSymbol = new NoteSymbol(note, accidental);
            LogicalSymbol = new NoteSymbol(logicalAlphabet, logicalAccidental);
            LowerSymbol = new NoteSymbol(lowerAlphabet, lowerAccidental);
            HigherSymbol = new NoteSymbol(higherAlphabet, higherAccidental);
        }

        public Pitch GetPitchByInterval(Interval interval)
        {
            var noteNameIndex = NoteName.Index + interval.NoteIndex - 1;
            if (noteNameIndex >= 7) noteNameIndex -= 7;
            var note = NoteNames.AllNotes[noteNameIndex];

            var value = Value + interval.Semitones - note.Value;
            if (value < -2) value += 12;
            else if (value > 2) value -= 12;
            var accidental = Accidentals.AllAccidentals.Single(a => a.Value == value);

            return new Pitch(note, accidental);
        }

        public override string ToString()
        {
            return InitialSymbol.ToString();
        }
    }
}