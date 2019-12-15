using System;
using System.Collections.Generic;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class BravuraTonalityException : BravuraException
    {
        public BravuraTonalityException() : base() { }
        public BravuraTonalityException(string message) : base(message) { }
        public BravuraTonalityException(List<string> messages) : base(messages) { }
        public BravuraTonalityException(string message, Exception innerException) : base(message, innerException) { }
    }
}
