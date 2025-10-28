using System;

namespace Task_1
{
    public class StudentTeacherTester
    {
        public void Test()
        {
            int _age;

            Console.WriteLine("----------Person----------");
            Person p1 = new Person();
            p1.Greet();

            Console.WriteLine("----------Student----------");
            Student p2 = new Student();
            p2.Greet();
            do
            {
                Console.Write("Student age: ");
            } while (!int.TryParse(Console.ReadLine(), out _age));
            p2.SetAge(_age);
            p2.ShowAge();

            Console.WriteLine("----------Teacher----------");
            Teacher p3 = new Teacher();
            p3.Greet();
            do
            {
                Console.Write("Teacher age: ");
            } while (!int.TryParse(Console.ReadLine(), out _age));
            p3.SetAge(_age);
            p3.Explain();
        }
    }
}
