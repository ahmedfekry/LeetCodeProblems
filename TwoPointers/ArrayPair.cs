using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TwoPointers
{
    public class ArrayPair
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);

            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += Math.Min(nums[i], nums[i+1]);
            }

            return sum;
        }
    }
}
