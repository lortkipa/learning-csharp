using System;

namespace Task_2
{
    internal abstract class Device : IControllable
    {
        public string Name { get; set; }

        public Device(string name)
        {
            Name = name;
        }

        public abstract void Control();

        public abstract void TurnOn();
    }

    internal class SmartLight : Device
    {
        public int Brightness { get; set; }

        public SmartLight(string name) : base(name) { }

        public override void Control()
        {
            Console.WriteLine($"Controling smart light \"{Name}\"");
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Smart light \"{Name}\" is on");
        }
    }

    internal class Thermostat : Device
    {
        public int Temperature { get; set; }

        public Thermostat(string name) : base(name) { }

        public override void Control()
        {
            Console.WriteLine($"Controling thermostat \"{Name}\"");
        }

        public override void TurnOn()
        {
            Console.WriteLine($"Thermostat \"{Name}\" is on");
        }
    }
}
