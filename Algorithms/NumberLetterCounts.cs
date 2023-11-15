using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class NumberLetterCounts
    {
        /*
            If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

            If all the numbers from 1 to given limit inclusive were written out in words, how many letters would be used?
            
            Note: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
            The use of "and" when writing out numbers is in compliance with British usage.
        */
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

        //this function iterates the numbers below the limit
        public int numberLetterCounts(int limit)
        {   int res = 0;
            for (int i = 0; i <= limit; i++)
            {
                string word = numberToWords(i);
                res += countLetters(word);
            }
            return res;
        }

        //change the given number to the word
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
        //coutn the letters for each word
        static int countLetters(string word)
        {
            return word.Replace(" ", "").Replace("-", "").Length;
        }
    }
}
