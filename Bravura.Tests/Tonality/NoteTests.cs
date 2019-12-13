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
        public void LowerNeighbor_Test()
        {
            Assert.Equal(Notes.B, Notes.C.LowerNeighbor);
            Assert.Equal(Notes.C, Notes.D.LowerNeighbor);
            Assert.Equal(Notes.D, Notes.E.LowerNeighbor);
            Assert.Equal(Notes.E, Notes.F.LowerNeighbor);
            Assert.Equal(Notes.F, Notes.G.LowerNeighbor);
            Assert.Equal(Notes.G, Notes.A.LowerNeighbor);
            Assert.Equal(Notes.A, Notes.B.LowerNeighbor);
        }

        [Fact]
        public void HigherNeighbor_Test()
        {
            Assert.Equal(Notes.D, Notes.C.HigherNeighbor);
            Assert.Equal(Notes.E, Notes.D.HigherNeighbor);
            Assert.Equal(Notes.F, Notes.E.HigherNeighbor);
            Assert.Equal(Notes.G, Notes.F.HigherNeighbor);
            Assert.Equal(Notes.A, Notes.G.HigherNeighbor);
            Assert.Equal(Notes.B, Notes.A.HigherNeighbor);
            Assert.Equal(Notes.C, Notes.B.HigherNeighbor);
        }

        [Fact]
        public void IsLowerNeighborNatural_Test()
        {
            Assert.True(Notes.C.IsLowerNeighborNatural());
            Assert.False(Notes.D.IsLowerNeighborNatural());
            Assert.False(Notes.E.IsLowerNeighborNatural());
            Assert.True(Notes.F.IsLowerNeighborNatural());
            Assert.False(Notes.G.IsLowerNeighborNatural());
            Assert.False(Notes.A.IsLowerNeighborNatural());
            Assert.False(Notes.B.IsLowerNeighborNatural());
        }

        [Fact]
        public void IsHigherNeighborNatural_Test()
        {
            Assert.False(Notes.C.IsHigherNeighborNatural());
            Assert.False(Notes.D.IsHigherNeighborNatural());
            Assert.True(Notes.E.IsHigherNeighborNatural());
            Assert.False(Notes.F.IsHigherNeighborNatural());
            Assert.False(Notes.G.IsHigherNeighborNatural());
            Assert.False(Notes.A.IsHigherNeighborNatural());
            Assert.True(Notes.B.IsHigherNeighborNatural());
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

        [Fact]
        public void NoteEquals_Test()
        {
            Assert.True(Notes.C.Equals(Notes.C));
            Assert.False(Notes.C.Equals(Notes.D));
        }

        [Fact]
        public void ObjectEquals_Test()
        {
            Assert.True(Notes.C.Equals((object)Notes.C));
            Assert.False(Notes.C.Equals((object)Notes.D));
            Assert.False(Notes.C.Equals((object)null));
            Assert.False(Notes.C.Equals(new { Foo = "bar" }));
        }

        [Fact]
        public void GetHashCode_Test()
        {
            Assert.Equal(Notes.C.GetHashCode(), Notes.C.GetHashCode());
            Assert.NotEqual(Notes.C.GetHashCode(), Notes.D.GetHashCode());
        }
    }
}
