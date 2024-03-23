using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            decimal arraySum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                arraySum += nums[i];
            }

            decimal tempSum = 0;
            for (int i = 0;i < nums.Length;i++)
            {
                if (tempSum == (arraySum - nums[i]) / 2)
                {
                    return i;
                }
                else
                {
                    tempSum += nums[i]; 
                }
            }

            return -1;
        }
    }
}
