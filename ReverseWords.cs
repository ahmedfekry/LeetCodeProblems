using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ReverseWords
    {
        public string reverseSolution(string s)
        {
            string[] res = s.Split(' ');
            s = "";
            for (int i = 0; i < res.Length-1; i++)
            {
                if (res[i].Length > 0)
                {
                    s = s + reverseWord(res[i]) + " ";
                }
            }

            return (s + reverseWord(res[res.Length-1])).Trim();
        }

        public string reverseWord(string s)
        {
            int i = 0;
            int j = s.Length-1;
            char[] ch = s.ToCharArray();
            while (i < j)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                i++;
                j--;
            }
            s = new string(ch);
            return s.Trim();
        }
    }
}
