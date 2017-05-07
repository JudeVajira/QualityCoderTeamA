using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class OverTime : Benefit
    {
        public double BasicHourlyRate { get; set; }
        public double OtRate { get; set; }
        public double NoOfHours { get; set; }

        public double CalculateRegularOT(Employee employee)
        {
            double basicSalaryHourlyRate = employee.BasicSalary / (20 * 8);
            double eligibleNoOfOtHours = this.NoOfHours;
            if (this.NoOfHours > 4)
                eligibleNoOfOtHours = 4;
            return BasicHourlyRate * eligibleNoOfOtHours * 1.5;
        }
    }
}