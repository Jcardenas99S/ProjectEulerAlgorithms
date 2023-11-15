using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class NumberLetterCounts
    {
        private string[] ones =
        {
            "",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen"
        };

        private string[] tens =
        {
                "",
                "",
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
        };

        int res = 0;
        public int numberLetterCounts(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                string word = numberToWords(i);
                res += countLetters(word);
            }
            return res;
        }



        public string numberToWords(int num)
        {
            string word = "";
            if (num < 20)
                word = ones[num];

            if (num >= 20 && num < 100)
                if (num % 10 == 0) word = tens[num / 10];
                else word = tens[num / 10] + ones[num % 10];

            if (num >= 100 &&  num < 1000)
            {
                if (num % 100 == 0) word = ones[num / 100] + "hundred";
                else word = ones[num / 100] + "hundredand" + numberToWords(num % 100);
            }
            if (num == 1000) word = "onethousand";

            return word;
        }
        static int countLetters(string word)
        {
            return word.Replace(" ", "").Replace("-", "").Length;
        }
    }
}
