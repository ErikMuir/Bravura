using System.Collections.Generic;
using System.Linq;

namespace Bravura.Extensions
{
    public static class KeyValuePairExtensions
    {
        /// <summary>
        /// Returns the Note that corresponds to the KeyValuePair.
        /// </summary>
        /// <param name="keyValuePair"></param>
        /// <returns></returns>
        public static Note GetNote(this KeyValuePair<char, int> keyValuePair)
            => Notes.AllNotes.Single(n => n.Letter == keyValuePair.Key && 
                                          n.SemitonesAboveC == keyValuePair.Value);
    }
}