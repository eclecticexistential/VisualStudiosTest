using System;

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
