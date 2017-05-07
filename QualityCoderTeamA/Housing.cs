using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class Housing : Benefit,IEmployeeAllowance
    {
        public bool hasAllowance { get; set; }

        public decimal calculateHousingAllowance()
        {
            if (this.hasAllowance)
                return 15000;
            else
                return 0;
        }
    }
}