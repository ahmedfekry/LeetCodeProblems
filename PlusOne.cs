using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class PlusOne
    {
        public int[] PlusOneSolution(int[] digits)
        {
            string resnum = "";
            for (int i = 0; i < digits.Length; i++)
            {
                resnum += digits[i].ToString();
            }

            resnum = (BigInteger.Parse(resnum.ToString()) + 1).ToString();

            int[] resultArray = new int[resnum.Length];
            for (int i = 0; i < resnum.Length; i++)
            {
                resultArray[i] = int.Parse(resnum[i].ToString());
            }

            return resultArray;
        }
    }
}
