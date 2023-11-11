using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class SumSquareDifference
    {
        /*
            Find the difference between the sum of the squares of the first n natural numbers and the square of the sum.
         */
        public long sumSquareDifference(long num)
        {
            long n = 0;
            long n1 = 0;
            long n2 = 0;    
            long n3 = 0;    
  
            for (int i = 1; i <= num; i++)
            {
                n1 += i * i;
                n2 += i;
            }
            n3 = n2 * n2;
            n = n3 - n1;

            return n;
        }
    }
}
