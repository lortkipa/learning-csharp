using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create string builder
            StringBuilder sb = new StringBuilder();

            /*
             * common patern is to just clear the text and append new one :)))
             */

            // first text
            sb.Append("Hello, guys!");
            Console.WriteLine(sb);

            // second text
            sb.Clear();
            sb.Append("Welcome To Step!");
            Console.WriteLine(sb);

            // third text
            sb.Clear();
            sb.Append("Welcome To IT Academy Step.");
            Console.WriteLine(sb);
        }
    }
}
