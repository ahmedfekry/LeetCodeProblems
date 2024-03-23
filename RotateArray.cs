using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class RotateArray
    {
        //[1,2,3,4,5,6,7], k = 3
        //[5,6,7,1,2,3,4]

        //        nums = [-1,-100,3,99], k = 2
        //      Output:  [3,99,-1,-100]
        public void Rotate(int[] nums, int k)
        {
            Array.Reverse(nums,0,nums.Length-k);
            Array.Reverse(nums,nums.Length-k,k);
            Array.Reverse(nums);
        }


        // another solution
        //public void Rotate(int[] nums, int k)
        //{
        //    if (k > nums.Length)
        //    {
        //        k = k - nums.Length;
        //    }
        //    int i=0, j=Math.Abs(nums.Length - (k));
        //    int[] result = new int[nums.Length];
        //    nums.CopyTo(result,0);
        //    int f = 0;
        //    while(j < nums.Length)
        //    {
        //        nums[f] = result[j];
        //        f++;
        //        j++;
        //    }

        //    while(i < Math.Abs((result.Length-k)))
        //    {
        //        nums[f] = result[i];
        //        i++;
        //        f++;
        //    }

        //}
    }
}
