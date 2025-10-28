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
            // get username
            Console.Write("Enter username: ");
            string userName = Console.ReadLine();
            for (int i = 0; i < userName.Length; i++)
                if (userName[i] == ' ')
                    throw new InvalidUsernameException("space \" \" detected in username");

            // get password
            Console.Write("Enter username: ");
            string password = Console.ReadLine();
            if (password.Length < 6)
                    throw new InvalidPasswordException("password is too short. it should be at list 6 digits ling");
        }
    }
}
