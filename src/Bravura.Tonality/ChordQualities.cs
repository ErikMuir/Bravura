using System.Collections.Generic;

namespace Bravura.Tonality;

public static class ChordQualities
{
    #region Triads
    public static readonly ChordQuality Sus2 = new(
        "sus2",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.PerfectFifth,
        ]);
    public static readonly ChordQuality Dim = new(
        "dim",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
        ]);
    public static readonly ChordQuality Min = new(
        "m",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
        ]);
    public static readonly ChordQuality Maj = new(
        "",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
        ]);
    public static readonly ChordQuality Aug = new(
        "aug",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
        ]);
    public static readonly ChordQuality Sus4 = new(
        "sus4",
        [
            Intervals.PerfectUnison,
            Intervals.PerfectFourth,
            Intervals.PerfectFifth,
        ]);
    #endregion

    #region Seventh Chords
    public static readonly ChordQuality Dim7 = new(
        "dim7",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.DiminishedSeventh
        ]);
    public static readonly ChordQuality Min7Flat5 = new(
        "m7♭5",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh
        ]);
    public static readonly ChordQuality Min7 = new(
        "m7",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh
        ]);
    public static readonly ChordQuality MinMaj7 = new(
        "mMaj7",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh
        ]);
    public static readonly ChordQuality Dom7Flat5 = new(
        "7♭5",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh
        ]);
    public static readonly ChordQuality Dom7 = new(
        "7",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh
        ]);
    public static readonly ChordQuality Maj7 = new(
        "Maj7",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh
        ]);
    public static readonly ChordQuality Dom7Sharp5 = new(
        "7♯5",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
            Intervals.MinorSeventh
        ]);
    public static readonly ChordQuality Maj7Sharp5 = new(
        "Maj7♯5",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
            Intervals.MajorSeventh
        ]);
    #endregion

    #region Ninth Chords
    public static readonly ChordQuality Dim7Flat9 = new(
        "dim7♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.DiminishedSeventh,
            Intervals.MinorSecond
        ]);
    public static readonly ChordQuality Min7Flat5Flat9 = new(
        "m7♭5♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond
        ]);
    public static readonly ChordQuality Min9Flat5 = new(
        "m9♭5",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond
        ]);
    public static readonly ChordQuality Min7Flat9 = new(
        "m7♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond
        ]);
    public static readonly ChordQuality Min9 = new(
        "m9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond
        ]);
    public static readonly ChordQuality MinMaj9 = new(
        "mMaj9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond
        ]);
    public static readonly ChordQuality Dom7Flat9 = new(
        "7♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
        ]);
    public static readonly ChordQuality Dom7Sharp9 = new(
        "7♯9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.AugmentedSecond,
        ]);
    public static readonly ChordQuality Dom7Flat5Flat9 = new(
        "7♭5♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
        ]);
    public static readonly ChordQuality Dom7Flat5Sharp9 = new(
        "7♭5♯9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.AugmentedSecond
        ]);
    public static readonly ChordQuality Dom7Sharp5Flat9 = new(
        "7♯5♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond
        ]);
    public static readonly ChordQuality Dom7Sharp5Sharp9 = new(
        "7♯5♯9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
            Intervals.MinorSeventh,
            Intervals.AugmentedSecond
        ]);
    public static readonly ChordQuality Dom9 = new(
        "9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond
        ]);
    public static readonly ChordQuality Maj7Sharp9 = new(
        "Maj7♯9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MinorThird
        ]);
    public static readonly ChordQuality Maj9 = new(
        "Maj9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond
        ]);
    public static readonly ChordQuality Maj9Sharp5 = new(
        "Maj9♯5",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond
        ]);
    #endregion

    #region Eleventh Chords
    public static readonly ChordQuality Dim7Flat9Flat11 = new(
        "dim7♭9♭11",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.DiminishedSeventh,
            Intervals.MinorSecond,
            Intervals.DiminishedFourth
        ]);
    public static readonly ChordQuality Min7Flat5Flat9Flat11 = new(
        "m7♭5♭9♭11",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.DiminishedFourth
        ]);
    public static readonly ChordQuality Min11Flat5Flat9 = new(
        "m11♭5♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Min11Flat5 = new(
        "m11♭5",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Min11Flat9 = new(
        "m11♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Min11 = new(
        "m11",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Min9Sharp11 = new(
        "m9♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.AugmentedFourth
        ]);
    public static readonly ChordQuality MinMaj11 = new(
        "mMaj11",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Dom11Flat9 = new(
        "11♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Dom11 = new(
        "11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Dom9Sharp11 = new(
        "9♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.AugmentedFourth
        ]);
    public static readonly ChordQuality Maj7Sharp9Sharp11 = new(
        "Maj7♯9♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.AugmentedSecond,
            Intervals.AugmentedFourth
        ]);
    public static readonly ChordQuality Maj11 = new(
        "Maj11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Maj9Sharp11 = new(
        "Maj9♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.AugmentedFourth
        ]);
    public static readonly ChordQuality Maj11Sharp5 = new(
        "Maj11♯5",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality Maj9Sharp5Sharp11 = new(
        "Maj9♯5♯11",
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
    public static readonly ChordQuality Dim7Flat9Flat11Flat13 = new(
        "dim7♭9♭11♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.DiminishedSeventh,
            Intervals.MinorSecond,
            Intervals.DiminishedFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Min7Flat5Flat9Flat11Flat13 = new(
        "m7♭5♭9♭11♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.DiminishedFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Min11Flat5Flat9Flat13 = new(
        "m11♭5♭9♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Min13Flat5Flat9 = new(
        "m13♭5♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Min11Flat5Flat13 = new(
        "m11♭5♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.DiminishedFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Min13Flat9 = new(
        "m13♭9",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Min11Flat9Flat13 = new(
        "m11♭9♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Min11Flat13 = new(
        "m11♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Min13 = new(
        "m13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Min13Sharp11 = new(
        "m13♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.AugmentedFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality MinMaj11Flat13 = new(
        "mMaj11♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality MinMaj13 = new(
        "mMaj13",
        [
            Intervals.PerfectUnison,
            Intervals.MinorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Dom11Flat9Flat13 = new(
        "11♭9♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MinorSecond,
            Intervals.PerfectFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Dom11Flat13 = new(
        "11♭13",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MinorSixth
        ]);
    public static readonly ChordQuality Dom13 = new(
        "13",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Dom13Sharp11 = new(
        "13♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MinorSeventh,
            Intervals.MajorSecond,
            Intervals.AugmentedFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Maj13Sharp9Sharp11 = new(
        "Maj13♯9♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.AugmentedSecond,
            Intervals.AugmentedFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Maj13 = new(
        "Maj13",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Maj13Sharp11 = new(
        "Maj13♯11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.AugmentedFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Maj13Sharp5 = new(
        "Maj13♯5",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.AugmentedFifth,
            Intervals.MajorSeventh,
            Intervals.MajorSecond,
            Intervals.PerfectFourth,
            Intervals.MajorSixth
        ]);
    public static readonly ChordQuality Maj13Sharp5Sharp11 = new(
        "Maj13♯5♯11",
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
    public static readonly ChordQuality Add9 = new(
        "add9",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.MajorSecond
        ]);
    public static readonly ChordQuality Add11 = new(
        "add11",
        [
            Intervals.PerfectUnison,
            Intervals.MajorThird,
            Intervals.PerfectFifth,
            Intervals.PerfectFourth
        ]);
    public static readonly ChordQuality SixNine = new(
        "69",
        [
            Intervals.PerfectUnison,
            Intervals.MajorSecond,
            Intervals.PerfectFifth,
            Intervals.MajorSixth,
        ]);
    public static readonly ChordQuality Five = new(
        "5",
        [
            Intervals.PerfectUnison,
            Intervals.PerfectFifth,
        ]);
    public static readonly ChordQuality Tritone = new(
        "T",
        [
            Intervals.PerfectUnison,
            Intervals.Tritone,
        ]);
    #endregion

    #region Collections
    public static readonly List<ChordQuality> Triads = [
        Sus2,
        Dim,
        Min,
        Maj,
        Aug,
        Sus4,
    ];
    public static readonly List<ChordQuality> SeventhChords = [
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
    public static readonly List<ChordQuality> NinthChords = [
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
    public static readonly List<ChordQuality> EleventhChords = [
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
    public static readonly List<ChordQuality> ThirteenthChords = [
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
    public static readonly List<ChordQuality> AllChordQualities = [
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
