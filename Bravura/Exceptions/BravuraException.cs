using System;

namespace Bravura.Exceptions
{
    public class BravuraException : Exception
    {
        public BravuraException(string message) : base(message) { }
    }
}