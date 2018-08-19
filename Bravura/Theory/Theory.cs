namespace Bravura
{
    public static partial class Theory
    {
        static Theory()
        {
            SetNotes();
            SetAccidentals();
            SetPitches();
            SetIntervals();
            SetChordQualities();
            SetModes();
            SetKeys();
        }

        static partial void SetNotes();
        static partial void SetAccidentals();
        static partial void SetPitches();
        static partial void SetIntervals();
        static partial void SetChordQualities();
        static partial void SetModes();
        static partial void SetKeys();
    }
}