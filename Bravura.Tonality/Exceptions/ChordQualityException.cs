using System;
using System.Collections.Generic;

namespace Bravura.Tonality
{
    public class ChordQualityException : BravuraTonalityException
    {
        public ChordQualityException() : base() { }
        public ChordQualityException(string message) : base(message) { }
        public ChordQualityException(List<string> messages) : base(messages) { }
        public ChordQualityException(string message, Exception innerException) : base(message, innerException) { }
    }
}
