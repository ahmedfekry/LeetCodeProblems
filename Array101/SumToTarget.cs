using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class SumToTarget
    {
        public int[] TwoSum(int[] numbers, int target)
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
                if (numbers[j] > target)
                {
                    j--;
                    continue;
                }

                if (target - numbers[i] > numbers[j])
                {
                    i++;
                    continue;
                }

                int sum = numbers[i] + numbers[j];
                if (sum == target)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    break;
                }
                else
                {
                    i++;
                    j--;
                }
            }

            return result;
        }
    }
}
