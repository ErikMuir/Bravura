using Xunit;

namespace Bravura.Tonality.Tests
{
    public class NoteTests
    {
        [Fact]
        public void KeyValuePair_Test()
        {
            Assert.Equal('C', Notes.C.KeyValuePair.Key);
            Assert.Equal(0, Notes.C.KeyValuePair.Value);
            Assert.Equal('D', Notes.D.KeyValuePair.Key);
            Assert.Equal(2, Notes.D.KeyValuePair.Value);
            Assert.Equal('E', Notes.E.KeyValuePair.Key);
            Assert.Equal(4, Notes.E.KeyValuePair.Value);
            Assert.Equal('F', Notes.F.KeyValuePair.Key);
            Assert.Equal(5, Notes.F.KeyValuePair.Value);
            Assert.Equal('G', Notes.G.KeyValuePair.Key);
            Assert.Equal(7, Notes.G.KeyValuePair.Value);
            Assert.Equal('A', Notes.A.KeyValuePair.Key);
            Assert.Equal(9, Notes.A.KeyValuePair.Value);
            Assert.Equal('B', Notes.B.KeyValuePair.Key);
            Assert.Equal(11, Notes.B.KeyValuePair.Value);
        }

        [Fact]
        public void Index_Test()
        {
            Assert.Equal(0, Notes.C.Index);
            Assert.Equal(1, Notes.D.Index);
            Assert.Equal(2, Notes.E.Index);
            Assert.Equal(3, Notes.F.Index);
            Assert.Equal(4, Notes.G.Index);
            Assert.Equal(5, Notes.A.Index);
            Assert.Equal(6, Notes.B.Index);
        }

        [Fact]
        public void PreviousIndex_Test()
        {
            Assert.Equal(6, Notes.C.PreviousIndex);
            Assert.Equal(0, Notes.D.PreviousIndex);
            Assert.Equal(1, Notes.E.PreviousIndex);
            Assert.Equal(2, Notes.F.PreviousIndex);
            Assert.Equal(3, Notes.G.PreviousIndex);
            Assert.Equal(4, Notes.A.PreviousIndex);
            Assert.Equal(5, Notes.B.PreviousIndex);
        }

        [Fact]
        public void NextIndex_Test()
        {
            Assert.Equal(1, Notes.C.NextIndex);
            Assert.Equal(2, Notes.D.NextIndex);
            Assert.Equal(3, Notes.E.NextIndex);
            Assert.Equal(4, Notes.F.NextIndex);
            Assert.Equal(5, Notes.G.NextIndex);
            Assert.Equal(6, Notes.A.NextIndex);
            Assert.Equal(0, Notes.B.NextIndex);
        }

        [Fact]
        public void PreviousNote_Test()
        {
            Assert.Equal(Notes.B, Notes.C.PreviousNote);
            Assert.Equal(Notes.C, Notes.D.PreviousNote);
            Assert.Equal(Notes.D, Notes.E.PreviousNote);
            Assert.Equal(Notes.E, Notes.F.PreviousNote);
            Assert.Equal(Notes.F, Notes.G.PreviousNote);
            Assert.Equal(Notes.G, Notes.A.PreviousNote);
            Assert.Equal(Notes.A, Notes.B.PreviousNote);
        }

        [Fact]
        public void NextNote_Test()
        {
            Assert.Equal(Notes.D, Notes.C.NextNote);
            Assert.Equal(Notes.E, Notes.D.NextNote);
            Assert.Equal(Notes.F, Notes.E.NextNote);
            Assert.Equal(Notes.G, Notes.F.NextNote);
            Assert.Equal(Notes.A, Notes.G.NextNote);
            Assert.Equal(Notes.B, Notes.A.NextNote);
            Assert.Equal(Notes.C, Notes.B.NextNote);
        }

        [Fact]
        public void IsPreviousNoteOneSemitoneAway_Test()
        {
            Assert.True(Notes.C.IsPreviousNoteOneSemitoneAway());
            Assert.False(Notes.D.IsPreviousNoteOneSemitoneAway());
            Assert.False(Notes.E.IsPreviousNoteOneSemitoneAway());
            Assert.True(Notes.F.IsPreviousNoteOneSemitoneAway());
            Assert.False(Notes.G.IsPreviousNoteOneSemitoneAway());
            Assert.False(Notes.A.IsPreviousNoteOneSemitoneAway());
            Assert.False(Notes.B.IsPreviousNoteOneSemitoneAway());
        }

        [Fact]
        public void IsNextNoteOneSemitoneAway_Test()
        {
            Assert.False(Notes.C.IsNextNoteOneSemitoneAway());
            Assert.False(Notes.D.IsNextNoteOneSemitoneAway());
            Assert.True(Notes.E.IsNextNoteOneSemitoneAway());
            Assert.False(Notes.F.IsNextNoteOneSemitoneAway());
            Assert.False(Notes.G.IsNextNoteOneSemitoneAway());
            Assert.False(Notes.A.IsNextNoteOneSemitoneAway());
            Assert.True(Notes.B.IsNextNoteOneSemitoneAway());
        }

        [Fact]
        public void GetNoteByIndex_Test()
        {
            Assert.Equal(Notes.C, Note.GetNoteByIndex(0));
            Assert.Equal(Notes.D, Note.GetNoteByIndex(1));
            Assert.Equal(Notes.E, Note.GetNoteByIndex(2));
            Assert.Equal(Notes.F, Note.GetNoteByIndex(3));
            Assert.Equal(Notes.G, Note.GetNoteByIndex(4));
            Assert.Equal(Notes.A, Note.GetNoteByIndex(5));
            Assert.Equal(Notes.B, Note.GetNoteByIndex(6));
        }
    }
}
