using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program loop
            while (true)
            {
                // get both number
                double num1 = GetNumber(1);
                double num2 = GetNumber(2);

                // get and do operation
                double result = CalculateOperation(num1, num2, out bool success);

                // if operation was succesfull, log it
                if (success)
                {
                    Console.WriteLine($"Result Is: {result}");
                }

                // ask user for exit
                Console.Write("Do You Want To Exit (Yes/...)? ");
                if (Console.ReadLine().ToLower() == "yes")
                    break;

                Console.WriteLine("----------------------------------------------------");
            }
        }

        static double GetNumber(uint num)
        {
            // ask for num
            Console.Write($"Enter Number {num}: ");

            // get and return number
            return Convert.ToSingle( Console.ReadLine() );
        }

        static double CalculateOperation(double num1, double num2, out bool success)
        {
            // ask for operation
            Console.WriteLine("--- Valid Operations ---");
            Console.WriteLine("'+' - Plus");
            Console.WriteLine("'-' - Minus");
            Console.WriteLine("'*' - Multiply");
            Console.WriteLine("'/' - Devide");
            Console.WriteLine("'p' - Pow");
            Console.WriteLine("'r' - Root");
            Console.Write("Enter Operation: ");

            // get operation
            char operation = Convert.ToChar(Console.ReadLine());

            // success if true as deafult and if operation is not found, then it becomes false
            success = true;

            double sum = 0;
            switch (operation)
            {
                case '+':
                    sum = num1 + num2;
                    break;
                case '-':
                    sum = num1 - num2;
                    break;
                case '*':
                    sum = num1 * num2;
                    break;
                case '/':
                    // check for 0 devision
                    if (num2 == 0)
                    {
                        Console.WriteLine("[ERROR]: Can't Devide By 0!");
                        success = false;
                        return 0.0;
                    }
                    sum = num1 / num2;
                    break;
                case 'p':
                    sum = Math.Pow(num1, num2);
                    break;
                case 'r':
                    sum = Math.Sqrt(num2);
                    break;
                default:
                    Console.WriteLine("[ERROR]: Invalid Operation!");
                    success = false;
                    break;
            }

            // return calculated sum (it will be 0 if operation was not found)
            return sum;
        }
    }
}
