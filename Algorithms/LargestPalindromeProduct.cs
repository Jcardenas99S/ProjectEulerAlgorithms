using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class LargestPalindromeProduct
    {

        /*
            Find the largest palindrome made from the product of two n-digit numbers.
         */
        public int largestPalindromeProduct(int n)
        {
            int n1 = 1;
            int polindrome = 0;
            int limit = Convert.ToInt16("1" + new string('0', n));

            while(n1 < limit)
            {
                int n2 = 1;
                while(n2 < limit)
                {
                    int result = n1 * n2;
                    string str = result.ToString();
                    char[] str2 = str.ToCharArray();
                    Array.Reverse(str2);
                    string str3 = new string(str2);
                    if (str.Equals(str3) && polindrome < result) polindrome = result;
                    n2++;
                }
                n1++;
            }
            return polindrome;
        }
    }
}
