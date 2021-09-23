using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    static class StringExt
    {
        /// <summary>
        /// Split the string into several substrings which has the maxLength as the parameter give.
        /// </summary>
        /// <param name="maxLength">the max length in result strings</param>
        /// <returns>the result strings</returns>
        public static string[] Split(this string str, int maxLength)
        {
            int count = (int)Math.Ceiling((double)str.Length / maxLength);
            string[] res = new string[count];
            for (int i = 0, p = 0; i < str.Length; i += maxLength, ++p)
            {
                res[p] = str.Substring(i, Math.Min(maxLength, str.Length - i));
            }
            return res;
        }
    }
}
