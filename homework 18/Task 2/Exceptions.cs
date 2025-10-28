using System;

namespace Task_2
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException() : base("Invalid username provided")
        {
        }

        public InvalidUsernameException(string msg) : base(msg)
        {
        }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Invalid password provided")
        {
        }

        public InvalidPasswordException(string msg) : base(msg)
        {
        }
    }
}
