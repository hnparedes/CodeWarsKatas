using System.Collections.Generic;
using System.Linq;

namespace VowelCount
{
    internal static class Kata
    {
        internal static int GetVouwelCount(string str)
        {
            var vouwels = new List<char> {'a', 'e', 'i', 'o', 'u'};
            return str.Count(x => vouwels.Contains(x));
        }
    }
}
