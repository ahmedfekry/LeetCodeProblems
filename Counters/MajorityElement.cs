using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Counters
{
    public class MajorityElement
    {
        public int MajorityElementSolution(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0) { 
                    candidate = nums[i];
                }

                if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
        //public int MahorityElementSolution(int[] array)
        //{
        //    Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (keyValuePairs.ContainsKey(array[i]))
        //        {
        //            keyValuePairs[array[i]]++;
        //        }
        //        else
        //        {
        //            keyValuePairs.Add(array[i], 1);
        //        }
        //    }

        //    foreach (var item in keyValuePairs)
        //    {
        //        if (item.Value > (array.Length/2))
        //        {
        //            return item.Key;
        //        }
        //    }
        //    return 0;
        //}
    }
}
