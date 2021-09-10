using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Key : IEquatable<Key>
    {
        internal Key(Pitch root, KeyTonality tonality)
        {
            Root = root;
            Tonality = tonality;

            var mode = Tonality == KeyTonality.Major
                ? Modes.Major
                : Modes.NaturalMinor;
            Scale = new Scale(Root, mode);
            KeySignature = Pitches.SignatureAccidentals
                .Where(sa => Scale.Pitches.Any(sp => sp.ToString() == sa.ToString()))
                .ToList();
        }

        public Pitch Root { get; }
        public KeyTonality Tonality { get; }
        public Scale Scale { get; }
        public List<Pitch> KeySignature { get; }
        public Key Relative => GetRelative();

        private Key GetRelative()
        {
            var keys = Tonality == KeyTonality.Major ? Keys.MinorKeys : Keys.MajorKeys;
            var root = keys
                .Where(k => k.KeySignature.Count == KeySignature.Count)
                .Where(k => k.KeySignature.FirstOrDefault() == KeySignature.FirstOrDefault())
                .Select(k => k.Root)
                .Single();
            var mode = Tonality == KeyTonality.Major ? KeyTonality.Minor : KeyTonality.Major;
            return new Key(root, mode);
        }

        public bool Equals(Key other)
            => other != null
                && Root.Equals(other.Root)
                && Tonality == other.Tonality;

        public override bool Equals(object obj)
            => (obj is Key) && Equals((Key)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Root)
                .Hash(Tonality);
    }
}
