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
            // book
            Console.Write("Enter book title: ");
            string bookTitle = Console.ReadLine();
            Console.Write("Enter book author: ");
            string bookAuthor = Console.ReadLine();
            Book book = new Book(bookTitle, bookAuthor);
            book.PrintDetails();

            // magazine
            Console.Write("Enter magazine title: ");
            string magTitle = Console.ReadLine();
            Console.Write("Enter magazine ID: ");
            int magId = int.Parse(Console.ReadLine());
            Magazine magazine = new Magazine(magTitle, magId);
            magazine.PrintDetails();
        }
    }
}
