using System;

namespace Task_1
{
    internal class Magazine : IPrintable
    {
        private string _title;
        private long _issueNumber;

        public Magazine(string title, long issueNumber)
        {
            _title = title;
            _issueNumber = issueNumber;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Mazine title: \"{_title}\". issue number: \"{_issueNumber}\"");
        }
    }
}
