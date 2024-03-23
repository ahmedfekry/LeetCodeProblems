using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class StrStr
    {
        public int solution(string heystack,string needle)
        {
            if (!heystack.Contains(needle))
            {
                return -1;
            }

            return heystack.IndexOf(needle);
        }
    }
}
