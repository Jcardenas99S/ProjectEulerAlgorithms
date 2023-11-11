using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class LargestProductGrid
    {
        /*
            What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) 
            in a given arr grid?
         */
        public long largestProductGrid(int[,] testGrid)
        {
            var product = 0;
            var maxProduct = 0;
            //Left-Right == Right-left
            for (int i=0; i < testGrid.GetLength(0); i++)
            {
                for (int j = 0; j < testGrid.GetLength(1); j++)
                {
                    var limit = testGrid.GetLength(0) - 3;                  
                    if(j < limit)
                    {
                        //Left-Right == Right-Left
                        product = testGrid[i, j] * testGrid[i, j + 1] * testGrid[i, j + 2] * testGrid[i, j + 3];
                        if (product > maxProduct) maxProduct = product;
                       
                    }

                    if (i < limit)
                    {
                        //Up-Down == Down-Up
                        product = testGrid[i, j] * testGrid[i + 1, j] * testGrid[i + 2, j] * testGrid[i + 3, j];
                        if (product > maxProduct) maxProduct = product;
                    }

                    if(i < limit && j < limit)
                    {
                        //Diagonal -->
                        product = testGrid[i, j] * testGrid[i + 1, j + 1] * testGrid[i + 2, j + 2] * testGrid[i + 3, j + 3];
                        if (product > maxProduct) maxProduct = product;
                    }
                    if (i < limit && j > 2)
                    {
                        //Diagonal <--
                        product = testGrid[i, j] * testGrid[i + 1, j - 1] * testGrid[i + 2, j - 2] * testGrid[i + 3, j - 3];
                        if (product > maxProduct) maxProduct = product;
                    }

                }
            }
           
            return maxProduct;
        }
    }
}
