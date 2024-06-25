using System.Collections.Generic;
using System.Linq;

namespace Bravura.Tonality;

public record Key(Pitch Root, Modality Modality)
{
    public Scale Scale => new(Root, ImpliedMode);

    public List<Pitch> KeySignature => Pitches.SignatureAccidentals
        .Where(sa => Scale.Pitches.Any(sp => sp.DisplayValue() == sa.DisplayValue()))
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
}
