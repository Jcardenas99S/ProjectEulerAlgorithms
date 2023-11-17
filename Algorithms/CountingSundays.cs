using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerAlgorithms.Algorithms
{
    public class CountingSundays
    {

        /*
            You are given the following information, but you may prefer to do some 
            research for yourself.

            1 Jan 1900 was a Monday.
            Thirty days has September,
            April, June and November.
            All the rest have thirty-one,
            Saving February alone,
            Which has twenty-eight, rain or shine.
            And on leap years, twenty-nine.

            A leap year occurs on any year evenly divisible by 4, but not on a century unless
            it is divisible by 400.
            How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
         */
        public int countingSundays(int fisrtYear, int lastYear)
        {
            int firstDay = intialDayOfTheYear(fisrtYear);
            int countSundays = 0;
            for (int year = fisrtYear; year <= lastYear; year++)
            {
                for(int months = 1; months <= 12; months++)
                {
                    if(firstDay % 7 == 0) countSundays++;
                    firstDay += monthsOfYear(months, year);
                }
            }
            return countSundays;
        }

        private static int intialDayOfTheYear(int fisrtYear)
        {
            int firstDayOfTheYear = 0;
            for (int year = 1900; year < fisrtYear; year++) 
            {
                firstDayOfTheYear += leapYear(year) ? 366 : 365;
            }
            return firstDayOfTheYear % 7 + 1;
        }
        

        private static bool leapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))? true : false;
        }

        private static int monthsOfYear(int months, int year)
        {
            switch (months)
            {
                case 1:
                    return 31;
                case 2:
                    return (leapYear(year) == true)? 29 : 28;
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;
                default: 
                    return 0;
            }
                
        }
    }
}
