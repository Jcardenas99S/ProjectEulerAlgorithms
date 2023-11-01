using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class EvenFibonacciNumbers
    {

        public int FibonacciNumbers(int number)
        {
            int sum = 1;
            int i =0;
            int sumEvenNumbers = 0;
            List<int> fibonacci = new List<int>();

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
