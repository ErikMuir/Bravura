using System;
using Bravura.Common;

namespace Bravura.Tonality
{
    public class BravuraTonalityException : BravuraException
    {
        public BravuraTonalityException() : base("Unknown error") { }
        public BravuraTonalityException(string message) : base(message) { }
        public BravuraTonalityException(string message, Exception innerException) : base(message, innerException) { }
    }
}
