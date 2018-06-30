using System;

namespace Bravura
{
    public class BravuraException : Exception
    {
        public BravuraException(string message) : base(message) { }
    }
}