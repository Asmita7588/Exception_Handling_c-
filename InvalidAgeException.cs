using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string massege) :base(massege) { }
    }

    
}
