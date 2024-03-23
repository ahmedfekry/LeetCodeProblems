using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class PascalTriangle2
    {
        public IList<int> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows+1; i++)
            {
                List<int> tempList = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        tempList.Add(1);
                    }
                    else
                    {
                        tempList.Add(result[i - 1][j - 1] + result[i - 1][j]);
                    }
                }
                result.Add(tempList);
            }

            return result[numRows];
        }
    }
}
