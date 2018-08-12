using System.Collections.Generic;
using Bravura.Constants;

namespace Bravura
{
    public static partial class Theory
    {
        #region -- Triads --

        public static readonly ChordQuality Sus2 = new ChordQuality(
            ChordQualitySymbols.Sus2,
            ChordQualityAsciiSymbols.Sus2,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorSecond,
                    PerfectFifth,
            });

        public static readonly ChordQuality Dim = new ChordQuality(
            ChordQualitySymbols.Dim,
            ChordQualityAsciiSymbols.Dim,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
            });

        public static readonly ChordQuality Min = new ChordQuality(
            ChordQualitySymbols.Min,
            ChordQualityAsciiSymbols.Min,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
            });

        public static readonly ChordQuality Maj = new ChordQuality(
            ChordQualitySymbols.Maj,
            ChordQualityAsciiSymbols.Maj,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
            });

        public static readonly ChordQuality Aug = new ChordQuality(
            ChordQualitySymbols.Aug,
            ChordQualityAsciiSymbols.Aug,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
            });

        public static readonly ChordQuality Sus4 = new ChordQuality(
            ChordQualitySymbols.Sus4,
            ChordQualityAsciiSymbols.Sus4,
            new List<Interval>
            {
                    PerfectUnison,
                    PerfectFourth,
                    PerfectFifth,
            });

        #endregion

        #region -- Seventh Chords --

        public static readonly ChordQuality Dim7 = new ChordQuality(
            ChordQualitySymbols.Dim7,
            ChordQualityAsciiSymbols.Dim7,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    DiminishedSeventh
            });

        public static readonly ChordQuality Min7Flat5 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5,
            ChordQualityAsciiSymbols.Min7Flat5,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh
            });

        public static readonly ChordQuality Min7 = new ChordQuality(
            ChordQualitySymbols.Min7,
            ChordQualityAsciiSymbols.Min7,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh
            });

        public static readonly ChordQuality MinMaj7 = new ChordQuality(
            ChordQualitySymbols.MinMaj7,
            ChordQualityAsciiSymbols.MinMaj7,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MajorSeventh
            });

        public static readonly ChordQuality Dom7Flat5 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat5,
            ChordQualityAsciiSymbols.Dom7Flat5,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    DiminishedFifth,
                    MinorSeventh
            });

        public static readonly ChordQuality Dom7 = new ChordQuality(
            ChordQualitySymbols.Dom7,
            ChordQualityAsciiSymbols.Dom7,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh
            });

        public static readonly ChordQuality Maj7 = new ChordQuality(
            ChordQualitySymbols.Maj7,
            ChordQualityAsciiSymbols.Maj7,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh
            });

        public static readonly ChordQuality Add9 = new ChordQuality(
            ChordQualitySymbols.Add9,
            ChordQualityAsciiSymbols.Add9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSecond
            });

        public static readonly ChordQuality Add11 = new ChordQuality(
            ChordQualitySymbols.Add11,
            ChordQualityAsciiSymbols.Add11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    PerfectFourth
            });

        public static readonly ChordQuality Dom7Sharp5 = new ChordQuality(
            ChordQualitySymbols.Dom7Sharp5,
            ChordQualityAsciiSymbols.Dom7Sharp5,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MinorSeventh
            });

        public static readonly ChordQuality Maj7Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj7Sharp5,
            ChordQualityAsciiSymbols.Maj7Sharp5,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MajorSeventh
            });

        #endregion

        #region -- Ninth Chords --

        public static readonly ChordQuality Dim7Flat9 = new ChordQuality(
            ChordQualitySymbols.Dim7Flat9,
            ChordQualityAsciiSymbols.Dim7Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    DiminishedSeventh,
                    MinorSecond
            });

        public static readonly ChordQuality Min7Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5Flat9,
            ChordQualityAsciiSymbols.Min7Flat5Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MinorSecond
            });

        public static readonly ChordQuality Min9Flat5 = new ChordQuality(
            ChordQualitySymbols.Min9Flat5,
            ChordQualityAsciiSymbols.Min9Flat5,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MajorSecond
            });

        public static readonly ChordQuality Min7Flat9 = new ChordQuality(
            ChordQualitySymbols.Min7Flat9,
            ChordQualityAsciiSymbols.Min7Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MinorSecond
            });

        public static readonly ChordQuality Min9 = new ChordQuality(
            ChordQualitySymbols.Min9,
            ChordQualityAsciiSymbols.Min9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond
            });

        public static readonly ChordQuality MinMaj9 = new ChordQuality(
            ChordQualitySymbols.MinMaj9,
            ChordQualityAsciiSymbols.MinMaj9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond
            });

        public static readonly ChordQuality Dom7Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat9,
            ChordQualityAsciiSymbols.Dom7Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MinorSecond
            });

        public static readonly ChordQuality Dom9 = new ChordQuality(
            ChordQualitySymbols.Dom9,
            ChordQualityAsciiSymbols.Dom9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond
            });

        public static readonly ChordQuality Maj7Sharp9 = new ChordQuality(
            ChordQualitySymbols.Maj7Sharp9,
            ChordQualityAsciiSymbols.Maj7Sharp9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MinorThird
            });

        public static readonly ChordQuality Maj9 = new ChordQuality(
            ChordQualitySymbols.Maj9,
            ChordQualityAsciiSymbols.Maj9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond
            });

        public static readonly ChordQuality Maj9Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj9Sharp5,
            ChordQualityAsciiSymbols.Maj9Sharp5,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MajorSeventh,
                    MajorSecond
            });

        #endregion

        #region -- Eleventh Chords --

        public static readonly ChordQuality Dim7Flat9Flat11 = new ChordQuality(
            ChordQualitySymbols.Dim7Flat9Flat11,
            ChordQualityAsciiSymbols.Dim7Flat9Flat11,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    DiminishedSeventh,
                    MinorSecond,
                    DiminishedFourth
            });

        public static readonly ChordQuality Min7Flat5Flat9Flat11 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5Flat9Flat11,
            ChordQualityAsciiSymbols.Min7Flat5Flat9Flat11,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MinorSecond,
                    DiminishedFourth
            });

        public static readonly ChordQuality Min11Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5Flat9,
            ChordQualityAsciiSymbols.Min11Flat5Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Min11Flat5 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5,
            ChordQualityAsciiSymbols.Min11Flat5,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Min11Flat9 = new ChordQuality(
            ChordQualitySymbols.Min11Flat9,
            ChordQualityAsciiSymbols.Min11Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Min11 = new ChordQuality(
            ChordQualitySymbols.Min11,
            ChordQualityAsciiSymbols.Min11,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Min9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Min9Sharp11,
            ChordQualityAsciiSymbols.Min9Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    AugmentedFourth
            });

        public static readonly ChordQuality MinMaj11 = new ChordQuality(
            ChordQualitySymbols.MinMaj11,
            ChordQualityAsciiSymbols.MinMaj11,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Dom11Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom11Flat9,
            ChordQualityAsciiSymbols.Dom11Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Dom11 = new ChordQuality(
            ChordQualitySymbols.Dom11,
            ChordQualityAsciiSymbols.Dom11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Dom9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Dom9Sharp11,
            ChordQualityAsciiSymbols.Dom9Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    AugmentedFourth
            });

        public static readonly ChordQuality Maj7Sharp9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj7Sharp9Sharp11,
            ChordQualityAsciiSymbols.Maj7Sharp9Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    AugmentedSecond,
                    AugmentedFourth
            });

        public static readonly ChordQuality Maj11 = new ChordQuality(
            ChordQualitySymbols.Maj11,
            ChordQualityAsciiSymbols.Maj11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Maj9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj9Sharp11,
            ChordQualityAsciiSymbols.Maj9Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond,
                    AugmentedFourth
            });

        public static readonly ChordQuality Maj11Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj11Sharp5,
            ChordQualityAsciiSymbols.Maj11Sharp5,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MajorSeventh,
                    MajorSecond,
                    PerfectFourth
            });

        public static readonly ChordQuality Maj9Sharp5Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj9Sharp5Sharp11,
            ChordQualityAsciiSymbols.Maj9Sharp5Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MajorSeventh,
                    MajorSecond,
                    AugmentedFourth
            });

        #endregion

        #region -- Thirteenth Chords --

        public static readonly ChordQuality Dim7Flat9Flat11Flat13 = new ChordQuality(
            ChordQualitySymbols.Dim7Flat9Flat11Flat13,
            ChordQualityAsciiSymbols.Dim7Flat9Flat11Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    DiminishedSeventh,
                    MinorSecond,
                    DiminishedFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Min7Flat5Flat9Flat11Flat13 = new ChordQuality(
            ChordQualitySymbols.Min7Flat5Flat9Flat11Flat13,
            ChordQualityAsciiSymbols.Min7Flat5Flat9Flat11Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MinorSecond,
                    DiminishedFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Min11Flat5Flat9Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5Flat9Flat13,
            ChordQualityAsciiSymbols.Min11Flat5Flat9Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Min13Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Min13Flat5Flat9,
            ChordQualityAsciiSymbols.Min13Flat5Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Min11Flat5Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat5Flat13,
            ChordQualityAsciiSymbols.Min11Flat5Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Min13Flat9 = new ChordQuality(
            ChordQualitySymbols.Min13Flat9,
            ChordQualityAsciiSymbols.Min13Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Min11Flat9Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat9Flat13,
            ChordQualityAsciiSymbols.Min11Flat9Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Min11Flat13 = new ChordQuality(
            ChordQualitySymbols.Min11Flat13,
            ChordQualityAsciiSymbols.Min11Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Min13 = new ChordQuality(
            ChordQualitySymbols.Min13,
            ChordQualityAsciiSymbols.Min13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Min13Sharp11 = new ChordQuality(
            ChordQualitySymbols.Min13Sharp11,
            ChordQualityAsciiSymbols.Min13Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    AugmentedFourth,
                    MajorSixth
            });

        public static readonly ChordQuality MinMaj11Flat13 = new ChordQuality(
            ChordQualitySymbols.MinMaj11Flat13,
            ChordQualityAsciiSymbols.MinMaj11Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MinorSixth
            });

        public static readonly ChordQuality MinMaj13 = new ChordQuality(
            ChordQualitySymbols.MinMaj13,
            ChordQualityAsciiSymbols.MinMaj13,
            new List<Interval>
            {
                    PerfectUnison,
                    MinorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Dom11Flat9Flat13 = new ChordQuality(
            ChordQualitySymbols.Dom11Flat9Flat13,
            ChordQualityAsciiSymbols.Dom11Flat9Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MinorSecond,
                    PerfectFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Dom11Flat13 = new ChordQuality(
            ChordQualitySymbols.Dom11Flat13,
            ChordQualityAsciiSymbols.Dom11Flat13,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MinorSixth
            });

        public static readonly ChordQuality Dom13 = new ChordQuality(
            ChordQualitySymbols.Dom13,
            ChordQualityAsciiSymbols.Dom13,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Dom13Sharp11 = new ChordQuality(
            ChordQualitySymbols.Dom13Sharp11,
            ChordQualityAsciiSymbols.Dom13Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MinorSeventh,
                    MajorSecond,
                    AugmentedFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp9Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp9Sharp11,
            ChordQualityAsciiSymbols.Maj13Sharp9Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    AugmentedSecond,
                    AugmentedFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Maj13 = new ChordQuality(
            ChordQualitySymbols.Maj13,
            ChordQualityAsciiSymbols.Maj13,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp11,
            ChordQualityAsciiSymbols.Maj13Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    PerfectFifth,
                    MajorSeventh,
                    MajorSecond,
                    AugmentedFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp5 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp5,
            ChordQualityAsciiSymbols.Maj13Sharp5,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MajorSeventh,
                    MajorSecond,
                    PerfectFourth,
                    MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp5Sharp11 = new ChordQuality(
            ChordQualitySymbols.Maj13Sharp5Sharp11,
            ChordQualityAsciiSymbols.Maj13Sharp5Sharp11,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MajorSeventh,
                    MajorSecond,
                    AugmentedFourth,
                    MajorSixth
            });

        #endregion

        #region -- Altered Chords --

        public static readonly ChordQuality Dom7Flat5Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat5Flat9,
            ChordQualityAsciiSymbols.Dom7Flat5Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    MinorSecond
            });

        public static readonly ChordQuality Dom7Flat5Sharp9 = new ChordQuality(
            ChordQualitySymbols.Dom7Flat5Sharp9,
            ChordQualityAsciiSymbols.Dom7Flat5Sharp9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    DiminishedFifth,
                    MinorSeventh,
                    AugmentedSecond
            });

        public static readonly ChordQuality Dom7Sharp5Flat9 = new ChordQuality(
            ChordQualitySymbols.Dom7Sharp5Flat9,
            ChordQualityAsciiSymbols.Dom7Sharp5Flat9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MinorSeventh,
                    MinorSecond
            });

        public static readonly ChordQuality Dom7Sharp5Sharp9 = new ChordQuality(
            ChordQualitySymbols.Dom7Sharp5Sharp9,
            ChordQualityAsciiSymbols.Dom7Sharp5Sharp9,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorThird,
                    AugmentedFifth,
                    MinorSeventh,
                    AugmentedSecond
            });

        #endregion

        #region -- Other Chords --

        public static readonly ChordQuality Five = new ChordQuality(
            ChordQualitySymbols.Five,
            ChordQualityAsciiSymbols.Five,
            new List<Interval>
            {
                    PerfectUnison,
                    PerfectFifth,
            });

        public static readonly ChordQuality SixNine = new ChordQuality(
            ChordQualitySymbols.SixNine,
            ChordQualityAsciiSymbols.SixNine,
            new List<Interval>
            {
                    PerfectUnison,
                    MajorSecond,
                    PerfectFifth,
                    MajorSixth,
            });

        #endregion

        #region -- Chord Collections --

        public static List<ChordQuality> Triads =
            new List<ChordQuality>
            {
                    Sus2,
                    Dim,
                    Min,
                    Maj,
                    Aug,
                    Sus4
            };

        public static List<ChordQuality> SeventhChords =
            new List<ChordQuality>
            {
                    Dim7,
                    Min7Flat5,
                    Min7,
                    MinMaj7,
                    Dom7Flat5,
                    Dom7,
                    Maj7,
                    Add9,
                    Add11,
                    Dom7Sharp5,
                    Maj7Sharp5
            };

        public static List<ChordQuality> NinthChords =
            new List<ChordQuality>
            {
                    Dim7Flat9,
                    Min7Flat5Flat9,
                    Min9Flat5,
                    Min7Flat9,
                    Min9,
                    MinMaj9,
                    Dom7Flat9,
                    Dom9,
                    Maj7Sharp9,
                    Maj9,
                    Maj9Sharp5
            };

        public static List<ChordQuality> EleventhChords =
            new List<ChordQuality>
            {
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
                    Maj9Sharp5Sharp11
            };

        public static List<ChordQuality> ThirteenthChords =
            new List<ChordQuality>
            {
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
                    Maj13Sharp5Sharp11
            };

        public static List<ChordQuality> AlteredChords =
            new List<ChordQuality>
            {
                    Dom7Flat5Flat9,
                    Dom7Flat5Sharp9,
                    Dom7Sharp5Flat9,
                    Dom7Sharp5Sharp9
            };

        public static List<ChordQuality> AllChords =
            new List<ChordQuality>
            {
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
                    Add9,
                    Add11,
                    Dom7Sharp5,
                    Maj7Sharp5,
                    Dim7Flat9,
                    Min7Flat5Flat9,
                    Min9Flat5,
                    Min7Flat9,
                    Min9,
                    MinMaj9,
                    Dom7Flat9,
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
                    Dom7Flat5Flat9,
                    Dom7Flat5Sharp9,
                    Dom7Sharp5Flat9,
                    Dom7Sharp5Sharp9,
                    Five,
                    SixNine,
            };

        #endregion
    }
}