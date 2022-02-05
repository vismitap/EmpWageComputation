using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWageComputation
    {   
        const int PRESENT = 1, ABSENT = 0, PART_TIME=2, FULL_DAY_HOUR=8, PART_TIME_HOUR=4;
        int workingHours, dailyWage = 0, totalWage = 0, i = 0, totalHrs=0;
        public void CalEmpWage(String companyName, int WAGE_PER_HOUR, int WORKING_DAYS)
        {
            int days = WORKING_DAYS;
            Random random = new Random();
            Console.WriteLine("\n---- Monthly Wage Calculation ----");

            while(days > 0 && totalHrs <= 100)
            {
                int attdStatus = random.Next(0,3);

                switch (attdStatus)
                {
                    case PRESENT:
                        workingHours = FULL_DAY_HOUR;
                        break;

                    case PART_TIME:
                        workingHours = PART_TIME_HOUR;
                        break;

                    case ABSENT:
                        dailyWage = 0;
                        break;
                }

                dailyWage = WAGE_PER_HOUR * workingHours;
                totalWage += dailyWage;
                totalHrs += PART_TIME_HOUR;

                //Console.WriteLine($"The daily Wage for day {i + 1} is: Rs " + dailyWage);
                i++;
                days--;
            }
             Console.WriteLine("\nTotal Working Hours in the month for "+companyName+" : "+totalHrs+ "\nThe total Monthly wage is: Rs "+ totalWage+"\n");


        }
    }
}
