using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladimirGlinskii.csCourse.thirdLab
{
    internal class WhatDay
    {
        enum MonthName { January, February, March, April, May, June, July, August, September, October, November, December};

        static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);

             
        int monthNum = 0;

            foreach (int daysInMonth in DaysInMonths)
            {

                if (dayNum <= daysInMonth)

                {
                    break;
                }

                else

                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }

            }

            MonthName monthName = (MonthName)monthNum; 
            Console.WriteLine("{0} {1}", dayNum, monthName);
        }
    }
}

