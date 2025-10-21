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
            // create devices
            Device[] devices = new Device[2];
            Console.Write("Name of smart light: ");
            devices[0] = new SmartLight(Console.ReadLine());
            Console.Write("Name of thermostat: ");
            devices[1] = new Thermostat(Console.ReadLine());

            // test
            for (int i = 0; i < devices.Length; i++)
            {
                devices[i].TurnOn();
                devices[i].Control();
            }
        }
    }
}
