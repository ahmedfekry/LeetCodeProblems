using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums.Length == 1 && nums[0] == 1)
            {
                return 1;
            }
            else if (nums.Length == 1 && nums[0] == 0)
            {
                return 0;
            }

            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                //int counter = 0;
                //if (nums[i] == 1)
                //{
                //    counter++;
                //    for (int j = i+1; j < nums.Length; j++)
                //    {
                //        if (nums[j] == 1)
                //        {
                //            counter++;
                //        }
                //        else
                //        {
                //            i = j;
                //            break;
                //        }
                //    }
                //    max = Math.Max(max, counter);
                //}
            }

            return max;
        }
    }
}
