using System;

namespace Bravura.Tonality.Exceptions
{
    public class BravuraTonalityException : Exception
    {
        public BravuraTonalityException() : base("Unknown error") { }
        public BravuraTonalityException(string message) : base(message) { }
        public BravuraTonalityException(string message, Exception innerException) : base(message, innerException) { }
    }
}