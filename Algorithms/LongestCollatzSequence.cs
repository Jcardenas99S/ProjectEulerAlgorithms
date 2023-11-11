using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class LongestCollatzSequence
    {
        public long longestCollatzSequence(long limit)
        {
            
            int maxCount = 0;
            int maxRes = 0;
            for(int i = 2; i < limit; i++)
            {
                int count = 0;
                long res = i;
                while (res > 1)
                {
                    if (res % 2 == 0) res = res / 2;
                    else res = (3 * res) + 1;
                    count++;
                }
                if (count > maxCount)
                {
                    maxCount = count + 1;
                    maxRes = i;
                }
            }
           
            return maxRes;
        }



       
    }
}
