using System;

namespace Bravura.Common
{
    public class BravuraException : Exception
    {
        public BravuraException() : base("Unknown error") { }
        public BravuraException(string message) : base(message) { }
        public BravuraException(string message, Exception innerException) : base(message, innerException) { }
    }
}