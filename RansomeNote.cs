using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class RansomeNote
    {
        public bool CanConstruct(string ransomNote,string magazine)
        {
            Dictionary<char,int> ranmap = new Dictionary<char,int>();
            Dictionary<char,int> magmap = new Dictionary<char,int>();

            foreach (char c in ransomNote)
            {
                if (ranmap.ContainsKey(c))
                    ranmap[c]++;
                else
                    ranmap[c] = 1;
                
            }

            foreach (char c in magazine)
            {
                if (magmap.ContainsKey(c))
                    magmap[c]++;
                else
                    magmap[c] = 1;
            }

            foreach (var keyValuePair in ranmap)
            {
                if (!magmap.ContainsKey(keyValuePair.Key) || magmap[keyValuePair.Key] <= keyValuePair.Value)
                    return false;
            }

            return true;
        }
    }
}
