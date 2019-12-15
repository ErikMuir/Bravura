using System;
using System.Collections.Generic;

namespace Bravura.Tonality
{
    public class ModeException : BravuraTonalityException
    {
        public ModeException() : base() { }
        public ModeException(string message) : base(message) { }
        public ModeException(List<string> messages) : base(messages) { }
        public ModeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
