using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class _10001stPrime
    {
        /*
            What is the nth prime number?
         */
        public long nthPrime(long num)
        {
            long n = 2;
            long count = 0;
            long lastPrime = 0;
            bool found = false;
            while (!found)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    count++;
                    if (count == num)
                    {
                        lastPrime = n;
                        found = true;
                    }
                }
                n++;
            }
            return lastPrime;
        }
    }
}
