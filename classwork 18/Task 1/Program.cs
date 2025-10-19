using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);

            car.Drive();

            int fuel;
            do
            {
                Console.Write("Fuel amount for car: ");
            } while (!int.TryParse(Console.ReadLine(), out fuel));
            car.Refuel(fuel);
            car.Drive();
        }
    }
}
