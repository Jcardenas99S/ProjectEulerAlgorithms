using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class SmallestMultiple
    {
       
        public long smallestMultiple(long num) 
        {
            int sn = 0;
            bool found = false;
            while (!found)
            {
                sn += 1;
                bool isDivisible = true;
                for (int i = 1; i <= num; i++)
                {
                    if ((sn % i) != 0)
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if(isDivisible) found = true;
            }
            return sn;
        }
    }
}
