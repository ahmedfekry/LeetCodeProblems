using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class RunningSum1DArray
    {
        public int[] RunningSum(int[] nums)
        {
            for(int i =1;i<nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i-1];
            }

            return nums;
        }
    }
}
