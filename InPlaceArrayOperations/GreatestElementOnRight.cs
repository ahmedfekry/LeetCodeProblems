using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.InPlaceArrayOperations
{
    public class GreatestElementOnRight
    {

        /*
         * 
         * https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
         * Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.
            After doing so, return the array.

 
         */
        public int[] ReplaceElements(int[] arr)
        {
            int Max = arr[arr.Length-1];
            arr[arr.Length - 1] = -1;
            for (int i = arr.Length-2;i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = Max;
                Max = Math.Max(Max, temp);
            }
            return arr;
        }
    }
}
