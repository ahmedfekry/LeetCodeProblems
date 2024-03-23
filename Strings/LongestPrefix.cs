using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] words)
        {
            bool isFine = true;
            int index = 0;

            if (words.Length ==0 || words[0].Length == 0)
            {
                return "";
            }

            if (words.Length == 1)
            {
                return words[0];
            }

            while (isFine)
            {
                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i][index] == words[i - 1][index])
                    {
                        isFine = true;
                    }
                    else
                    {
                        isFine = false;
                        break;
                    }
                }

                if (isFine == true)
                {
                    index++;
                }
            }

            if (index == 0)
            {
                return "";
            }

            return words[0].Substring(0,index);
        }
    }
}
