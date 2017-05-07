using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class MedicalFee : Benefit
    {
        public double MedicalAllowance { get; set; }
        public double NoOfYearsInService { get; set; }

        public void calculateMonthlyMedicalFee()
        {
            if (NoOfYearsInService > 4)
                MedicalAllowance = 500000 / 12;
            else if (NoOfYearsInService > 2)
                MedicalAllowance = 100000 / 12;
            else if (NoOfYearsInService > 1)
                MedicalAllowance = 50000 / 12;
            else
                MedicalAllowance = 0;
        }
    }
}