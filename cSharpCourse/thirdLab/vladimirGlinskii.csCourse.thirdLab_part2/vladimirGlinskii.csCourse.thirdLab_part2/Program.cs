﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladimirGlinskii.csCourse.thirdLab_part2
{

    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

internal class Program
    {

        
        static void Main(string[] args)
        {


            try
            {
                Console.Write("Please input a day number between 1 and 365: ");

                int dayNum = int.Parse(Console.ReadLine());

                if (dayNum < 1 || dayNum > 365)
                {
                    throw new ArgumentOutOfRangeException("Day out of Range");
                }

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

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
                Console.ReadLine();
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }

        }

        static System.Collections.ICollection DaysInMonths
       = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    };


}
    



