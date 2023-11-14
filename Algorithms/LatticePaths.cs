using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class LatticePaths
    {
        /*
            Starting in the top left corner of a 2×2 grid, and only being able to move to the right
            and down, there are exactly 6 routes to the bottom right corner.

            a diagram of 6 2 by 2 grids showing all the routes to the bottom right corner
            How many such routes are there through a given gridSize?
         */
        public BigInteger latticePaths(BigInteger rows)
        {
            // (2N)!/(N!)^2 - probabilities of the number of paths
            BigInteger num = (factorial(2*rows));
            BigInteger dom = factorial(rows)* factorial(rows);
           
            return num / dom;
        }

        public static BigInteger factorial(BigInteger n)
        {
            BigInteger sumFactorial = 1;
            for(int i=1; i<=n;i++)
            {
                sumFactorial *= i;
            }

            return sumFactorial;
        }
    }
}
