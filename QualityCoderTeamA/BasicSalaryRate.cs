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

        public BasicSalaryRate(Employee employee)
        {
            this.employee = employee;
        }

        public double getBasicSalaryHourlyRate()
        {
            return this.BasicSalary / (20 / 8);
        }

        public double getBasicSalaryDailyRate()
        {
            return this.BasicSalary / 20;
        }
    }
}
