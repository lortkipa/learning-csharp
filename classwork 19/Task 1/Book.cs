using System;

namespace Task_1
{
    internal class Book : IPrintable
    {
        private string _title;
        private string _author;

        public Book(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Book title: \"{_title}\". author: \"{_author}\"");
        }
    }
}
