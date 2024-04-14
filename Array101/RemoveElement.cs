using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Array101
{
    public class RemoveElement
    {
        public int RemoveElementSolution(int[] numbers, int val)
        {

            int k = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != val)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[k];
                    numbers[k] = temp;
                    k++;
                }
            }
            return k;
        }
        //public int RemoveElementSolution(int[] numbers,int val)
        //{
        //    if (numbers.Length == 0)
        //    {
        //        return 0;
        //    }

        //    int k = numbers.Length-1;
        //    int i = 0;
        //    while (i < k)
        //    {
        //        if (numbers[i] == val && numbers[k] == val)
        //        {
        //            k--;
        //        }
        //        else if (numbers[i] == val && numbers[k] != val)
        //        {
        //            int temp = numbers[i];
        //            numbers[i] = numbers[k];
        //            numbers[k] = temp;
        //            i++;
        //        }else if (numbers[i] != val)
        //        {
        //            i++;
        //        }
        //    }
        //    return k;
        //}
    }
}
