using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class FactorialDigitSum
    {
        /*
            n! means n × (n − 1) × ... × 3 × 2 × 1

            For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
            and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

            Find the sum of the digits n!
         */
        public int factorialDigitSum(int num)
        {
            int sum = 0;
            BigInteger res = factorial(num);
            string sumString = res.ToString();
            char[] str2 = sumString.ToCharArray();
            foreach (char chr in str2)
            {
                //Get the char number and cast to a int
                sum += (int)Char.GetNumericValue(chr);
            }
            return sum;
        }
        //public static BigInteger factorial(int n)
        //{
        //    BigInteger resp = 1;
        //    for (BigInteger i = 1; i <= n; i++)
        //    {
        //        resp *= i;
        //    }

        //    return resp;
        //}

        public static BigInteger factorial(int n)
        {
            if (n <= 1) return n;
            return n * factorial(n-1);
        }

    }
}
