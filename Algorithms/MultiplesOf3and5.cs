using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class MultiplesOf3and5
    {
        public int multiplesOf3and5(int number)
        {
            int sum = 0;
            int m3 = 0;
            int m5 = 0;

            for (int i = 0; i < number; i++)
            {
                m3 = i % 3;
                m5 = i % 5;

                if (m3 == 0 || m5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
