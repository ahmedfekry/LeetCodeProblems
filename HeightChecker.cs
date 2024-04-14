using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class HeightChecker
    {
        public int HeightCheckerSol(int[] heights)
        {
            int[] expected = new int[heights.Length];

            Array.Copy(heights, expected,heights.Length);

            Array.Sort(expected);
            int result = 0;
            for (int i = 0;i < expected.Length;i++)
            {
                if (expected[i] != heights[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
