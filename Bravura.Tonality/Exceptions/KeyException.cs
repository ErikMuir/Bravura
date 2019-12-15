using System;
using System.Collections.Generic;

namespace Bravura.Tonality
{
    public class KeyException : BravuraTonalityException
    {
        public KeyException() : base() { }
        public KeyException(string message) : base(message) { }
        public KeyException(List<string> messages) : base(messages) { }
        public KeyException(string message, Exception innerException) : base(message, innerException) { }
    }
}
