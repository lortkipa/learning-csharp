using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create books
            Book b1 = new Book();
            Book b2 = new Book("Cosmos", "Carl Sagan", 9.99, 1980);

            // print book infos
            b1.Print();
            b2.Print();
        }
    }

    public class Book
    {
        private string _title;
        private string _author;
        private double _price;
        private int _year;

        public Book()
        {
            // set default values to fields
            _title = "Unknow";
            _author = "Unknow";
            _price = 0;
            _year = 2025; // default year is current year
        }

        public Book(string title, string author, double price, int year)
        {
            // asign provided values to fields
            _title = title;
            _author = author;
            _price = price;
            
            // make sure publication year is not in future :d
            if (year > 2025)
                _year = 2025;
            else
                _year = year;
        }

        public void Print()
        {
            // print fields
            Console.WriteLine($"Title: {_title}, Author: {_author}, Price: {_price}, Year: {_year}");
        }
    }
}
