using System.Collections.Generic;
using System.Linq;

namespace Bravura
{
    public struct Scale
    {
        public Pitch Root { get; }
        public Mode Mode { get; }
        public List<Pitch> ScalePitches { get; }

        public Scale(Pitch root, Mode mode)
        {
            Root = root;
            Mode = mode;
            ScalePitches = new List<Pitch>();
            SetScalePitches();
        }

        private void SetScalePitches()
        {
            for (var i = 0; i < Mode.Intervals.Count; i++)
            {
                var note = GetNote(i);
                var accidental = GetAccidental(i, note.Value);
                ScalePitches.Add(new Pitch(note, accidental));
            }
        }

        private NoteName GetNote(int index)
        {
            var noteIndex = Mode.NoteIndices[index] + Root.NoteName.Index;
            if (noteIndex > 6) noteIndex -= 7;
            return NoteNames.AllNotes.Single(a => a.Index == noteIndex);
        }

        private Accidental GetAccidental(int index, int noteValue)
        {
            var pitchValue = Mode.Intervals[index].Semitones + Root.Value;
            if (pitchValue > 11) pitchValue -= 12;
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
            return Accidentals.AllAccidentals.Single(a => a.Value == accidentalValue);
        }
    }
}