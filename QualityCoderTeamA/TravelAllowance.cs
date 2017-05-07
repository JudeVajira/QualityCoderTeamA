using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class TravelAllowance : Benefit
    {
        public bool hasAllowance { get; set; }

        public decimal calculateTravelAllowance()
        {
            if (this.hasAllowance)
                return 15000;
            else
                return 20000;
        }
    }
}