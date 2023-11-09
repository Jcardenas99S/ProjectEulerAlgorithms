using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class HighlyDivisibleTriangularNumber
    {
        public long higlhyDivisibleTriangularNumber(long divisible)
        {
            bool found = false;
            long trianNumber = 0;
            long n = 1;
            int count = 0;
            while (!found)
            {

                trianNumber += n;

                for (int i=1; i < Math.Sqrt(trianNumber); i++)
                {
                    if(trianNumber % i == 0)
                    {
                        count = count + 2;
                        if (count >= divisible)
                        {
                            found = true;
                            break;
                        }
     
                    }
                }
                if (!found) count = 0;
                n++;
               
            }

            return trianNumber;
        }
    }
}
