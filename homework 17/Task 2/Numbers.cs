using System;

namespace Task_2
{
    class Numbers : IOutput
    {
        private int[] _nums;

        public Numbers(int[] nums)
        {
            _nums = nums;
        }

        public void ShowEven()
        {
            Console.Write("Even Numbers: ");
            for (int i = 0; i < _nums.Length; i++)
                if (_nums[i] % 2 == 0)
                    Console.Write($"{_nums[i]} ");
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Odd Numbers: ");
            for (int i = 0; i < _nums.Length; i++)
                if (_nums[i] % 2 != 0)
                    Console.Write($"{_nums[i]} ");
            Console.WriteLine();
        }
    }
}
