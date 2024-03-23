using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class MaximumWealth
    {
        public int MaximumWealthSolution(int[][] wealth)
        {
            int maxSum = 0;
            for (int i = 0; i < wealth.Length; i++)
            {
                maxSum = Math.Max(maxSum, this.ArraySum(wealth[i]));
            }

            return maxSum;
        }

        public int ArraySum(int[] array)
        {
            int sum = 0;
            for (int i = 0;i < array.Length;i++)
            {
                sum += array[i];    
            }
            return sum;
        }
    }
}
