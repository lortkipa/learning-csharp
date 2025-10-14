using System;

namespace Task_2
{
    internal abstract class MusicalInstrument
    {
        private string _type, _desc, _history;

        public MusicalInstrument(string type, string desc, string history)
        {
            _type = type;
            _desc = desc;
            _history = history;
        }

        public abstract void Sound();

        public void Show()
        {
            Console.WriteLine($"Type Of Instrument: {_type}");
        }

        public void Description()
        {
            Console.WriteLine($"Descsription Of Instrument: {_type}");
        }

        public void History()
        {
            Console.WriteLine($"History Of Instrument: {_history}");
        }
    }

    internal class Violin : MusicalInstrument
    {
        public Violin(string type, string desc, string history) : base(type, desc, history) 
        {
            Console.WriteLine("Violin Is Created");
        }

        public override void Sound()
        {
            Console.WriteLine("Making Violin Sound...");
        }
    }

    internal class Ukulele : MusicalInstrument
    {
        public Ukulele(string type, string desc, string history) : base(type, desc, history) 
        {
            Console.WriteLine("Ukulele Is Created");
        }

        public override void Sound()
        {
            Console.WriteLine("Making Violin Sound...");
        }
    }

    internal class Trombone : MusicalInstrument
    {
        public Trombone(string type, string desc, string history) : base(type, desc, history)
        {
            Console.WriteLine("Trombone Is Created");
        }

        public override void Sound()
        {
            Console.WriteLine("Making Violin Sound...");
        }
    }

    internal class Cello : MusicalInstrument
    {
        public Cello(string type, string desc, string history) : base(type, desc, history)
        {
            Console.WriteLine("Cello Is Created");
        }

        public override void Sound()
        {
            Console.WriteLine("Making Violin Sound...");
        }
    }
}
