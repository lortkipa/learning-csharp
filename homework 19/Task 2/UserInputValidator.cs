using System;

namespace Task_2
{
    public class UserInputValidator
    {
        public void ValidateEmail(string email)
        {
            foreach (char c in email)
            {
                if (c == '@')
                    return;
            }

            throw new FormatException("Email should contain \"@\" symbol");
        }

        public void ValidateAge(int age)
        {
            if (age < 18)
                throw new InvalidAgeException("Age should be greater than 18");
        }

        public void ValidatePassword(string password)
        {
            if (password.Length < 8)
                throw new WeakPasswordException("Password length should be greater or equal to 8");
        }
    }
}
