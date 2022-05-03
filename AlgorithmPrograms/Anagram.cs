using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class Anagram
    {
        public static bool IsAnagram(string str1, string str2)
        {
            var str1R = str1.ToLower().ToArray();
            var str2R = str2.ToLower().ToArray();
            Array.Sort(str1R);
            Array.Sort(str2R);

            return new string(str1R) == new string(str2R);

        }
    }
}
