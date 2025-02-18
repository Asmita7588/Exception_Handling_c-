using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class InvalidEmployeeIdException : Exception
    {
        public InvalidEmployeeIdException(string msg) : base(msg) { }
    }
}
