using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality
{
    public enum KeyMode { Major, Minor }

    public class Key : IEquatable<Key>
    {
        internal Key(Pitch root, KeyMode keyMode)
        {
            Root = root;
            KeyMode = keyMode;

            ActualMode = KeyMode == KeyMode.Major
                ? Modes.Major
                : Modes.NaturalMinor;
            Scale = new Scale(Root, ActualMode);
            KeySignature = Pitches.SignatureAccidentals
                .Where(sa => Scale.ScalePitches.Any(sp => sp.ToString() == sa.ToString()))
                .ToList();
        }

        public Pitch Root { get; }
        public KeyMode KeyMode { get; }
        public Mode ActualMode { get; }
        public Scale Scale { get; }
        public List<Pitch> KeySignature { get; }
        public Key Relative => GetRelative();

        private Key GetRelative()
        {
            var keys = KeyMode == KeyMode.Major ? Keys.MinorKeys : Keys.MajorKeys;
            var root = keys
                .Where(k => k.KeySignature.Count == KeySignature.Count)
                .Where(k => k.KeySignature.FirstOrDefault() == KeySignature.FirstOrDefault())
                .Select(k => k.Root)
                .Single();
            var mode = KeyMode == KeyMode.Major ? KeyMode.Minor : KeyMode.Major;
            return new Key(root, mode);
        }

        public bool Equals(Key other)
            => other != null
                && Root.Equals(other.Root)
                && KeyMode == other.KeyMode;

        public override bool Equals(object obj)
            => (obj is Key) && Equals((Key)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Root)
                .Hash(KeyMode);
    }
}