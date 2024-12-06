using System;
using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public record Key : ITonality
{
    internal Key(Pitch root, Modality modality)
    {
        Root = root;
        Modality = modality;
    }

    public Pitch Root { get; init; }

    public Modality Modality { get; init; }

    public Scale Scale => new(Root, ImpliedMode);

    public List<Pitch> KeySignature => Pitches.SignatureAccidentals
        .Where(sa => Scale.Pitches.Any(sp => sp.ToString() == sa.ToString()))
        .ToList();

    public Key Relative => GetRelative();

    public Key Transpose(Direction direction, Interval interval)
    {
        var newRoot = Root.Transpose(direction, interval);
        return new Key(newRoot, Modality);
    }

    private Mode ImpliedMode => Modality == Modality.Major ? Modes.Major : Modes.NaturalMinor;

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

    public static bool TryParse(string val, out Key key)
    {
        val = $"{val}"
            .Replace("Major", "", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Maj", "", StringComparison.InvariantCultureIgnoreCase)
            .Replace("Minor", "m", StringComparison.InvariantCultureIgnoreCase)
            .Replace("min", "m", StringComparison.InvariantCultureIgnoreCase);
        var modality = val.EndsWith('m') ? Modality.Minor : Modality.Major;

        val = val.Replace("m", "");
        var success = Pitch.TryParse(val, out var root);

        key = success ? new Key(root, modality) : null;
        return success;
    }

    public override string ToString() => $"{Root} {Modality}";
}
