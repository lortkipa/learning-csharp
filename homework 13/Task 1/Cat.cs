using System;

namespace Task_1
{
    class Cat
    {
        // fields
        static readonly int _biteSize = 10;
        private string _breed;
        private string _name;
        private Gender _gender;

        // properties
        public string Breed
        {
            get { return _breed; }
            set { _breed = value == null ? "Metis" : value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value == null ? "No Name" : value; }
        }
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public uint Age { get; set; }

        // methods
        public Cat()
        {
            Console.WriteLine($"---> Creating Cat.");

            // set name
            Console.Write("> Enter Name: ");
            _name = Console.ReadLine();

            // set breed
            Console.Write("> Enter Breed: ");
            _breed = Console.ReadLine();

            // set gender
            do
            {
                Console.Write("> Enter Gender: ");
            }
            while (!Enum.TryParse(Console.ReadLine(), true, out _gender));

            // set age
            uint _age;
            do
            {
                Console.Write("> Enter Age: ");
            }
            while (!uint.TryParse(Console.ReadLine(), out _age));
            Age = _age;

            Console.WriteLine($"---> Cat Created.");
        }
        public void Speak()
        {
            // print speaking
            Console.WriteLine("Meowing");
        }
        public void Eat(int gr)
        {
            // eat until 0 grams are left
            while (gr > 0)
            {
                Console.WriteLine("Eating...");
                gr -= _biteSize;
            }

            // print status
            Console.WriteLine($"{_name} Finished Eating.");
        }
    }
}
