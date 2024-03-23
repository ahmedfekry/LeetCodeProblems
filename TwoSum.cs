using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class TwoSum
    {
        public int[] TwoSumSolution(int[] numbers,int target)
        {

            int[] result = new int[2];
            if (numbers.Length == 2)
            {
                result[0] = 1;
                result[1] = 2;
                return result;
            }

            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                int sum = numbers[i] + numbers[j];

                if (sum > target)
                {
                    j--;
                }
                else if (sum < target)
                {
                    i++;
                }
                else
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    break;
                }            
            }

            return result;

        }
    }
}
