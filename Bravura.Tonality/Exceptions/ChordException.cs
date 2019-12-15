using System;
using System.Collections.Generic;

namespace Bravura.Tonality
{
    public class ChordException : BravuraTonalityException
    {
        public ChordException() : base() { }
        public ChordException(string message) : base(message) { }
        public ChordException(List<string> messages) : base(messages) { }
        public ChordException(string message, Exception innerException) : base(message, innerException) { }
    }
}
