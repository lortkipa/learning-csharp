using System;

namespace Task_2
{
    internal partial class Program
    {
        abstract class Device
        {
            private string _model { get; }
            private string _desc { get; }

            public Device(string model, string desc)
            {
                _model = model;
                _desc = desc;
            }

            public void Show()
            {
                Console.WriteLine($"Model: {_model}");
            }

            public void Desc()
            {
                Console.WriteLine($"Description: {_desc}");
            }

            public void SwitchOn()
            {
                Console.WriteLine($"{_model} Is ON");
            }

            public void SwitchOff()
            {
                Console.WriteLine($"{_model} Is OFF");
            }
        }

        class Kettle : Device
        {
            public Kettle(string model) : base(model, "boils water")
            {
            }
        }

        class Microwave : Device
        {
            public Microwave(string model) : base(model, "heats food")
            {
            }
        }

        class TV : Device
        {
            public TV(string model) : base(model, "watch channels")
            {
            }
        }

        class SmartPhone : Device
        {
            public SmartPhone(string model) : base(model, "device for communication and other applications")
            {
            }
        }
    }
}
