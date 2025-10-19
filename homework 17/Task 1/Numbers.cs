namespace Task_1
{
    internal class Numbers : ICalc
    {
        private int[] _values;

        public Numbers(params int[] values)
        {
            _values = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                _values[i] = values[i];
            }
        }

        public int GetLessNumbersCount(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < _values.Length; i++)
            {
                if (_values[i] < valueToCompare)
                    count++;
            }
            return count;
        }

        public int GetGreaterNumbersCount(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < _values.Length; i++)
            {
                if (_values[i] > valueToCompare)
                    count++;
            }
            return count;
        }
    }
}
