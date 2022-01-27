using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {   
        const int PRESENT = 1, ABSENT = 0, WAGE_PER_HOUR=20, FULL_DAY_HOUR=8;
        public void CalEmpWage()
        {
            Random random = new Random();

            Console.WriteLine("Enter the number of days you want to calculate the daily wage for: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int dailyWage = 0;

            for(int i = 0; i < num; i++)
            {
                int attdStatus = random.Next(0,2);
                if (attdStatus == PRESENT)
                {
                    dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                    Console.WriteLine($"The daily Wage for day {i+1} is: "+ dailyWage);
                }
                if (attdStatus == ABSENT)
                {
                    dailyWage = 0;
                    Console.WriteLine($"The daily Wage for day {i + 1} is: " + dailyWage);
                }
            }

            
        }
    }
}
