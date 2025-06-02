using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get student 1 data
            Console.Write("Student 1 FirstName: ");
            string firstName1 = Console.ReadLine();
            Console.Write("Student 1 LastName: ");
            string lastName1 = Console.ReadLine();
            Console.Write("Student 1 Score: ");
            byte score1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            // get student 1 data
            Console.Write("Student 2 FirstName: ");
            string firstName2 = Console.ReadLine();
            Console.Write("Student 2 LastName: ");
            string lastName2 = Console.ReadLine();
            Console.Write("Student 2 Score: ");
            byte score2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            // get student 1 data
            Console.Write("Student 3 FirstName: ");
            string firstName3 = Console.ReadLine();
            Console.Write("Student 3 LastName: ");
            string lastName3 = Console.ReadLine();
            Console.Write("Student 3 Score: ");
            byte score3 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            // calculate average
            byte average = (byte)((score1 + score2 + score3) / 3);

            // log average
            Console.WriteLine("Average Score Of Students Is: " + average);
            Console.WriteLine("-----------------------------------");
        }
    }
}
