using System;
using System.Runtime.Serialization;

namespace Task_2
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    internal class WeakPasswordException : Exception
    {
        public WeakPasswordException(string message) : base(message)
        {
        }
    }
}