using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class DiagonalTraverse
    {

        /*
            //Input: mat = [[1,2,3],[4,5,6],[7,8,9]]
            //Output: [1,2,4,7,5,3,6,8,9]

            //[0][0],

            //[0][1],
            //[1][0],

            //[2][0],
            //[1][1],
            //[0][2]

            //[2][1]
            //[1][2]

            //[2,2]
            //Input: mat = [[1,2],[3,4]]
            //Output: [1,2,3,4]
        */

        public int[] FindDiagonalOrder(int[][] mat)
        {
            if (mat == null || mat.Length == 0)
            {
                return new int[0];
            }

            int n = mat.Length;
            int m = mat[0].Length;

            int[] result = new int[m * n];
            int k = 0;
            for (int i = 0;i<m + n-1;i++)
            {
                List<int> temp = new List<int>();

                int r = i < m ? 0 : i - m + 1;
                int c = i < m ? i : m - 1;

                while (r < n && c > -1)
                {
                    temp.Add(mat[r][c]);
                    ++r;
                    c--;
                }

                if (i % 2 == 0)
                {
                    temp.Reverse();
                }

                for (int j = 0; j < temp.Count; j++)
                {
                    result[k++] = temp[j];
                }
            }

            return result;
        }
    }
}
