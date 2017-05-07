using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class TravelAllowance : Benefit
    {
        public bool hasPetrolAllowance { get; set; }

        public decimal calculateTravelAllowance()
        {
            if (this.hasPetrolAllowance)
                return 15000;
            else
                return 20000;
        }
    }
}