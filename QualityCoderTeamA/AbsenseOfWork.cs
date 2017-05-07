using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class AbsenseOfWork : Leave
    {
        public AbsenseOfWork(string EmployeeID, DateTime Date) : base(EmployeeID, Date)
        {
            IsPaid = false;
        }

        public override bool employeeLeaveAllowed()
        {
            throw new NotImplementedException();
        }

        public override double getPay()
        {
            throw new NotImplementedException();
        }
    }
}