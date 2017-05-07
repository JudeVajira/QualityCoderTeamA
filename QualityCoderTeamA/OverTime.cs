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
            double eligibleNoOfOtHours = this.NoOfHours;
            if (this.NoOfHours > 4)
                eligibleNoOfOtHours = 4;
            return (this.BasicHourlyRate* 1.5) * eligibleNoOfOtHours;
        }

        public double CalculateDoubleOT(Employee employee)
        {
            double eligibleNoOfOtHours = this.NoOfHours;
            if (this.NoOfHours > 8)
                eligibleNoOfOtHours = 8;
            return (this.BasicHourlyRate * 2) * eligibleNoOfOtHours;
        }
    }
}