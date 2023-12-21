using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class AmicableNumbers
    {
        /*
        Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).

        If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

        For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. 
        The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

        Evaluate the sum of all the amicable numbers under n.
        */
        static int[] DIVISOR_SUMS = new int[100000];
        static int SumDivisors(int n)
        {
            // Return early if result already stored
            if (DIVISOR_SUMS[n] != 0)
                return DIVISOR_SUMS[n];

            // Compute divisor sum
            int sum = 1;
            int sqrt = (int)Math.Floor(Math.Sqrt(n));
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                    sum += i + n / i;
            }

            if (n % sqrt == 0 && sqrt * sqrt == n)
                sum -= sqrt;

            // Store and return result
            return DIVISOR_SUMS[n] = sum;
        }

        public int amicableNumbersSum(int n)
        {
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                int possiblePair = SumDivisors(i);
                if (possiblePair != i && SumDivisors(possiblePair) == i)
                    sum += i;
            }
            return sum;
        }
    }
}
