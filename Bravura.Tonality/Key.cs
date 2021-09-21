using System;
using System.Collections.Generic;
using System.Linq;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class Key : IEquatable<Key>
    {
        internal Key(Pitch root, Modality modality)
        {
            Root = root;
            Modality = modality;

            var mode = Modality == Modality.Major
                ? Modes.Major
                : Modes.NaturalMinor;
            Scale = new Scale(Root, mode);
            KeySignature = Pitches.SignatureAccidentals
                .Where(sa => Scale.Pitches.Any(sp => sp.ToString() == sa.ToString()))
                .ToList();
        }

        public Pitch Root { get; }
        public Modality Modality { get; }
        public Scale Scale { get; }
        public List<Pitch> KeySignature { get; }
        public Key Relative => GetRelative();

        private Key GetRelative()
        {
            var keys = Modality == Modality.Major ? Keys.MinorKeys : Keys.MajorKeys;
            var root = keys
                .Where(k => k.KeySignature.Count == KeySignature.Count)
                .Where(k => k.KeySignature.FirstOrDefault() == KeySignature.FirstOrDefault())
                .Select(k => k.Root)
                .Single();
            var modality = Modality == Modality.Major ? Modality.Minor : Modality.Major;
            return new Key(root, modality);
        }

        public bool Equals(Key other)
            => other != null
                && Root.Equals(other.Root)
                && Modality == other.Modality;

        public override bool Equals(object obj)
            => (obj is Key) && Equals((Key)obj);

        public override int GetHashCode()
            => HashCode.Start
                .Hash(Root)
                .Hash(Modality);
    }
}
