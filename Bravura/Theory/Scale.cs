using System.Collections.Generic;
using System.Linq;
using Bravura.Extensions;

namespace Bravura
{
    public struct Scale
    {
        public Pitch Root { get; }
        public Mode Mode { get; }
        public List<Pitch> Pitches { get; }

        public Scale(Pitch root, Mode mode)
        {
            Root = root;
            Mode = mode;
            Pitches = new List<Pitch>();
            SetPitches();
        }

        private void SetPitches()
        {
            for (var i = 0; i < Mode.Intervals.Count; i++)
            {
                var note = GetNote(i);
                var accidental = GetAccidental(i, note.SemitonesAboveC);
                Pitches.Add(new Pitch(note, accidental));
            }
        }

        private Note GetNote(int index)
        {
            var noteIndex = (Mode.NoteIndices[index] + Root.Note.Index()).RollingRange(6);
            return Utilities.GetNoteByIndex(noteIndex);
        }

        private Accidental GetAccidental(int index, int noteValue)
        {
            var pitchValue = (Mode.Intervals[index].Semitones + Root.SemitonesAboveC).RollingRange(11);
            var accidentalValue = (pitchValue - noteValue);
            switch (accidentalValue)
            {
                case -11:
                    accidentalValue = 1;
                    break;
                case -10:
                    accidentalValue = 2;
                    break;
                case 11:
                    accidentalValue = -1;
                    break;
                case 10:
                    accidentalValue = -2;
                    break;
            }
            return Accidentals.AllAccidentals.Single(a => a.SemitonesAwayFromNatural == accidentalValue);
        }
    }
}