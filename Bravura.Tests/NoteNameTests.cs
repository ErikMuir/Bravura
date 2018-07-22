using Xunit;

namespace Bravura.Tests
{
    public class NoteNameTests
    {
        [Theory]
        [InlineData(0, 0, "C", true, false)]
        [InlineData(1, 2, "D", false, false)]
        [InlineData(2, 4, "E", false, true)]
        [InlineData(3, 5, "F", true, false)]
        [InlineData(4, 7, "G", false, false)]
        [InlineData(5, 9, "A", false, false)]
        [InlineData(6, 11, "B", false, true)]
        public void NoteName_Works_Test(int index, int value, string symbol, bool isLowerNeighborHalfstep, bool isHigherNeighborHalfstep)
        {
            var noteName = new NoteName(index, value, symbol, isLowerNeighborHalfstep, isHigherNeighborHalfstep);
            Assert.IsType<NoteName>(noteName);
            Assert.Equal(index, noteName.Index);
            Assert.Equal(value, noteName.Value);
            Assert.Equal(symbol, noteName.Symbol);
            Assert.Equal(isLowerNeighborHalfstep, noteName.IsLowerNeighborHalfstep);
            Assert.Equal(isHigherNeighborHalfstep, noteName.IsHigherNeighborHalfstep);
        }

        [Theory]
        [InlineData(-1, 0, "C", true, false)]
        [InlineData(7, 0, "C", true, false)]
        [InlineData(0, -1, "C", true, false)]
        [InlineData(0, 12, "C", true, false)]
        [InlineData(0, 0, null, true, false)]
        public void NoteName_Throws_Test(int index, int value, string symbol, bool isLowerNeighborHalfstep, bool isHigherNeighborHalfstep)
        {
            var exception = Record.Exception(() => new NoteName(index, value, symbol, isLowerNeighborHalfstep, isHigherNeighborHalfstep));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        [Fact]
        public void NoteName_Equality_Test()
        {
            var fakeNoteName = new NoteName(1, 0, "Cee", false, false);
            Assert.True(fakeNoteName == NoteNames.C);
            Assert.True(fakeNoteName.Equals(NoteNames.C));
            Assert.Equal(fakeNoteName.GetHashCode(), NoteNames.C.GetHashCode());
        }
    }
}