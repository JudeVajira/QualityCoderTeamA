using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public abstract class Leave
    {
        public string EmployeeID { get; set; }

        public bool IsPaid { get; set; }

        public DateTime Date { get; set; }

        public Leave(string EmployeeID, DateTime Date)
        {
            this.EmployeeID = EmployeeID;
            this.Date = Date;
        }

        public abstract double getPay();

        public abstract bool employeeLeaveAllowed();

    }
}