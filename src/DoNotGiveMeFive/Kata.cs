namespace DoNotGiveMeFive
{
    internal static class Kata
    {
        internal static int DontGiveMeFive(int start, int end)
        {
            var count = 0;
            for (var i = start; i <= end; i++)
            {
                if (!i.ToString().Contains("5"))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
