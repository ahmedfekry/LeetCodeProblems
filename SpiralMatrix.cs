using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class SpiralMatrix
    {
        /*
        //[
           [1,2,3],
           [4,5,6],
           [7,8,9]
        ]
        
        [0,0]
        [0,1]
        [0,2]-->
        [1,2]
        [2,2]-->
        [2,1]
        [2,0]-->
        [1,0]
        [1,1]
        */


        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();

            int numOfRows = matrix.Length;
            int numOfCols = matrix[0].Length;

            int rowBegin = 0;
            int rowEnd = numOfRows-1;

            int colBegin = 0;
            int colEnd = numOfCols-1;

            while(rowBegin <= rowEnd && colBegin <= colEnd)
            {
                //goto right
                for(int i = colBegin; i <= colEnd; i++)
                {
                    result.Add(matrix[rowBegin][i]);
                }
                rowBegin++;

                //goto down
                for(int i = rowBegin;i <= rowEnd; i++)
                {
                    result.Add(matrix[i][colEnd]);
                }
                colEnd--;

                //goto left
                if (rowBegin <= rowEnd)
                {
                    // Traverse Left
                    for (int j = colEnd; j >= colBegin; j--)
                    {
                        result.Add(matrix[rowEnd][j]);
                    }
                }
                rowEnd--;

                if (colBegin <= colEnd)
                {
                    // Traver Up
                    for (int j = rowEnd; j >= rowBegin; j--)
                    {
                        result.Add(matrix[j][colBegin]);
                    }
                }
                colBegin++;
            }
            return result;
        }
    }
}
