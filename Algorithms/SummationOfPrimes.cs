using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class SummationOfPrimes
    {
        public long primeSumation(long num)
        {
            long n = 2;
            long sum = 0;
            while (n < num) 
            { 
                bool isPrime = true;
                for(long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) sum += n;
                n++;
            }
            return sum;
        }
    }
}
