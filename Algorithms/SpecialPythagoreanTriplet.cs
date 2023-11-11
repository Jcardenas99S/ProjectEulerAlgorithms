using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class SpecialPythagoreanTriplet
    {
        /*
            There exists exactly one Pythagorean triplet for which a + b + c = 1000. 
            Find the product abc such that a + b + c = n.
         */
        public long specialPythagoreanTriplet(long num)
        {
            long res = 0;
            bool isPytTriple = false;
            while(!isPytTriple)
            {
                for (long a = 1; a <= num; a++)
                {
                    for(long b = 1; b <= num; b++)
                    {
                        for (long c = 1; c <= num; c++)
                        {
                            if (((a*a)+ (b*b))==(c*c) && a + b + c == num && a < b && b < c)
                            {
                                res = a * b * c;
                                isPytTriple = true;
                                break;
                            }
                        }
                        if (isPytTriple) break;
                    }
                    if (isPytTriple) break;
                }
            }
            return res;
        }
    }
}
