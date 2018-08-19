using System;

namespace Bravura.Exceptions
{
    public class BravuraException : Exception
    {
        public BravuraException() : base("Unknown Bravura exception") { }
        public BravuraException(string message) : base(message) { }
    }
}