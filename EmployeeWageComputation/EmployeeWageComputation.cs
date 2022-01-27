﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {   
        const int PRESENT = 1, ABSENT = 0, PART_TIME=2, WAGE_PER_HOUR=20, FULL_DAY_HOUR=8, PART_TIME_HOUR=4;
        public void CalEmpWage()
        {
            Random random = new Random();

            Console.WriteLine("Enter the number of days you want to calculate the daily wage for: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int dailyWage = 0;

            for(int i = 0; i < num; i++)
            {
                int attdStatus = random.Next(0,3);

                switch (attdStatus)
                {
                    case PRESENT:
                        dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                        break;

                    case PART_TIME:
                        dailyWage = WAGE_PER_HOUR * PART_TIME_HOUR;
                        break;

                    case ABSENT:
                        dailyWage = 0;
                        break;
                }

                Console.WriteLine($"The daily Wage for day {i + 1} is: " + dailyWage);

            }


        }
    }
}
