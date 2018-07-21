using System.Collections.Generic;
using Xunit;

namespace Bravura.Tests
{
    public class IntervalTests
    {
        [Theory]
        [MemberData(nameof(IntervalWorksData))]
        public void Interval_Works_Test(
            int semitones,
            Accidental accidental,
            int noteIndex,
            string name,
            string symbol)
        {
            var interval = new Interval(semitones, accidental, noteIndex, name, symbol);
            Assert.IsType<Interval>(interval);
            Assert.Equal(semitones, interval.Semitones);
            Assert.True(accidental == interval.Accidental);
            Assert.Equal(noteIndex, interval.NoteIndex);
            Assert.Equal(name, interval.Name);
            Assert.Equal(symbol, interval.Symbol);
        }

        [Theory]
        [MemberData(nameof(IntervalThrowsData))]
        public void Interval_Throws_Test(
            int semitones,
            Accidental accidental,
            int noteIndex,
            string name,
            string symbol)
        {
            var exception = Record.Exception(() => new Interval(semitones, accidental, noteIndex, name, symbol));
            Assert.NotNull(exception);
            Assert.IsType<BravuraException>(exception);
        }

        public static IEnumerable<object[]> IntervalWorksData()
        {
            yield return new object[] { 0, Accidentals.Natural, 1, "Perfect Unison", "P1" };
            yield return new object[] { 0, Accidentals.DoubleFlat, 2, "Diminished Second", "d2" };
            yield return new object[] { 1, Accidentals.Flat, 2, "Minor Second", "m2" };
            yield return new object[] { 1, Accidentals.Sharp, 1, "Augmented Unison", "A1" };
            yield return new object[] { 2, Accidentals.Natural, 2, "Major Second", "M2" };
            yield return new object[] { 2, Accidentals.DoubleFlat, 3, "Diminished Third", "d3" };
            yield return new object[] { 3, Accidentals.Flat, 3, "Minor Third", "m3" };
            yield return new object[] { 3, Accidentals.DoubleSharp, 2, "Augmented Second", "A2" };
            yield return new object[] { 4, Accidentals.Natural, 3, "Major Third", "M3" };
            yield return new object[] { 4, Accidentals.Flat, 4, "Diminished Fourth", "d4" };
            yield return new object[] { 5, Accidentals.Natural, 4, "Perfect Fourth", "P4" };
            yield return new object[] { 5, Accidentals.DoubleSharp, 3, "Augmented Third", "A3" };
            yield return new object[] { 6, Accidentals.Sharp, 4, "Augmented Fourth", "A4" };
            yield return new object[] { 6, Accidentals.Flat, 5, "Diminished Fifth", "d5" };
            //yield return new object[] { 6, Accidentals.Natural, 0, "Tritone", "TT" };
            yield return new object[] { 7, Accidentals.Natural, 5, "Perfect Fifth", "P5" };
            yield return new object[] { 7, Accidentals.DoubleFlat, 6, "Diminished Sixth", "d6" };
            yield return new object[] { 8, Accidentals.Flat, 6, "Minor Sixth", "m6" };
            yield return new object[] { 8, Accidentals.DoubleSharp, 5, "Augmented Fifth", "A5" };
            yield return new object[] { 9, Accidentals.Natural, 6, "Major Sixth", "M6" };
            yield return new object[] { 9, Accidentals.DoubleFlat, 7, "Diminished Seventh", "d7" };
            yield return new object[] { 10, Accidentals.Flat, 7, "Minor Seventh", "m7" };
            yield return new object[] { 10, Accidentals.DoubleSharp, 6, "Augmented Sixth", "A6" };
            yield return new object[] { 11, Accidentals.Natural, 7, "Major Seventh", "M7" };
            yield return new object[] { 11, Accidentals.DoubleFlat, 8, "Diminished Octave", "d8" };
            yield return new object[] { 12, Accidentals.Natural, 8, "Perfect Octave", "P8" };
            yield return new object[] { 12, Accidentals.DoubleSharp, 7, "Augmented Seventh", "A7" };
    }

        public static IEnumerable<object[]> IntervalThrowsData()
        {
            yield return new object[] { -1, Accidentals.Natural, 1, string.Empty, string.Empty };
            yield return new object[] { 13, Accidentals.Natural, 1, string.Empty, string.Empty };
            yield return new object[] { 0, Accidentals.Natural, -1, string.Empty, string.Empty };
            yield return new object[] { 0, Accidentals.Natural, 9, string.Empty, string.Empty };
            yield return new object[] { 0, Accidentals.Natural, 1, null, string.Empty };
            yield return new object[] { 0, Accidentals.Natural, 1, string.Empty, null };
        }
    }
}