using System.Collections.Generic;
using System.Linq;
using Bravura.Theory;

namespace Bravura.Extensions
{
    public static class KeyValuePairExtensions
    {
        public static Note GetNote(this KeyValuePair<char, int> keyValuePair)
            => Notes.AllNotes.Single(n => n.Letter == keyValuePair.Key && n.SemitonesAboveC == keyValuePair.Value);
    }
}