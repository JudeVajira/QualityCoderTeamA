using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityCoderTeamA
{
    public class BasicSalaryRate : Employee
    {
        private Employee employee;
        private const int NoOfWorkingDays = 20;
        private const int NoOfWorkingHours = 8;

        public BasicSalaryRate(Employee employee)
        {
            this.employee = employee;
        }

        public double getBasicSalaryHourlyRate()
        {
            return this.employee.BasicSalary / (NoOfWorkingDays * NoOfWorkingHours);
        }

        public double getBasicSalaryDailyRate()
        {
            return this.employee.BasicSalary / NoOfWorkingDays;
        }
    }
}
