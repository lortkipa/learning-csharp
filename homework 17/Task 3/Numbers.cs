using System;

namespace Task_3
{
    class Numbers : ICalculate
    {
        private int[] _nums;

        public Numbers(int[] nums)
        {
            _nums = nums;
        }

        public int CountDistinct()
        {
            int count = 0;
            for (int i = 0; i < _nums.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (_nums[i] == _nums[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                    count++;
            }
            return count;
        }

        public int EqualToValue(int value)
        {
            int count = 0;
            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] == value)
                    count++;
            }
            return count;
        }
    }
}
