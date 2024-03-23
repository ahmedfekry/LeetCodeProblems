using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MergeSortedArray
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/

        /*
         *  You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
            Merge nums1 and nums2 into a single array sorted in non-decreasing order.
            The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
         */
        public void Merge(int[] nums1,int m, int[] nums2, int n)
        {
            if (n == 0 || m == 0)
            {
                return;
            }

            int end = m + n - 1;
            m = m - 1;
            n = n - 1;
            while (end >= 0 && m >= 0 && n >= 0)
            {
                if (nums1[m] > nums2[n])
                {
                    nums1[end] = nums1[m];
                    m--;
                }else if (nums1[m] < nums2[n])
                {
                    nums1[end] = nums2[n];
                    n--;
                }
                else
                {
                    nums1[end--] = nums1[m];
                    nums1[end] = nums2[n];
                    m--;
                    n--;
                }
                end--;
            }

            while(m >= 0)
            {
                nums1[end] = nums1[m];
                end--;
                m--;
            }

            while (n >= 0)
            {
                nums1[end] = nums2[n];
                n--;
                end--;
            }
        }
    }
}
