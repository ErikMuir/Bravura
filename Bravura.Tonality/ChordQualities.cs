using System.Collections.Generic;

namespace Bravura.Tonality;

public static class ChordQualities
{
    static ChordQualities()
    {
        #region Triads
        Sus2 = new ChordQuality(
            ChordQualitySymbols.Sus2,
            ChordQualityAsciiSymbols.Sus2,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.PerfectFifth,
            ]);

        Dim = new ChordQuality(
            ChordQualitySymbols.Dim,
            ChordQualityAsciiSymbols.Dim,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
            ]);

        Min = new ChordQuality(
            ChordQualitySymbols.Min,
            ChordQualityAsciiSymbols.Min,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
            ]);

        Maj = new ChordQuality(
            ChordQualitySymbols.Maj,
            ChordQualityAsciiSymbols.Maj,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
            ]);

        Aug = new ChordQuality(
            ChordQualitySymbols.Aug,
            ChordQualityAsciiSymbols.Aug,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
            ]);

        Sus4 = new ChordQuality(
            ChordQualitySymbols.Sus4,
            ChordQualityAsciiSymbols.Sus4,
            [
                Intervals.PerfectUnison,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
            ]);
        #endregion

        #region Seventh Chords
        Dim7 = new ChordQuality(
            ChordQualitySymbols.Dim7,
            ChordQualityAsciiSymbols.Dim7,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh
            ]);

        Min7Flat5 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5,
            ChordQualityAsciiSymbols.Min7Flat5,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh
            ]);

        Min7 = new ChordQuality(
            ChordQualitySymbols.Min7,
            ChordQualityAsciiSymbols.Min7,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh
            ]);

        MinMaj7 = new ChordQuality(
            ChordQualitySymbols.MinMaj7,
            ChordQualityAsciiSymbols.MinMaj7,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh
            ]);

        Dom7Flat5 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat5,
            ChordQualityAsciiSymbols.Dom7Flat5,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh
            ]);

        Dom7 = new ChordQuality(
            ChordQualitySymbols.Dom7,
            ChordQualityAsciiSymbols.Dom7,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh
            ]);

        Maj7 = new ChordQuality(
            ChordQualitySymbols.Maj7,
            ChordQualityAsciiSymbols.Maj7,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh
            ]);

        Dom7Sharp5 = new ChordQuality(
            ChordQualitySymbols.Dom7Sharp5,
            ChordQualityAsciiSymbols.Dom7Sharp5,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MinorSeventh
            ]);

        Maj7Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj7Sharp5,
            ChordQualityAsciiSymbols.Maj7Sharp5,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh
            ]);
        #endregion

        #region Ninth Chords
        Dim7Flat9 = new ChordQuality(
            ChordQualitySymbols.Dim7Flat9,
            ChordQualityAsciiSymbols.Dim7Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh,
                Intervals.MinorSecond
            ]);

        Min7Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5Flat9,
            ChordQualityAsciiSymbols.Min7Flat5Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            ]);

        Min9Flat5 = new ChordQuality(
            ChordQualitySymbols.Min9Flat5,
            ChordQualityAsciiSymbols.Min9Flat5,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond
            ]);

        Min7Flat9 = new ChordQuality(
            ChordQualitySymbols.Min7Flat9,
            ChordQualityAsciiSymbols.Min7Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            ]);

        Min9 = new ChordQuality(
            ChordQualitySymbols.Min9,
            ChordQualityAsciiSymbols.Min9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond
            ]);

        MinMaj9 = new ChordQuality(
            ChordQualitySymbols.MinMaj9,
            ChordQualityAsciiSymbols.MinMaj9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond
            ]);

        Dom7Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat9,
            ChordQualityAsciiSymbols.Dom7Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
            ]);

        Dom7Sharp9 = new ChordQuality(
            ChordQualitySymbols.Dom7Sharp9,
            ChordQualityAsciiSymbols.Dom7Sharp9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.AugmentedSecond,
            ]);

        Dom7Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat5Flat9,
            ChordQualityAsciiSymbols.Dom7Flat5Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
            ]);

        Dom7Flat5Sharp9 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat5Sharp9,
            ChordQualityAsciiSymbols.Dom7Flat5Sharp9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.AugmentedSecond
            ]);

        Dom7Sharp5Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom7Sharp5Flat9,
            ChordQualityAsciiSymbols.Dom7Sharp5Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            ]);

        Dom7Sharp5Sharp9 = new ChordQuality(
            ChordQualitySymbols.Dom7Sharp5Sharp9,
            ChordQualityAsciiSymbols.Dom7Sharp5Sharp9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MinorSeventh,
                Intervals.AugmentedSecond
            ]);

        Dom9 = new ChordQuality(
            ChordQualitySymbols.Dom9,
            ChordQualityAsciiSymbols.Dom9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond
            ]);

        Maj7Sharp9 = new ChordQuality(
            ChordQualitySymbols.Maj7Sharp9,
            ChordQualityAsciiSymbols.Maj7Sharp9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MinorThird
            ]);

        Maj9 = new ChordQuality(
            ChordQualitySymbols.Maj9,
            ChordQualityAsciiSymbols.Maj9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond
            ]);

        Maj9Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj9Sharp5,
            ChordQualityAsciiSymbols.Maj9Sharp5,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond
            ]);
        #endregion

        #region Eleventh Chords
        Dim7Flat9Flat11 = new ChordQuality(
            ChordQualitySymbols.Dim7Flat9Flat11,
            ChordQualityAsciiSymbols.Dim7Flat9Flat11,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth
            ]);

        Min7Flat5Flat9Flat11 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5Flat9Flat11,
            ChordQualityAsciiSymbols.Min7Flat5Flat9Flat11,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth
            ]);

        Min11Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5Flat9,
            ChordQualityAsciiSymbols.Min11Flat5Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth
            ]);

        Min11Flat5 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5,
            ChordQualityAsciiSymbols.Min11Flat5,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            ]);

        Min11Flat9 = new ChordQuality(
            ChordQualitySymbols.Min11Flat9,
            ChordQualityAsciiSymbols.Min11Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth
            ]);

        Min11 = new ChordQuality(
            ChordQualitySymbols.Min11,
            ChordQualityAsciiSymbols.Min11,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            ]);

        Min9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Min9Sharp11,
            ChordQualityAsciiSymbols.Min9Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            ]);

        MinMaj11 = new ChordQuality(
            ChordQualitySymbols.MinMaj11,
            ChordQualityAsciiSymbols.MinMaj11,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            ]);

        Dom11Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom11Flat9,
            ChordQualityAsciiSymbols.Dom11Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth
            ]);

        Dom11 = new ChordQuality(
            ChordQualitySymbols.Dom11,
            ChordQualityAsciiSymbols.Dom11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            ]);

        Dom9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Dom9Sharp11,
            ChordQualityAsciiSymbols.Dom9Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            ]);

        Maj7Sharp9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj7Sharp9Sharp11,
            ChordQualityAsciiSymbols.Maj7Sharp9Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.AugmentedSecond,
                Intervals.AugmentedFourth
            ]);

        Maj11 = new ChordQuality(
            ChordQualitySymbols.Maj11,
            ChordQualityAsciiSymbols.Maj11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            ]);

        Maj9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj9Sharp11,
            ChordQualityAsciiSymbols.Maj9Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            ]);

        Maj11Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj11Sharp5,
            ChordQualityAsciiSymbols.Maj11Sharp5,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            ]);

        Maj9Sharp5Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj9Sharp5Sharp11,
            ChordQualityAsciiSymbols.Maj9Sharp5Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            ]);
        #endregion

        #region Thirteenth Chords
        Dim7Flat9Flat11Flat13 = new ChordQuality(
            ChordQualitySymbols.Dim7Flat9Flat11Flat13,
            ChordQualityAsciiSymbols.Dim7Flat9Flat11Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth,
                Intervals.MinorSixth
            ]);

        Min7Flat5Flat9Flat11Flat13 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5Flat9Flat11Flat13,
            ChordQualityAsciiSymbols.Min7Flat5Flat9Flat11Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth,
                Intervals.MinorSixth
            ]);

        Min11Flat5Flat9Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5Flat9Flat13,
            ChordQualityAsciiSymbols.Min11Flat5Flat9Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            ]);

        Min13Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Min13Flat5Flat9,
            ChordQualityAsciiSymbols.Min13Flat5Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            ]);

        Min11Flat5Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5Flat13,
            ChordQualityAsciiSymbols.Min11Flat5Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            ]);

        Min13Flat9 = new ChordQuality(
            ChordQualitySymbols.Min13Flat9,
            ChordQualityAsciiSymbols.Min13Flat9,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            ]);

        Min11Flat9Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat9Flat13,
            ChordQualityAsciiSymbols.Min11Flat9Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            ]);

        Min11Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat13,
            ChordQualityAsciiSymbols.Min11Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            ]);

        Min13 = new ChordQuality(
            ChordQualitySymbols.Min13,
            ChordQualityAsciiSymbols.Min13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            ]);

        Min13Sharp11 = new ChordQuality(
            ChordQualitySymbols.Min13Sharp11,
            ChordQualityAsciiSymbols.Min13Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            ]);

        MinMaj11Flat13 = new ChordQuality(
            ChordQualitySymbols.MinMaj11Flat13,
            ChordQualityAsciiSymbols.MinMaj11Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            ]);

        MinMaj13 = new ChordQuality(
            ChordQualitySymbols.MinMaj13,
            ChordQualityAsciiSymbols.MinMaj13,
            [
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            ]);

        Dom11Flat9Flat13 = new ChordQuality(
            ChordQualitySymbols.Dom11Flat9Flat13,
            ChordQualityAsciiSymbols.Dom11Flat9Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            ]);

        Dom11Flat13 = new ChordQuality(
            ChordQualitySymbols.Dom11Flat13,
            ChordQualityAsciiSymbols.Dom11Flat13,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            ]);

        Dom13 = new ChordQuality(
            ChordQualitySymbols.Dom13,
            ChordQualityAsciiSymbols.Dom13,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            ]);

        Dom13Sharp11 = new ChordQuality(
            ChordQualitySymbols.Dom13Sharp11,
            ChordQualityAsciiSymbols.Dom13Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            ]);

        Maj13Sharp9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp9Sharp11,
            ChordQualityAsciiSymbols.Maj13Sharp9Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.AugmentedSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            ]);

        Maj13 = new ChordQuality(
            ChordQualitySymbols.Maj13,
            ChordQualityAsciiSymbols.Maj13,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            ]);

        Maj13Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp11,
            ChordQualityAsciiSymbols.Maj13Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            ]);

        Maj13Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp5,
            ChordQualityAsciiSymbols.Maj13Sharp5,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            ]);

        Maj13Sharp5Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp5Sharp11,
            ChordQualityAsciiSymbols.Maj13Sharp5Sharp11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            ]);
        #endregion

        #region Other Chords

        Add9 = new ChordQuality(
            ChordQualitySymbols.Add9,
            ChordQualityAsciiSymbols.Add9,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSecond
            ]);

        Add11 = new ChordQuality(
            ChordQualitySymbols.Add11,
            ChordQualityAsciiSymbols.Add11,
            [
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.PerfectFourth
            ]);

        SixNine = new ChordQuality(
            ChordQualitySymbols.SixNine,
            ChordQualityAsciiSymbols.SixNine,
            [
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.PerfectFifth,
                Intervals.MajorSixth,
            ]);

        Five = new ChordQuality(
            ChordQualitySymbols.Five,
            ChordQualityAsciiSymbols.Five,
            [
                Intervals.PerfectUnison,
                Intervals.PerfectFifth,
            ]);

        Tritone = new ChordQuality(
            ChordQualitySymbols.Tritone,
            ChordQualityAsciiSymbols.Tritone,
            [
                Intervals.PerfectUnison,
                Intervals.Tritone,
            ]);
        #endregion

        #region Collections
        Triads =
            [
                Sus2,
                Dim,
                Min,
                Maj,
                Aug,
                Sus4,
            ];

        SeventhChords =
            [
                Dim7,
                Min7Flat5,
                Min7,
                MinMaj7,
                Dom7Flat5,
                Dom7,
                Maj7,
                Dom7Sharp5,
                Maj7Sharp5,
            ];

        NinthChords =
            [
                Dim7Flat9,
                Min7Flat5Flat9,
                Min9Flat5,
                Min7Flat9,
                Min9,
                MinMaj9,
                Dom7Flat9,
                Dom7Sharp9,
                Dom7Flat5Flat9,
                Dom7Flat5Sharp9,
                Dom7Sharp5Flat9,
                Dom7Sharp5Sharp9,
                Dom7Sharp9,
                Dom9,
                Maj7Sharp9,
                Maj9,
                Maj9Sharp5,
            ];

        EleventhChords =
            [
                Dim7Flat9Flat11,
                Min7Flat5Flat9Flat11,
                Min11Flat5Flat9,
                Min11Flat5,
                Min11Flat9,
                Min11,
                Min9Sharp11,
                MinMaj11,
                Dom11Flat9,
                Dom11,
                Dom9Sharp11,
                Maj7Sharp9Sharp11,
                Maj11,
                Maj9Sharp11,
                Maj11Sharp5,
                Maj9Sharp5Sharp11,
            ];

        ThirteenthChords =
            [
                Dim7Flat9Flat11Flat13,
                Min7Flat5Flat9Flat11Flat13,
                Min11Flat5Flat9Flat13,
                Min13Flat5Flat9,
                Min11Flat5Flat13,
                Min13Flat9,
                Min11Flat9Flat13,
                Min11Flat13,
                Min13,
                Min13Sharp11,
                MinMaj11Flat13,
                MinMaj13,
                Dom11Flat9Flat13,
                Dom11Flat13,
                Dom13,
                Dom13Sharp11,
                Maj13Sharp9Sharp11,
                Maj13,
                Maj13Sharp11,
                Maj13Sharp5,
                Maj13Sharp5Sharp11,
            ];

        AllChordQualities =
            [
                Sus2,
                Dim,
                Min,
                Maj,
                Aug,
                Sus4,
                Dim7,
                Min7Flat5,
                Min7,
                MinMaj7,
                Dom7Flat5,
                Dom7,
                Maj7,
                Dom7Sharp5,
                Maj7Sharp5,
                Dim7Flat9,
                Min7Flat5Flat9,
                Min9Flat5,
                Min7Flat9,
                Min9,
                MinMaj9,
                Dom7Flat9,
                Dom7Sharp9,
                Dom7Flat5Flat9,
                Dom7Flat5Sharp9,
                Dom7Sharp5Flat9,
                Dom7Sharp5Sharp9,
                Dom9,
                Maj7Sharp9,
                Maj9,
                Maj9Sharp5,
                Dim7Flat9Flat11,
                Min7Flat5Flat9Flat11,
                Min11Flat5Flat9,
                Min11Flat5,
                Min11Flat9,
                Min11,
                Min9Sharp11,
                MinMaj11,
                Dom11Flat9,
                Dom11,
                Dom9Sharp11,
                Maj7Sharp9Sharp11,
                Maj11,
                Maj9Sharp11,
                Maj11Sharp5,
                Maj9Sharp5Sharp11,
                Dim7Flat9Flat11Flat13,
                Min7Flat5Flat9Flat11Flat13,
                Min11Flat5Flat9Flat13,
                Min13Flat5Flat9,
                Min11Flat5Flat13,
                Min13Flat9,
                Min11Flat9Flat13,
                Min11Flat13,
                Min13,
                Min13Sharp11,
                MinMaj11Flat13,
                MinMaj13,
                Dom11Flat9Flat13,
                Dom11Flat13,
                Dom13,
                Dom13Sharp11,
                Maj13Sharp9Sharp11,
                Maj13,
                Maj13Sharp11,
                Maj13Sharp5,
                Maj13Sharp5Sharp11,
                Add9,
                Add11,
                SixNine,
                Five,
                Tritone,
            ];
        #endregion
    }

    #region Triads
    public static ChordQuality Sus2 { get; }
    public static ChordQuality Dim { get; }
    public static ChordQuality Min { get; }
    public static ChordQuality Maj { get; }
    public static ChordQuality Aug { get; }
    public static ChordQuality Sus4 { get; }
    #endregion

    #region Seventh Chords
    public static ChordQuality Dim7 { get; }
    public static ChordQuality Min7Flat5 { get; }
    public static ChordQuality Min7 { get; }
    public static ChordQuality MinMaj7 { get; }
    public static ChordQuality Dom7Flat5 { get; }
    public static ChordQuality Dom7 { get; }
    public static ChordQuality Maj7 { get; }
    public static ChordQuality Dom7Sharp5 { get; }
    public static ChordQuality Maj7Sharp5 { get; }
    #endregion

    #region Ninth Chords
    public static ChordQuality Dim7Flat9 { get; }
    public static ChordQuality Min7Flat5Flat9 { get; }
    public static ChordQuality Min9Flat5 { get; }
    public static ChordQuality Min7Flat9 { get; }
    public static ChordQuality Min9 { get; }
    public static ChordQuality MinMaj9 { get; }
    public static ChordQuality Dom7Flat9 { get; }
    public static ChordQuality Dom7Sharp9 { get; }
    public static ChordQuality Dom7Flat5Flat9 { get; }
    public static ChordQuality Dom7Flat5Sharp9 { get; }
    public static ChordQuality Dom7Sharp5Flat9 { get; }
    public static ChordQuality Dom7Sharp5Sharp9 { get; }
    public static ChordQuality Dom9 { get; }
    public static ChordQuality Maj7Sharp9 { get; }
    public static ChordQuality Maj9 { get; }
    public static ChordQuality Maj9Sharp5 { get; }
    #endregion

    #region Eleventh Chords
    public static ChordQuality Dim7Flat9Flat11 { get; }
    public static ChordQuality Min7Flat5Flat9Flat11 { get; }
    public static ChordQuality Min11Flat5Flat9 { get; }
    public static ChordQuality Min11Flat5 { get; }
    public static ChordQuality Min11Flat9 { get; }
    public static ChordQuality Min11 { get; }
    public static ChordQuality Min9Sharp11 { get; }
    public static ChordQuality MinMaj11 { get; }
    public static ChordQuality Dom11Flat9 { get; }
    public static ChordQuality Dom11 { get; }
    public static ChordQuality Dom9Sharp11 { get; }
    public static ChordQuality Maj7Sharp9Sharp11 { get; }
    public static ChordQuality Maj11 { get; }
    public static ChordQuality Maj9Sharp11 { get; }
    public static ChordQuality Maj11Sharp5 { get; }
    public static ChordQuality Maj9Sharp5Sharp11 { get; }
    #endregion

    #region Thirteenth Chords
    public static ChordQuality Dim7Flat9Flat11Flat13 { get; }
    public static ChordQuality Min7Flat5Flat9Flat11Flat13 { get; }
    public static ChordQuality Min11Flat5Flat9Flat13 { get; }
    public static ChordQuality Min13Flat5Flat9 { get; }
    public static ChordQuality Min11Flat5Flat13 { get; }
    public static ChordQuality Min13Flat9 { get; }
    public static ChordQuality Min11Flat9Flat13 { get; }
    public static ChordQuality Min11Flat13 { get; }
    public static ChordQuality Min13 { get; }
    public static ChordQuality Min13Sharp11 { get; }
    public static ChordQuality MinMaj11Flat13 { get; }
    public static ChordQuality MinMaj13 { get; }
    public static ChordQuality Dom11Flat9Flat13 { get; }
    public static ChordQuality Dom11Flat13 { get; }
    public static ChordQuality Dom13 { get; }
    public static ChordQuality Dom13Sharp11 { get; }
    public static ChordQuality Maj13Sharp9Sharp11 { get; }
    public static ChordQuality Maj13 { get; }
    public static ChordQuality Maj13Sharp11 { get; }
    public static ChordQuality Maj13Sharp5 { get; }
    public static ChordQuality Maj13Sharp5Sharp11 { get; }
    #endregion

    #region Other Chords
    public static ChordQuality Add9 { get; }
    public static ChordQuality Add11 { get; }
    public static ChordQuality SixNine { get; }
    public static ChordQuality Five { get; }
    public static ChordQuality Tritone { get; }
    #endregion

    #region Collections
    public static List<ChordQuality> Triads { get; }
    public static List<ChordQuality> SeventhChords { get; }
    public static List<ChordQuality> NinthChords { get; }
    public static List<ChordQuality> EleventhChords { get; }
    public static List<ChordQuality> ThirteenthChords { get; }
    public static List<ChordQuality> AllChordQualities { get; }
    #endregion
}

public static class ChordQualitySymbols
{
    #region Triads
    public const string Sus2 = "sus2";
    public const string Dim = "dim";
    public const string Min = "m";
    public const string Maj = "";
    public const string Aug = "aug";
    public const string Sus4 = "sus4";
    #endregion

    #region Seventh Chords
    public const string Dim7 = "dim7";
    public const string Min7Flat5 = "m7♭5";
    public const string Min7 = "m7";
    public const string MinMaj7 = "mMaj7";
    public const string Dom7Flat5 = "7♭5";
    public const string Dom7 = "7";
    public const string Maj7 = "Maj7";
    public const string Dom7Sharp5 = "7♯5";
    public const string Maj7Sharp5 = "Maj7♯5";
    #endregion

    #region Ninth Chords
    public const string Dim7Flat9 = "7♭9";
    public const string Min7Flat5Flat9 = "m7♭5♭9";
    public const string Min9Flat5 = "m9♭5";
    public const string Min7Flat9 = "m7♭9";
    public const string Min9 = "m9";
    public const string MinMaj9 = "mMaj9";
    public const string Dom7Flat9 = "7♭9";
    public const string Dom7Sharp9 = "7♯9";
    public const string Dom7Flat5Flat9 = "7♭5♭9";
    public const string Dom7Flat5Sharp9 = "7♭5♯9";
    public const string Dom7Sharp5Flat9 = "7♯5♭9";
    public const string Dom7Sharp5Sharp9 = "7♯5♯9";
    public const string Dom9 = "9";
    public const string Maj7Sharp9 = "Maj7♯9";
    public const string Maj9 = "Maj9";
    public const string Maj9Sharp5 = "Maj9♯5";
    #endregion

    #region Eleventh Chords
    public const string Dim7Flat9Flat11 = "dim7♭9♭11";
    public const string Min7Flat5Flat9Flat11 = "m7♭5♭9♭11";
    public const string Min11Flat5Flat9 = "m11♭5♭9";
    public const string Min11Flat5 = "m11♭5";
    public const string Min11Flat9 = "m11♭9";
    public const string Min11 = "m11";
    public const string Min9Sharp11 = "m9♯11";
    public const string MinMaj11 = "mMaj11";
    public const string Dom11Flat9 = "11♭9";
    public const string Dom11 = "11";
    public const string Dom9Sharp11 = "9♯11";
    public const string Maj7Sharp9Sharp11 = "Maj79#♯11";
    public const string Maj11 = "Maj11";
    public const string Maj9Sharp11 = "Maj9♯11";
    public const string Maj11Sharp5 = "Maj11♯5";
    public const string Maj9Sharp5Sharp11 = "Maj9♯5♯11";
    #endregion

    #region Thirteenth Chords
    public const string Dim7Flat9Flat11Flat13 = "dim7♭9♭11♭13";
    public const string Min7Flat5Flat9Flat11Flat13 = "m7♭5♭9♭11♭13";
    public const string Min11Flat5Flat9Flat13 = "m11♭5♭9♭13";
    public const string Min13Flat5Flat9 = "m13♭5♭9";
    public const string Min11Flat5Flat13 = "m11♭5♭13";
    public const string Min13Flat9 = "m13♭9";
    public const string Min11Flat9Flat13 = "m11♭9♭13";
    public const string Min11Flat13 = "m11♭13";
    public const string Min13 = "m13";
    public const string Min13Sharp11 = "m13♯11";
    public const string MinMaj11Flat13 = "mMaj11♭13";
    public const string MinMaj13 = "mMaj13";
    public const string Dom11Flat9Flat13 = "11♭9♭13";
    public const string Dom11Flat13 = "11♭13";
    public const string Dom13 = "13";
    public const string Dom13Sharp11 = "13♯11";
    public const string Maj13Sharp9Sharp11 = "Maj13♯9♯11";
    public const string Maj13 = "Maj13";
    public const string Maj13Sharp11 = "Maj13♯11";
    public const string Maj13Sharp5 = "Maj13♯5";
    public const string Maj13Sharp5Sharp11 = "Maj13♯5♯11";
    #endregion

    #region Other Chords
    public const string Add9 = "add9";
    public const string Add11 = "add11";
    public const string SixNine = "69";
    public const string Five = "5";
    public const string Tritone = "T";
    #endregion
}

public static class ChordQualityAsciiSymbols
{
    #region Triads
    public const string Sus2 = "sus2";
    public const string Dim = "dim";
    public const string Min = "m";
    public const string Maj = "";
    public const string Aug = "aug";
    public const string Sus4 = "sus4";
    #endregion

    #region Seventh Chords
    public const string Dim7 = "dim7";
    public const string Min7Flat5 = "m7b5";
    public const string Min7 = "m7";
    public const string MinMaj7 = "mMaj7";
    public const string Dom7Flat5 = "7b5";
    public const string Dom7 = "7";
    public const string Maj7 = "Maj7";
    public const string Dom7Sharp5 = "7#5";
    public const string Maj7Sharp5 = "Maj7#5";
    #endregion

    #region Ninth Chords
    public const string Dim7Flat9 = "7b9";
    public const string Min7Flat5Flat9 = "m7b5b9";
    public const string Min9Flat5 = "m9b5";
    public const string Min7Flat9 = "m7b9";
    public const string Min9 = "m9";
    public const string MinMaj9 = "mMaj9";
    public const string Dom7Flat9 = "7b9";
    public const string Dom7Sharp9 = "7#9";
    public const string Dom7Flat5Flat9 = "7b5b9";
    public const string Dom7Flat5Sharp9 = "7b5#9";
    public const string Dom7Sharp5Flat9 = "7#5b9";
    public const string Dom7Sharp5Sharp9 = "7#5#9";
    public const string Dom9 = "9";
    public const string Maj7Sharp9 = "Maj7#9";
    public const string Maj9 = "Maj9";
    public const string Maj9Sharp5 = "Maj9#5";
    #endregion

    #region Eleventh Chords
    public const string Dim7Flat9Flat11 = "dim7b9b11";
    public const string Min7Flat5Flat9Flat11 = "m7b5b9b11";
    public const string Min11Flat5Flat9 = "m11b5b9";
    public const string Min11Flat5 = "m11b5";
    public const string Min11Flat9 = "m11b9";
    public const string Min11 = "m11";
    public const string Min9Sharp11 = "m9#11";
    public const string MinMaj11 = "mMaj11";
    public const string Dom11Flat9 = "11b9";
    public const string Dom11 = "11";
    public const string Dom9Sharp11 = "9#11";
    public const string Maj7Sharp9Sharp11 = "Maj7#9#11";
    public const string Maj11 = "Maj11";
    public const string Maj9Sharp11 = "Maj9#11";
    public const string Maj11Sharp5 = "Maj11#5";
    public const string Maj9Sharp5Sharp11 = "Maj9#5#11";
    #endregion

    #region Thirteenth Chords
    public const string Dim7Flat9Flat11Flat13 = "dim7b9b11b13";
    public const string Min7Flat5Flat9Flat11Flat13 = "m7b5b9b11b13";
    public const string Min11Flat5Flat9Flat13 = "m11b5b9b13";
    public const string Min13Flat5Flat9 = "m13b5b9";
    public const string Min11Flat5Flat13 = "m11b5b13";
    public const string Min13Flat9 = "m13b9";
    public const string Min11Flat9Flat13 = "m11b9b13";
    public const string Min11Flat13 = "m11b13";
    public const string Min13 = "m13";
    public const string Min13Sharp11 = "m13#11";
    public const string MinMaj11Flat13 = "mMaj11b13";
    public const string MinMaj13 = "mMaj13";
    public const string Dom11Flat9Flat13 = "11b9b13";
    public const string Dom11Flat13 = "11b13";
    public const string Dom13 = "13";
    public const string Dom13Sharp11 = "13#11";
    public const string Maj13Sharp9Sharp11 = "Maj13#9#11";
    public const string Maj13 = "Maj13";
    public const string Maj13Sharp11 = "Maj13#11";
    public const string Maj13Sharp5 = "Maj13#5";
    public const string Maj13Sharp5Sharp11 = "Maj13#5#11";
    #endregion

    #region Other Chords
    public const string Add9 = "add9";
    public const string Add11 = "add11";
    public const string SixNine = "69";
    public const string Five = "5";
    public const string Tritone = "T";
    #endregion
}
