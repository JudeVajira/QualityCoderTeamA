using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public abstract class Leave
    {
        public int EmployeeID { get; set; }

        public bool IsPaid { get; set; }

        public int NoOfDays { get; set; }

        public Leave(int EmployeeID, int NoOfDays)
        {
            this.EmployeeID = EmployeeID;
            this.NoOfDays = NoOfDays;
        }

        public abstract double getPay();
    }
}