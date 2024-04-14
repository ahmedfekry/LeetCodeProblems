using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.InPlaceArrayOperations
{
    public class SortArrayByParity
    {
        public int[] SortArrayByParitySol(int[] nums)
        {
            int end = nums.Length-1;
            int start = 0;
            while (start < end)
            {
                if (nums[start] % 2 == 1 && nums[end] % 2 == 0)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                }
                else if (nums[start] % 2 == 0) // start is even increament start
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return nums;
        }
    }
}
