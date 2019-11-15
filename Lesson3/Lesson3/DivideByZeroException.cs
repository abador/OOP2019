using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class DivideByZeroException : Exception
    {
        public DivideByZeroException()
            : base("DivideByZeroAttempt")
        {
        }

        public DivideByZeroException(string message)
            : base(message)
        {
        }
    }
}
