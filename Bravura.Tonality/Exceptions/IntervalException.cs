using System;
using System.Collections.Generic;

namespace Bravura.Tonality
{
    public class IntervalException : BravuraTonalityException
    {
        public IntervalException() : base() { }
        public IntervalException(string message) : base(message) { }
        public IntervalException(List<string> messages) : base(messages) { }
        public IntervalException(string message, Exception innerException) : base(message, innerException) { }
    }
}
