using System.Collections.Generic;
using System.Linq;
using Bravura.Tonality.Extensions;

namespace Bravura.Tonality
{
    public class Scale
    {
        public Scale(Pitch root, Mode mode)
        {
            Root = root;
            Mode = mode;
            ScalePitches = new List<Pitch>();

            for (var i = 0; i < Mode.ModeIntervals.Count; i++)
            {
                var note = GetNote(i);
                var accidental = GetAccidental(i, note.SemitonesAboveC);
                ScalePitches.Add(new Pitch(note, accidental));
            }
        }

        public Pitch Root { get; }
        public Mode Mode { get; }
        public List<Pitch> ScalePitches { get; }

        private Note GetNote(int index)
        {
            var noteIndex = (Mode.NoteIndices[index] + Root.Note.Index()).RollingRange(6);
            return Note.GetNoteByIndex(noteIndex);
        }

        private Accidental GetAccidental(int index, int noteValue)
        {
            var pitchValue = (Mode.ModeIntervals[index].Semitones + Root.SemitonesAboveC).RollingRange(11);
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