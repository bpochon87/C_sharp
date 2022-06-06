using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        // Creating two constructors and having them implement the same implementation that exists for exception.
        public FraudException()
            : base() { }
        // Overloading constructor.
        public FraudException(string message)
            : base(message) { }
    }
}
