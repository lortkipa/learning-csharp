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
            // create cat
            Cat cat1 = new Cat();

            // make cat eat
            int gr;
            do
            {
                Console.Write("Enter Food Weight In Grams: ");
            } while (!int.TryParse(Console.ReadLine(), out gr));
            cat1.Eat(gr);

            // make cat speak
            int count;
            do
            {
                Console.Write("Enter Meowing Count: ");
            } while (!int.TryParse(Console.ReadLine(), out count));
            for (int i = 0; i < count; i++)
                cat1.Speak();
        }
    }

    enum Gender
    {
        Male,
        Female
    }
}
