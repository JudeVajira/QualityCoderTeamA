using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public abstract class Leave
    {
        public bool IsPaid { get; set; }

        public int NoOfDays { get; set; }

        public Leave(bool IsPaid, int NoOfDays)
        {
            this.IsPaid = IsPaid;
            this.NoOfDays = NoOfDays;
        }

        public abstract double GetPay();
    }
}