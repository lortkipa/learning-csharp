using System;

namespace Task_2
{
    internal class Person
    {
        protected int _age;

        public virtual void Greet()
        {
            Console.WriteLine("Hello, I am person!");
        }

        public void SetAge(int age)
        {
            _age = age;
        }
    }

    internal class Student : Person
    {
        public override void Greet()
        {
            Console.WriteLine("Hello, I am Student!");
        }

        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"I'm {_age} years old");
        }
    }

    internal class Teacher : Person
    {
        public override void Greet()
        {
            Console.WriteLine("Hello, I am Teacher!");
        }

        public void Explain()
        {
            Console.WriteLine("I'm Explaining");
        }
    }
}
