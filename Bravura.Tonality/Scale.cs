using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Scale : IEquatable<Scale>
    {
        public Scale(Pitch root, Mode mode)
        {
            Root = root;
            Mode = mode;

            Validate();

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

        private void Validate()
        {
            var errors = new List<string>();

            if (Root == null)
                errors.Add($"{nameof(Root)} is required.");
            if (Mode == null)
                errors.Add($"{nameof(Mode)} is required.");

            if (errors.Count > 0)
                throw new ScaleException(errors);
        }

        private Note GetNote(int index)
        {
            var noteIndex = (Mode.ModeIntervals[index].NoteIndexCount + Root.Note.Index).RollingRange(6);
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

        public bool EnharmonicallyEquals(Scale other)
            => other != null
                && Root.EnharmonicallyEquals(other.Root)
                && Mode.Equals(other.Mode);

        public bool Equals(Scale other)
        {
            if (other == null) return false;
            if (!Root.Equals(other.Root)) return false;
            if (!Mode.Equals(other.Mode)) return false;
            if (ScalePitches.Count != other.ScalePitches.Count) return false;
            for (var i = 0; i < ScalePitches.Count; i++)
            {
                if (!ScalePitches[i].Equals(other.ScalePitches[i])) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
            => (obj is Scale) && Equals((Scale)obj);

        public override int GetHashCode()
        {
            var hashCode = HashCode.Start
                .Hash(Root)
                .Hash(Mode);
            for (var i = 0; i < ScalePitches.Count; i++)
            {
                hashCode = hashCode.Hash(ScalePitches[i]);
            }
            return hashCode;
        }
    }
}