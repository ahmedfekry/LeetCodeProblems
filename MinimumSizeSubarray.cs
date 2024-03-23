using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MinimumSizeSubarray
    {
        public int MinSubArrayLen(int target, int[] nums)
        {

            int i = 0, j = 0, sum = 0, ResultCounter = int.MaxValue;

            while (j < nums.Length)
            {
                sum += nums[j++];

                while (sum >= target)
                {
                    ResultCounter = Math.Min(ResultCounter, j - i);
                    sum -= nums[i++];
                }
            }

            return ResultCounter == int.MaxValue ? 0 : ResultCounter;

        }
    }
}
