using System.Collections.Generic;

namespace Bravura
{
    public struct ChordQualities
    { 
        #region -- Triads --

        public static readonly ChordQuality Sus2 = new ChordQuality(
            "sus2", 
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorSecond,
                Intervals.PerfectFifth,
            });

        public static readonly ChordQuality Dim = new ChordQuality(
            "dim",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
            });

        public static readonly ChordQuality Min = new ChordQuality(
            "m",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
            });
        public static readonly ChordQuality Maj = new ChordQuality(
            "",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
            });

        public static readonly ChordQuality Aug = new ChordQuality(
            "aug",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
            });

        public static readonly ChordQuality Sus4 = new ChordQuality(
            "sus4",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.PerfectFourth,
                Intervals.PerfectFifth,
            });

        #endregion

        #region -- Seventh Chords --

        public static readonly ChordQuality Dim7 = new ChordQuality(
            "dim7",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh
            });

        public static readonly ChordQuality Min7Flat5 = new ChordQuality(
            "m7♭5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh
            });

        public static readonly ChordQuality Min7 = new ChordQuality(
            "m7",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh
            });

        public static readonly ChordQuality MinMaj7 = new ChordQuality(
            "mMaj7",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh
            });

        public static readonly ChordQuality Dom7Flat5 = new ChordQuality(
            "7♭5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh
            });

        public static readonly ChordQuality Dom7 = new ChordQuality(
            "7",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh
            });

        public static readonly ChordQuality Maj7 = new ChordQuality(
            "Maj7",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh
            });

        public static readonly ChordQuality Add9 = new ChordQuality(
            "Add9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSecond
            });

        public static readonly ChordQuality Add11 = new ChordQuality(
            "Add11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Dom7Sharp5 = new ChordQuality(
            "7♯5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MinorSeventh
            });

        public static readonly ChordQuality Maj7Sharp5 = new ChordQuality(
            "Maj7♯5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh
            });

        #endregion

        #region -- Ninth Chords --

        public static readonly ChordQuality Dim7Flat9 = new ChordQuality(
            "dim7♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh,
                Intervals.MinorSecond
            });

        public static readonly ChordQuality Min7Flat5Flat9 = new ChordQuality(
            "m7♭5♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            });

        public static readonly ChordQuality Min9Flat5 = new ChordQuality(
            "m9♭5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond
            });

        public static readonly ChordQuality Min7Flat9 = new ChordQuality(
            "m7♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            });

        public static readonly ChordQuality Min9 = new ChordQuality(
            "m9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond
            });

        public static readonly ChordQuality MinMaj9 = new ChordQuality(
            "mMaj9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond
            });

        public static readonly ChordQuality Dom7Flat9 = new ChordQuality(
            "7♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            });

        public static readonly ChordQuality Dom9 = new ChordQuality(
            "9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond
            });

        public static readonly ChordQuality Maj7Sharp9 = new ChordQuality(
            "Maj7♯9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MinorThird
            });

        public static readonly ChordQuality Maj9 = new ChordQuality(
            "Maj9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond
            });

        public static readonly ChordQuality Maj9Sharp5 = new ChordQuality(
            "Maj9♯5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond
            });

        #endregion

        #region -- Eleventh Chords --

        public static readonly ChordQuality Dim7Flat9Flat11 = new ChordQuality(
            "dim7♭9♭11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth
            });

        public static readonly ChordQuality Min7Flat5Flat9Flat11 = new ChordQuality(
            "m7♭5♭9♭11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth
            });

        public static readonly ChordQuality Min11Flat5Flat9 = new ChordQuality(
            "m11♭5♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Min11Flat5 = new ChordQuality(
            "m11♭5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Min11Flat9 = new ChordQuality(
            "m11♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Min11 = new ChordQuality(
            "m11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Min9Sharp11 = new ChordQuality(
            "m9♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            });

        public static readonly ChordQuality MinMaj11 = new ChordQuality(
            "mMaj11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Dom11Flat9 = new ChordQuality(
            "11♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Dom11 = new ChordQuality(
            "11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Dom9Sharp11 = new ChordQuality(
            "9♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            });

        public static readonly ChordQuality Maj7Sharp9Sharp11 = new ChordQuality(
            "Maj7♯9♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.AugmentedSecond,
                Intervals.AugmentedFourth
            });

        public static readonly ChordQuality Maj11 = new ChordQuality(
            "Maj11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Maj9Sharp11 = new ChordQuality(
            "Maj9♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            });

        public static readonly ChordQuality Maj11Sharp5 = new ChordQuality(
            "Maj11♯5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth
            });

        public static readonly ChordQuality Maj9Sharp5Sharp11 = new ChordQuality(
            "Maj9♯5♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth
            });

        #endregion

        #region -- Thirteenth Chords --

        public static readonly ChordQuality Dim7Flat9Flat11Flat13 = new ChordQuality(
            "dim7♭9♭11♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.DiminishedSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Min7Flat5Flat9Flat11Flat13 = new ChordQuality(
            "m7♭5♭9♭11♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.DiminishedFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Min11Flat5Flat9Flat13 = new ChordQuality(
            "m11♭5♭9♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Min13Flat5Flat9 = new ChordQuality(
            "m13♭5♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Min11Flat5Flat13 = new ChordQuality(
            "m11♭5♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Min13Flat9 = new ChordQuality(
            "m13♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Min11Flat9Flat13 = new ChordQuality(
            "m11♭9♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Min11Flat13 = new ChordQuality(
            "m11♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Min13 = new ChordQuality(
            "m13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Min13Sharp11 = new ChordQuality(
            "m13♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality MinMaj11Flat13 = new ChordQuality(
            "mMaj11♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality MinMaj13 = new ChordQuality(
            "mMaj13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MinorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Dom11Flat9Flat13 = new ChordQuality(
            "11♭9♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Dom11Flat13 = new ChordQuality(
            "11♭13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MinorSixth
            });

        public static readonly ChordQuality Dom13 = new ChordQuality(
            "13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Dom13Sharp11 = new ChordQuality(
            "13♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MinorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp9Sharp11 = new ChordQuality(
            "Maj13♯9♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.AugmentedSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Maj13 = new ChordQuality(
            "Maj13",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp11 = new ChordQuality(
            "Maj13♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.PerfectFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp5 = new ChordQuality(
            "Maj13♯5",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.PerfectFourth,
                Intervals.MajorSixth
            });

        public static readonly ChordQuality Maj13Sharp5Sharp11 = new ChordQuality(
            "Maj13♯5♯11",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MajorSeventh,
                Intervals.MajorSecond,
                Intervals.AugmentedFourth,
                Intervals.MajorSixth
            });

        #endregion

        #region -- Altered Chords --

        public static readonly ChordQuality Dom7Flat5Flat9 = new ChordQuality(
            "7♭5♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            });

        public static readonly ChordQuality Dom7Flat5Sharp9 = new ChordQuality(
            "7♭5♯9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.DiminishedFifth,
                Intervals.MinorSeventh,
                Intervals.AugmentedSecond
            });

        public static readonly ChordQuality Dom7Sharp5Flat9 = new ChordQuality(
            "7♯5♭9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MinorSeventh,
                Intervals.MinorSecond
            });

        public static readonly ChordQuality Dom7Sharp5Sharp9 = new ChordQuality(
            "7♯5♯9",
            new List<Interval>
            {
                Intervals.PerfectUnison,
                Intervals.MajorThird,
                Intervals.AugmentedFifth,
                Intervals.MinorSeventh,
                Intervals.AugmentedSecond
            });

        #endregion

        #region -- Chord Collections --

        public static List<ChordQuality> Triads = new List<ChordQuality>
        {
            Sus2, Dim, Min, Maj, Aug, Sus4
        };

        public static List<ChordQuality> SeventhChords = new List<ChordQuality>
        {
            Dim7, Min7Flat5, Min7, MinMaj7, Dom7Flat5, Dom7, Maj7, Add9, Add11, Dom7Sharp5, Maj7Sharp5
        };

        public static List<ChordQuality> NinthChords = new List<ChordQuality>
        {
            Dim7Flat9, Min7Flat5Flat9, Min9Flat5, Min7Flat9, Min9, MinMaj9, Dom7Flat9, Dom9, Maj7Sharp9, Maj9, Maj9Sharp5
        };

        public static List<ChordQuality> EleventhChords = new List<ChordQuality>
        {
            Dim7Flat9Flat11, Min7Flat5Flat9Flat11, Min11Flat5Flat9, Min11Flat5, Min11Flat9, Min11, Min9Sharp11, MinMaj11,
            Dom11Flat9, Dom11, Dom9Sharp11, Maj7Sharp9Sharp11, Maj11, Maj9Sharp11, Maj11Sharp5, Maj9Sharp5Sharp11
        };

        public static List<ChordQuality> ThirteenthChords = new List<ChordQuality>
        {
            Dim7Flat9Flat11Flat13, Min7Flat5Flat9Flat11Flat13, Min11Flat5Flat9Flat13, Min13Flat5Flat9, Min11Flat5Flat13,
            Min13Flat9, Min11Flat9Flat13, Min11Flat13, Min13, Min13Sharp11, MinMaj11Flat13, MinMaj13, Dom11Flat9Flat13,
            Dom11Flat13, Dom13, Dom13Sharp11, Maj13Sharp9Sharp11, Maj13, Maj13Sharp11, Maj13Sharp5, Maj13Sharp5Sharp11
        };

        public static List<ChordQuality> AlteredChords = new List<ChordQuality>
        {
            Dom7Flat5Flat9, Dom7Flat5Sharp9, Dom7Sharp5Flat9, Dom7Sharp5Sharp9
        };

        public static List<ChordQuality> AllChords = new List<ChordQuality>
        {
            Sus2, Dim, Min, Maj, Aug, Sus4, Dim7, Min7Flat5, Min7, MinMaj7, Dom7Flat5, Dom7, Maj7, Add9, Add11, Dom7Sharp5, Maj7Sharp5,
            Dim7Flat9, Min7Flat5Flat9, Min9Flat5, Min7Flat9, Min9, MinMaj9, Dom7Flat9, Dom9, Maj7Sharp9, Maj9, Maj9Sharp5, Dim7Flat9Flat11,
            Min7Flat5Flat9Flat11, Min11Flat5Flat9, Min11Flat5, Min11Flat9, Min11, Min9Sharp11, MinMaj11, Dom11Flat9, Dom11, Dom9Sharp11,
            Maj7Sharp9Sharp11, Maj11, Maj9Sharp11, Maj11Sharp5, Maj9Sharp5Sharp11, Dim7Flat9Flat11Flat13, Min7Flat5Flat9Flat11Flat13,
            Min11Flat5Flat9Flat13, Min13Flat5Flat9, Min11Flat5Flat13, Min13Flat9, Min11Flat9Flat13, Min11Flat13, Min13, Min13Sharp11,
            MinMaj11Flat13, MinMaj13, Dom11Flat9Flat13, Dom11Flat13, Dom13, Dom13Sharp11, Maj13Sharp9Sharp11, Maj13, Maj13Sharp11,
            Maj13Sharp5, Maj13Sharp5Sharp11, Dom7Flat5Flat9, Dom7Flat5Sharp9, Dom7Sharp5Flat9, Dom7Sharp5Sharp9
        };

        #endregion 
    }
}