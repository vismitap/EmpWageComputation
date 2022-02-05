using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welcome to Employee Wage Computation**********");
            EmployeeWageComputation employee = new EmployeeWageComputation();
            employee.CalEmpWage("TCS",18,21);
            employee.CalEmpWage("LTI", 17, 22);

        }
    }
}
