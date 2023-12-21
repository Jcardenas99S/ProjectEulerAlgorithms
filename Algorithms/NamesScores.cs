using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class NamesScores
    {
        public int namesScores(string[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            List<string> list = new List<string>(arr);
            list.Insert(0, "");
            arr = list.ToArray();

            int total = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                total += NameScoreCalc(arr[i]) * i;
            }
            return total;
        }

        private int NameScoreCalc(string word)
        {
            int sum = 0;
            string[] alphabets = { "", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            foreach (char c in word.ToLower())
            {
                sum += Array.IndexOf(alphabets, c.ToString());
            }
            return sum;
        }
    }
}
