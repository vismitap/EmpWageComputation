using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class CompanyBuilder
    {
        public string companyName { get; set; }
        public int wagePerHour { get; set; }
        public int workingDays { get; set; }
        public int totalHrs { get; set; }
        public int totalWage { get; set; }

    }
}
