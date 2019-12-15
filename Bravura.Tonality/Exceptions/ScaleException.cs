using System;
using System.Collections.Generic;

namespace Bravura.Tonality
{
    public class ScaleException : BravuraTonalityException
    {
        public ScaleException() : base() { }
        public ScaleException(string message) : base(message) { }
        public ScaleException(List<string> messages) : base(messages) { }
        public ScaleException(string message, Exception innerException) : base(message, innerException) { }
    }
}
