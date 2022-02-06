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
            employee.InputCompanyDetails("TCS", 200, 21);
            employee.InputCompanyDetails("LTI", 250, 21);

        }
    }
}
