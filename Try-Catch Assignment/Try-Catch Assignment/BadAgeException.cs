using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class BadAgeException : Exception
    {
        public BadAgeException()
            : base() { }
        public BadAgeException(string message)
            : base(message) { }
    }
}
