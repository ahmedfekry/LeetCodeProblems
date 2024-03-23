using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class LargestNumberAtLeastTwice
    {
        public int DominantIndex(int[] nums)
        {
            int maxElement = 0;
            int maxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxElement)
                {
                    maxElement = nums[i];
                    maxIndex = i;
                }
            }

            for (int i = 0;i < nums.Length;i++)
            {
                if (nums[i] * 2 > maxElement && i != maxIndex)
                {
                    return -1;
                }
            }

            return maxIndex;
        }
    }
}
