using System;
using System.Collections.Generic;

namespace Bravura.Common
{
    public class BravuraException : Exception
    {
        public BravuraException() : base() { }
        public BravuraException(string message) : base(message) { }
        public BravuraException(List<string> messages) : base(string.Join(" ", messages)) { }
        public BravuraException(string message, Exception innerException) : base(message, innerException) { }
    }
}