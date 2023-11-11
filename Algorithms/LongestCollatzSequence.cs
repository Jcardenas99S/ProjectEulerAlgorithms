using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class LongestCollatzSequence
    {
        /*
            The following iterative sequence is defined for the set of positive integers:

                                        n → n/2 (n is even)
                                        n → 3n + 1 (n is odd)
                                        
            Using the rule above and starting with 13, we generate the following sequence:

            13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
            It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
            Although it has not been proved yet (Collatz Problem), 
            it is thought that all starting numbers finish at 1.
            
            Which starting number, under the given limit, produces the longest chain?
            
            Note: Once the chain starts the terms are allowed to go above limit.
        */
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
