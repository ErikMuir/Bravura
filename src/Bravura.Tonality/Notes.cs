using System.Collections.Generic;
using Bravura.Common;

namespace Bravura.Tonality;

public static class Notes
{
    public static readonly Note C = new('C', 0);
    public static readonly Note D = new('D', 2);
    public static readonly Note E = new('E', 4);
    public static readonly Note F = new('F', 5);
    public static readonly Note G = new('G', 7);
    public static readonly Note A = new('A', 9);
    public static readonly Note B = new('B', 11);

    public static readonly ReadOnlyOrderedDictionary<char, short> MusicalAlphabet = new(
        new List<KeyValuePair<char, short>>
        {
            C.KeyValuePair,
            D.KeyValuePair,
            E.KeyValuePair,
            F.KeyValuePair,
            G.KeyValuePair,
            A.KeyValuePair,
            B.KeyValuePair,
        }.AsReadOnly());
}
