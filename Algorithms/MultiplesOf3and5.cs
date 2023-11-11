using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class MultiplesOf3and5
    {
        /* 
            Find the sum of all the multiples of 3 or 5 below the provided parameter value number. 
        */
        public int multiplesOf3and5(int number)
        {
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                
               int m3 = i % 3;
               int m5 = i % 5;
                //Here we check if the numer is multpile of 3 or 5 and if its correct we add that number.
                if (m3 == 0 || m5 == 0)
                {
                    sum += i;
                }
            }
            
            return sum;
        }
    }
}
