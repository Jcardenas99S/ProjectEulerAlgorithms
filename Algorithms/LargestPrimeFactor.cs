using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class LargestPrimeFactor
    {
        public long largestPrimeFactor(long n)
        {
            long maxPrimeFactor = 2;
            long number = n;

            while (number > 1) {
                if (number % maxPrimeFactor == 0) {
                    number /= maxPrimeFactor;
                }
                else
                {
                    maxPrimeFactor++;
                }
            }
           
            return maxPrimeFactor;
        }
    }
}
