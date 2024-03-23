using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ReplaceElements
    {
        public int[] Replace(int[] arr)
        {
            int maxin = -1;
            for (int i = arr.Length-1; i >=0 ; i--) {
                int temp = arr[i];
                arr[i] = maxin;
                maxin = Math.Max(maxin, temp);
            }
            return arr;
        }
    }
}
