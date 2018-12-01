using System;
using System.Collections.Generic;
using Bravura.Constants;
using Bravura.Exceptions;

namespace Bravura
{
    public static partial class Tonality
    {
        public class ChordQuality
        {
            #region -- Constructor --

            public ChordQuality(string symbol, string asciiSymbol, List<Interval> intervals)
            {
                try
                {
                    Symbol = symbol ?? throw new Exception();
                    AsciiSymbol = asciiSymbol ?? throw new Exception();
                    ChordQualityIntervals = intervals ?? throw new Exception();
                    if (intervals.Count < 2)
                        throw new Exception();
                    if (intervals[0] != PerfectUnison)
                        throw new Exception();
                }
                catch (Exception)
                {
                    throw new BravuraException($"{nameof(ChordQuality)} is invalid");
                }
            }

            #endregion

            #region -- Properties --

            public string Symbol { get; }
            public string AsciiSymbol { get; }
            public List<Interval> ChordQualityIntervals { get; }

            #endregion

            #region -- Methods --

            //public static bool operator ==(ChordQuality a, ChordQuality b)
            //{
            //    if (a == null && b == null) return true;
            //    if (a == null || b == null) return false;
            //    if (a.ChordQualityIntervals.Count != b.ChordQualityIntervals.Count) return false;
            //    return !a.ChordQualityIntervals.Where((t, i) => t != b.ChordQualityIntervals[i]).Any();
            //}

            //public static bool operator !=(ChordQuality a, ChordQuality b)
            //    => !(a == b);

            //public override bool Equals(object obj)
            //{
            //    if (!(obj is ChordQuality)) return false;
            //    var quality = (ChordQuality)obj;
            //    if (ChordQualityIntervals.Count != quality.ChordQualityIntervals.Count) return false;
            //    return !ChordQualityIntervals.Where((t, i) => t != quality.ChordQualityIntervals[i]).Any();
            //}

            //public override int GetHashCode()
            //    => ChordQualityIntervals.Sum(i => i.Semitones);

            #endregion
        }

        #region -- Chord Qualities --

        #region -- Triads --

        public static ChordQuality Sus2 { get; private set; }
        public static ChordQuality Dim { get; private set; }
        public static ChordQuality Min { get; private set; }
        public static ChordQuality Maj { get; private set; }
        public static ChordQuality Aug { get; private set; }
        public static ChordQuality Sus4 { get; private set; }

        #endregion

        #region -- Seventh Chords --

        public static ChordQuality Dim7 { get; private set; }
        public static ChordQuality Min7Flat5 { get; private set; }
        public static ChordQuality Min7 { get; private set; }
        public static ChordQuality MinMaj7 { get; private set; }
        public static ChordQuality Dom7Flat5 { get; private set; }
        public static ChordQuality Dom7 { get; private set; }
        public static ChordQuality Maj7 { get; private set; }
        public static ChordQuality Add9 { get; private set; }
        public static ChordQuality Add11 { get; private set; }
        public static ChordQuality Dom7Sharp5 { get; private set; }
        public static ChordQuality Maj7Sharp5 { get; private set; }

        #endregion

        #region -- Ninth Chords --

        public static ChordQuality Dim7Flat9 { get; private set; }
        public static ChordQuality Min7Flat5Flat9 { get; private set; }
        public static ChordQuality Min9Flat5 { get; private set; }
        public static ChordQuality Min7Flat9 { get; private set; }
        public static ChordQuality Min9 { get; private set; }
        public static ChordQuality MinMaj9 { get; private set; }
        public static ChordQuality Dom7Flat9 { get; private set; }
        public static ChordQuality Dom9 { get; private set; }
        public static ChordQuality Maj7Sharp9 { get; private set; }
        public static ChordQuality Maj9 { get; private set; }
        public static ChordQuality Maj9Sharp5 { get; private set; }

        #endregion

        #region -- Eleventh Chords --

        public static ChordQuality Dim7Flat9Flat11 { get; private set; }
        public static ChordQuality Min7Flat5Flat9Flat11 { get; private set; }
        public static ChordQuality Min11Flat5Flat9 { get; private set; }
        public static ChordQuality Min11Flat5 { get; private set; }
        public static ChordQuality Min11Flat9 { get; private set; }
        public static ChordQuality Min11 { get; private set; }
        public static ChordQuality Min9Sharp11 { get; private set; }
        public static ChordQuality MinMaj11 { get; private set; }
        public static ChordQuality Dom11Flat9 { get; private set; }
        public static ChordQuality Dom11 { get; private set; }
        public static ChordQuality Dom9Sharp11 { get; private set; }
        public static ChordQuality Maj7Sharp9Sharp11 { get; private set; }
        public static ChordQuality Maj11 { get; private set; }
        public static ChordQuality Maj9Sharp11 { get; private set; }
        public static ChordQuality Maj11Sharp5 { get; private set; }
        public static ChordQuality Maj9Sharp5Sharp11 { get; private set; }

        #endregion

        #region -- Thirteenth Chords --

        public static ChordQuality Dim7Flat9Flat11Flat13 { get; private set; }
        public static ChordQuality Min7Flat5Flat9Flat11Flat13 { get; private set; }
        public static ChordQuality Min11Flat5Flat9Flat13 { get; private set; }
        public static ChordQuality Min13Flat5Flat9 { get; private set; }
        public static ChordQuality Min11Flat5Flat13 { get; private set; }
        public static ChordQuality Min13Flat9 { get; private set; }
        public static ChordQuality Min11Flat9Flat13 { get; private set; }
        public static ChordQuality Min11Flat13 { get; private set; }
        public static ChordQuality Min13 { get; private set; }
        public static ChordQuality Min13Sharp11 { get; private set; }
        public static ChordQuality MinMaj11Flat13 { get; private set; }
        public static ChordQuality MinMaj13 { get; private set; }
        public static ChordQuality Dom11Flat9Flat13 { get; private set; }
        public static ChordQuality Dom11Flat13 { get; private set; }
        public static ChordQuality Dom13 { get; private set; }
        public static ChordQuality Dom13Sharp11 { get; private set; }
        public static ChordQuality Maj13Sharp9Sharp11 { get; private set; }
        public static ChordQuality Maj13 { get; private set; }
        public static ChordQuality Maj13Sharp11 { get; private set; }
        public static ChordQuality Maj13Sharp5 { get; private set; }
        public static ChordQuality Maj13Sharp5Sharp11 { get; private set; }

        #endregion

        #region -- Altered Chords --

        public static ChordQuality Dom7Flat5Flat9 { get; private set; }
        public static ChordQuality Dom7Flat5Sharp9 { get; private set; }
        public static ChordQuality Dom7Sharp5Flat9 { get; private set; }
        public static ChordQuality Dom7Sharp5Sharp9 { get; private set; }

        #endregion

        #region -- Other Chords --

        public static ChordQuality Five { get; private set; }
        public static ChordQuality SixNine { get; private set; }

        #endregion

        #region -- Chord Collections --

        public static List<ChordQuality> Triads { get; private set; }
        public static List<ChordQuality> SeventhChords { get; private set; }
        public static List<ChordQuality> NinthChords { get; private set; }
        public static List<ChordQuality> EleventhChords { get; private set; }
        public static List<ChordQuality> ThirteenthChords { get; private set; }
        public static List<ChordQuality> AlteredChords { get; private set; }
        public static List<ChordQuality> ChordQualities { get; private set; }

        #endregion

        #endregion 

        static partial void SetChordQualities()
        {
            #region -- Triads --

            Sus2 = new ChordQuality(
                    ChordQualitySymbols.Sus2,
                    ChordQualityAsciiSymbols.Sus2,
                    new List<Interval>
                    {
                        PerfectUnison,
                        MajorSecond,
                        PerfectFifth,
                    });

            Dim = new ChordQuality(
                ChordQualitySymbols.Dim,
                ChordQualityAsciiSymbols.Dim,
                new List<Interval>
                {
                        PerfectUnison,
                        MinorThird,
                        DiminishedFifth,
                });

            Min = new ChordQuality(
                ChordQualitySymbols.Min,
                ChordQualityAsciiSymbols.Min,
                new List<Interval>
                {
                        PerfectUnison,
                        MinorThird,
                        PerfectFifth,
                });

            Maj = new ChordQuality(
                ChordQualitySymbols.Maj,
                ChordQualityAsciiSymbols.Maj,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        PerfectFifth,
                });

            Aug = new ChordQuality(
                ChordQualitySymbols.Aug,
                ChordQualityAsciiSymbols.Aug,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        AugmentedFifth,
                });

            Sus4 = new ChordQuality(
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

            Dim7 = new ChordQuality(
                ChordQualitySymbols.Dim7,
                ChordQualityAsciiSymbols.Dim7,
                new List<Interval>
                {
                        PerfectUnison,
                        MinorThird,
                        DiminishedFifth,
                        DiminishedSeventh
                });

            Min7Flat5 = new ChordQuality(
                ChordQualitySymbols.Min7Flat5,
                ChordQualityAsciiSymbols.Min7Flat5,
                new List<Interval>
                {
                        PerfectUnison,
                        MinorThird,
                        DiminishedFifth,
                        MinorSeventh
                });

            Min7 = new ChordQuality(
                ChordQualitySymbols.Min7,
                ChordQualityAsciiSymbols.Min7,
                new List<Interval>
                {
                        PerfectUnison,
                        MinorThird,
                        PerfectFifth,
                        MinorSeventh
                });

            MinMaj7 = new ChordQuality(
                ChordQualitySymbols.MinMaj7,
                ChordQualityAsciiSymbols.MinMaj7,
                new List<Interval>
                {
                        PerfectUnison,
                        MinorThird,
                        PerfectFifth,
                        MajorSeventh
                });

            Dom7Flat5 = new ChordQuality(
                ChordQualitySymbols.Dom7Flat5,
                ChordQualityAsciiSymbols.Dom7Flat5,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        DiminishedFifth,
                        MinorSeventh
                });

            Dom7 = new ChordQuality(
                ChordQualitySymbols.Dom7,
                ChordQualityAsciiSymbols.Dom7,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        PerfectFifth,
                        MinorSeventh
                });

            Maj7 = new ChordQuality(
                ChordQualitySymbols.Maj7,
                ChordQualityAsciiSymbols.Maj7,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        PerfectFifth,
                        MajorSeventh
                });

            Add9 = new ChordQuality(
                ChordQualitySymbols.Add9,
                ChordQualityAsciiSymbols.Add9,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        PerfectFifth,
                        MajorSecond
                });

            Add11 = new ChordQuality(
                ChordQualitySymbols.Add11,
                ChordQualityAsciiSymbols.Add11,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        PerfectFifth,
                        PerfectFourth
                });

            Dom7Sharp5 = new ChordQuality(
                ChordQualitySymbols.Dom7Sharp5,
                ChordQualityAsciiSymbols.Dom7Sharp5,
                new List<Interval>
                {
                        PerfectUnison,
                        MajorThird,
                        AugmentedFifth,
                        MinorSeventh
                });

            Maj7Sharp5 = new ChordQuality(
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

            Dim7Flat9 = new ChordQuality(
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

            Min7Flat5Flat9 = new ChordQuality(
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

            Min9Flat5 = new ChordQuality(
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

            Min7Flat9 = new ChordQuality(
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

            Min9 = new ChordQuality(
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

            MinMaj9 = new ChordQuality(
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

            Dom7Flat9 = new ChordQuality(
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

            Dom9 = new ChordQuality(
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

            Maj7Sharp9 = new ChordQuality(
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

            Maj9 = new ChordQuality(
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

            Maj9Sharp5 = new ChordQuality(
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

            Dim7Flat9Flat11 = new ChordQuality(
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

            Min7Flat5Flat9Flat11 = new ChordQuality(
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

            Min11Flat5Flat9 = new ChordQuality(
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

            Min11Flat5 = new ChordQuality(
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

            Min11Flat9 = new ChordQuality(
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

            Min11 = new ChordQuality(
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

            Min9Sharp11 = new ChordQuality(
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

            MinMaj11 = new ChordQuality(
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

            Dom11Flat9 = new ChordQuality(
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

            Dom11 = new ChordQuality(
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

            Dom9Sharp11 = new ChordQuality(
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

            Maj7Sharp9Sharp11 = new ChordQuality(
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

            Maj11 = new ChordQuality(
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

            Maj9Sharp11 = new ChordQuality(
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

            Maj11Sharp5 = new ChordQuality(
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

            Maj9Sharp5Sharp11 = new ChordQuality(
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

            Dim7Flat9Flat11Flat13 = new ChordQuality(
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

            Min7Flat5Flat9Flat11Flat13 = new ChordQuality(
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

            Min11Flat5Flat9Flat13 = new ChordQuality(
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

            Min13Flat5Flat9 = new ChordQuality(
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

            Min11Flat5Flat13 = new ChordQuality(
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

            Min13Flat9 = new ChordQuality(
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

            Min11Flat9Flat13 = new ChordQuality(
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

            Min11Flat13 = new ChordQuality(
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

            Min13 = new ChordQuality(
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

            Min13Sharp11 = new ChordQuality(
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

            MinMaj11Flat13 = new ChordQuality(
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

            MinMaj13 = new ChordQuality(
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

            Dom11Flat9Flat13 = new ChordQuality(
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

            Dom11Flat13 = new ChordQuality(
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

            Dom13 = new ChordQuality(
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

            Dom13Sharp11 = new ChordQuality(
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

            Maj13Sharp9Sharp11 = new ChordQuality(
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

            Maj13 = new ChordQuality(
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

            Maj13Sharp11 = new ChordQuality(
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

            Maj13Sharp5 = new ChordQuality(
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

            Maj13Sharp5Sharp11 = new ChordQuality(
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

            Dom7Flat5Flat9 = new ChordQuality(
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

            Dom7Flat5Sharp9 = new ChordQuality(
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

            Dom7Sharp5Flat9 = new ChordQuality(
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

            Dom7Sharp5Sharp9 = new ChordQuality(
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

            Five = new ChordQuality(
                ChordQualitySymbols.Five,
                ChordQualityAsciiSymbols.Five,
                new List<Interval>
                {
                        PerfectUnison,
                        PerfectFifth,
                });

            SixNine = new ChordQuality(
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

            Triads = new List<ChordQuality>
            {
                Sus2,
                Dim,
                Min,
                Maj,
                Aug,
                Sus4
            };

            SeventhChords = new List<ChordQuality>
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

            NinthChords = new List<ChordQuality>
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

            EleventhChords = new List<ChordQuality>
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

            ThirteenthChords = new List<ChordQuality>
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

            AlteredChords = new List<ChordQuality>
            {
                Dom7Flat5Flat9,
                Dom7Flat5Sharp9,
                Dom7Sharp5Flat9,
                Dom7Sharp5Sharp9
            };

            ChordQualities = new List<ChordQuality>
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
}