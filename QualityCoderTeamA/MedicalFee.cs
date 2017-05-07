using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class MedicalFee : Benefit
    {
        public decimal calculateAnnualMedicalFee(string employeeId, int noOfYearsInService)
        {
            if (noOfYearsInService > 4)
                return 500000;
            else if (noOfYearsInService > 2)
                return 100000;
            else if (noOfYearsInService == 1)
                return 50000;
            else
                return 0;
        }
    }
}