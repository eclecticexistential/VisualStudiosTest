using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTestCode
{
    class ProgramExceptions : Exception
    {
        public ProgramExceptions()
        {

        }
        public ProgramExceptions(string message) : base(message)
        {

        }
    }
    class OutOfBoundsException : ProgramExceptions
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
