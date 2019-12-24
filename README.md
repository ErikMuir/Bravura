# Bravura

A Music Theory Class Library

[Full Documentation](./docs/Contents.md)

### What it supports and what it doesn't

Bravura currently only supports the harmonic elements of music, but the plan is to add rhythmic elements at some point.

## Bravura.Tonality

[Bravura.Tonality](./docs/Bravura.Tonality/Bravura.Tonality.md) provides all the harmonic building blocks of music.

It contains several class types which have `internal` constructors, which means you _cannot_ create new instances. All instances are `public static readonly` and are provided free of charge! Examples of these types are `Note`, `Accidental`, `Pitch`, and `Key`.

It also exposes several class types for which you _can_ create new instances, such as `Interval`, `ChordQuality`, `Chord`, `Mode`, and `Scale`. You'll probably find most intervals, chord qualities, and modes have already been provided for you as `public static readonly` instances, but chords and scales are all you, baby!

### Note

The [Note](./docs/Bravura.Tonality/Note.md) struct is one of the internal types that can't be instantiated. It consists of a letter and a number. The letter should be obvious, I mean, we're talking about a musical note here. The number represents how many half-steps (semitones) it is above C. Why C? Well, we needed to choose a note as a frame of reference, and since the key of C has no sharps or flats it just seemed like the "natural" choice. ;)

_It's important to keep in mind here that a Note is only the letter of the alphabet, not an actual pitch. We'll get to Pitches a bit later._

**The 7 notes and their semitone values:**

- C = 0 semitones above C♮
- D = 2 semitones above C♮
- E = 4 semitones above C♮
- F = 5 semitones above C♮
- G = 7 semitones above C♮
- A = 9 semitones above C♮
- B = 11 semitones above C♮

### Accidental

An [Accidental](./docs/Bravura.Tonality/Accidental.md) consists of a name, a number, and a symbol. The number represents how many half-steps (semitones) away from Natural that it will change the Note that it's paired with. New accidentals, like notes, cannot be instantiated.

**The 5 accidentals and their semitone values:**

- Double Flat (♭♭): -2 semitones
- Flat (♭): -1 semitones
- Natural (♮): 0 semitones
- Sharp (♯): 1 semitones
- Double Sharp (♯♯): 2 semitones

### Pitch

A [Pitch](./docs/Bravura.Tonality/Pitch.md) is the combination of a [Note](./docs/Bravura.Tonality/Note.md) and an [Accidental](./docs/Bravura.Tonality/Accidental.md). Two pitches are considered to be enharmonically equal when their distance (in semitones) above C natural are the same. New pitches cannot be instantiated. All instances are exposed through the static class [Pitches](./docs/Bravura.Tonality/Pitches.md).

### Interval

An [Interval](./docs/Bravura.Tonality/Interval.md) is the distance (in semitones) between two pitches. You can create new instances of intervals, although the all intervals within an octave are exposed through the static class [Intervals](./docs/Bravura.Tonality/Intervals.md).

This project is licensed under the terms of the MIT license.
