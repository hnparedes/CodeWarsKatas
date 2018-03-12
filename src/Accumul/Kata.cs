using System.Collections.Generic;
using System.Linq;

namespace Accumul
{
    internal static class Kata
    {
        internal static string Accum(string str)
        {
            // better solution
            // return string.Join("-", str.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));

            var s = str.ToLower();
            var list = new List<string>();

            for (var i = 0; i < s.Length; i++)
            {
                var temp = "";
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        temp += s[i].ToString().ToUpper();
                    }
                    else
                    {
                        temp += s[i];
                    }
                }

                list.Add(temp);
            }

            return string.Join("-", list);
        }
    }
}
