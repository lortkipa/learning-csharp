using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputValidator validator = new UserInputValidator();

            Console.Write("Enter email: ");
            try
            {
                validator.ValidateEmail(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("-------------------- FormatException --------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }

            Console.Write("Enter age: ");
            try
            {
                validator.ValidateAge(int.Parse(Console.ReadLine()));
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("-------------------- InvalidAgeException --------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }

            Console.Write("Enter password: ");
            try
            {
                validator.ValidatePassword(Console.ReadLine());
            }
            catch (WeakPasswordException ex)
            {
                Console.WriteLine("-------------------- WeakPasswordException --------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
