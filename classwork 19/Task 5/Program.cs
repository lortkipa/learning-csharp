using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Index to access in already created array: ");
            //Console.WriteLine($"Member value: {AccessArrayElement(int.Parse(Console.ReadLine()))}");
        }

        public int AccessArrayElement(int index, int[] array)
        {
            return 2;
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException)
            {
            }
        }
    }
}
