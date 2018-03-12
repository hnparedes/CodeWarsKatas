namespace SumOfASequence
{
    internal static class Kata
    {
        /// <summary>
        /// Your task is to make function, which returns the sum of a sequence of integers.
        /// The sequence is defined by 3 non-negative values: begin, end, step.
        /// If begin value is greater than the end, function should returns 0
        /// </summary>
        internal static int SequenceSum(int start, int end, int step)
        {
            var sum = 0;
            for (var i = start; i <= end; i += step)
            {
                sum += i;
            }

            return sum;
        }
    }
}
