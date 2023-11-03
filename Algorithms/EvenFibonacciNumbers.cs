using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class EvenFibonacciNumbers
    {

        public long FibonacciNumbers(long number)
        {
            long sum = 1;
            long i =0;
            long sumEvenNumbers = 0;
            List<long> fibonacci = new List<long>();

            while (sum <= number)
            {      
                if (fibonacci.Count < 2)
                {
                    sum += i;
                    fibonacci.Add(sum);
                    if ((sum % 2) == 0) sumEvenNumbers += sum;
                }
                else
                {
                    //fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2]; 
                    sum = fibonacci.Last() + fibonacci[fibonacci.Count - 2];
                    fibonacci.Add(sum);
                    if ((sum % 2) == 0) sumEvenNumbers += sum;
                }
                i += 1;
            }
            return sumEvenNumbers;
        }
    }
}
