using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class MaximumPathSumI
    {
        public long maximumPathSumI(int[,] triangle)
        {
            int sum = 0;
            int[,] maxSum = triangle;
            for (int i=triangle.GetLength(0)  -  2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    maxSum[i, j] += Math.Max(triangle[i+1,j], triangle[i+1, j+1]);                
                }
            }
            return maxSum[0,0];
        }
    }
}
