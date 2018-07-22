using System.Collections.Generic;
using Xunit;

namespace Bravura.Tests
{
    public class NoteNameTests
    {
        [Theory]
        [MemberData(nameof(NoteNameWorksData))]
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
        [MemberData(nameof(NoteNameThrowsData))]
        public void NoteName_Throws_Test(int index, int value, string symbol, bool isLowerNeighborHalfstep, bool isHigherNeighborHalfstep)
        {
            var exception = Record.Exception(() => new NoteName(index, value, symbol, isLowerNeighborHalfstep, isHigherNeighborHalfstep));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        public static IEnumerable<object[]> NoteNameWorksData()
        {
            yield return new object[] { 0, 0, "C", true, false };
            yield return new object[] { 1, 2, "D", false, false };
            yield return new object[] { 2, 4, "E", false, true };
            yield return new object[] { 3, 5, "F", true, false };
            yield return new object[] { 4, 7, "G", false, false };
            yield return new object[] { 5, 9, "A", false, false };
            yield return new object[] { 6, 11, "B", false, true };
        }

        public static IEnumerable<object[]> NoteNameThrowsData()
        {
            yield return new object[] { -1, 0, "C", true, false };
            yield return new object[] { 7, 0, "C", true, false };
            yield return new object[] { 0, -1, "C", true, false };
            yield return new object[] { 0, 12, "C", true, false };
            yield return new object[] { 0, 0, null, true, false };
        }
    }
}