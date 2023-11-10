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
            var sum = 0L;
            foreach(string item in testNums)
            {
                sum += Convert.ToInt64(item);
            }
            string sumString = sum.ToString();
            string sumStringReplace = sumString.Replace('.', ' ').Replace(',', ' ').Substring(0, 10);
            var res = Convert.ToInt64(sumStringReplace);
            return res;
        }
    }
}
