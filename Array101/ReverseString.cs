using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class ReverseString
    {
        public char[] ReverseStringSolution(char[] str)
        {
            int i = 0, j = str.Length - 1;

            while (i < j)
            {
                char temp = str[i];
                str[i] = str[j];
                str[j] = temp;
                i++; j--;
            }
            return str;
        }
    }
}
