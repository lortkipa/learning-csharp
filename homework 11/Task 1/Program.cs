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
            // create persons
            Person p1 = new Person("Nikoloz", "Lortkipanidze", 16);
            Person p2 = new Person("Lionel", "Messi");

            // print person infos
            p1.Print();
            p2.Print();
        }
    }

    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        // age = 0 საშუალებას გვაძლევს ეს field შეუყვანელი დავტოვოთ
        public Person(string firstName, string lastName, int age = 0)
        {
            // store person info
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public void Print()
        {
            // print person fields
            Console.WriteLine($"FirstName: {_firstName}, LastName: {_lastName}, Age: {_age}");
        }
    }
}
