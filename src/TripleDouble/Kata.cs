using System.Linq;

namespace TripleDouble
{
    internal static class Kata
    {
        internal static int TripleDouble(long num1, long num2)
        {
            return "0123456789".Count(number =>
                num1.ToString().Contains(new string(number, 3)) &&
                num2.ToString().Contains(new string(number, 2)));
        }
    }
}
