using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class PascalTriangle
    {
        /*
         * [
         *      [1],      0
         *     [1,1],     1
         *    [1,2,1],    2
         *   [1,3,3,1],
         *  [1,4,6,4,1]
         * [1,5,10,10,5,1]
         * ]
         */

        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                List<int> tempList = new List<int>();
                for (int j = 0; j < i+1; j++)
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

            return result;
        }

        //public IList<IList<int>> Generate(int numRows)
        //{
        //    List<IList<int>> result = new List<IList<int>>();
        //    int[][] vals = new int[numRows][];
        //    for (int i = 0;i < numRows; i++)
        //    {
        //        vals[i] = new int[i+1];
        //        for (int j = 0;j < vals[i].Length; j++)
        //        {
        //            if (j == 0 || j == i)
        //            {
        //                vals[i][j] = 1;
        //            }
        //            else
        //            {
        //                vals[i][j] = vals[i - 1][j - 1] + vals[i - 1][j];
        //            }
        //        }
        //    }

        //    return result;
        //}
    }
}
