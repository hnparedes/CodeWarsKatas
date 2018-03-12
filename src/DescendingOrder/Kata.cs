using System.Linq;

namespace DescendingOrder
{
    internal static class Kata
    {
        internal static long DescendingOrder(long num)
        {
            return long.Parse(string.Join("", num.ToString().OrderByDescending(n => n)));
        }
    }
}
