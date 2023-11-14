using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class PowerDigitSum
    {
        /* 
            215 = 32768 and the sum of its digits is
            3 + 2 + 7 + 6 + 8 = 26.

            What is the sum of the digits of the number 2exponent?
         */
        public double powerDigitSum(int power)
        {
            //We elevete two power of the num that indicates on the function
            double res = Math.Pow(2, power);
            //convert the result in a char[] and replace the spaces whith 0
            char[] resChar = res.ToString("N").Replace('.', '0').Replace(',', '0').ToCharArray();
            double sum = 0;
            foreach (char num in resChar)
            {
                //Get the char number and cast to a int
                sum += (int)Char.GetNumericValue(num);
            }

            return sum;
        }
    }
}
