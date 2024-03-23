using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class CheckForNAndDouble
    {
        public bool CheckifExists(int[] arr)
        {
            HashSet<int> list = new HashSet<int>(); 

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                if (list.Contains(temp * 2) || (temp%2 == 0 && list.Contains(temp/2)))
                {
                    return true;
                }
                list.Add(temp);
            }
            return false;
        }
    }
}
