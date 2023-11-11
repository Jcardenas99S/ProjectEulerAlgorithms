using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class LargeSum
    {
        public long largeSum(string[] testNums)
        {
            
            BigInteger sum = 0;
            
            foreach(string num in testNums)
            {
                sum += BigInteger.Parse(num);
            }
            string sumString = sum.ToString();
            string sumStringReplace = sumString.Replace('.', ' ').Replace(',', ' ').Substring(0, 10);
            var res = Convert.ToInt64(sumStringReplace);
            return res;
        }
    }
}
