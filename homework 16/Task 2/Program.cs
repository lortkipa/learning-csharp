using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Practice 1---------------");
            {
                Device[] devices = new Device[4];

                Console.Write("Enter Kettle model: ");
                devices[0] = new Kettle(Console.ReadLine());

                Console.Write("Enter Microwave model: ");
                devices[1] = new Microwave(Console.ReadLine());

                Console.Write("Enter TV model: ");
                devices[2] = new TV(Console.ReadLine());

                Console.Write("Enter Smartphone model: ");
                devices[3] = new SmartPhone(Console.ReadLine());

                Console.WriteLine("\n--- Devices Info ---\n");

                for (int i = 0; i < devices.Length; i++)
                {
                    devices[i].Show();
                    devices[i].Desc();
                    devices[i].SwitchOn();
                    devices[i].SwitchOff();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("---------------Practice 2---------------");
            {
                MusicalInstrument[] musicalInstruments = new MusicalInstrument[4];

                string type, desc, history;

                // create violin
                Console.Write("Enter Violin Type: ");
                type = Console.ReadLine();
                Console.Write("Enter Violin Description: ");
                desc = Console.ReadLine();
                Console.Write("Enter Violin History: ");
                history = Console.ReadLine();
                musicalInstruments[0] = new Violin(type, desc, history);

                // create ukulele
                Console.Write("Enter Ukulele Type: ");
                type = Console.ReadLine();
                Console.Write("Enter Ukulele Description: ");
                desc = Console.ReadLine();
                Console.Write("Enter Ukulele History: ");
                history = Console.ReadLine();
                musicalInstruments[1] = new Ukulele(type, desc, history);

                // create trombone
                Console.Write("Enter Trombone Type: ");
                type = Console.ReadLine();
                Console.Write("Enter Trombone Description: ");
                desc = Console.ReadLine();
                Console.Write("Enter Trombone History: ");
                history = Console.ReadLine();
                musicalInstruments[2] = new Trombone(type, desc, history);

                // create cello
                Console.Write("Enter Cello Type: ");
                type = Console.ReadLine();
                Console.Write("Enter Cello Description: ");
                desc = Console.ReadLine();
                Console.Write("Enter Cello History: ");
                history = Console.ReadLine();
                musicalInstruments[3] = new Cello(type, desc, history);

                Console.WriteLine("\n--------------------\n");

                // call intrument methods
                for (int i = 0; i < musicalInstruments.Length; i++)
                {
                    musicalInstruments[i].Sound();
                    musicalInstruments[i].Show();
                    musicalInstruments[i].Description();
                    musicalInstruments[i].History();
                    Console.WriteLine();
                }

                Console.WriteLine("\n--------------------\n");
            }
        }
    }
}
