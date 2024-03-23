using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class StepsNeededToZero
    {
        public int StepsNeededToZeroSolution(int n) 
        {
            int result = 0;
            while (n > 0) 
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    result++;
                }
                else
                {
                    n = n - 1;
                    result++;
                }
            }
            return result;
        }
    }
}
