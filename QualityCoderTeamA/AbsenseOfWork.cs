using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class AbsenseOfWork : Leave
    {
        public AbsenseOfWork(int EmployeeID, int NoOfDays) : base(EmployeeID, NoOfDays)
        {
            IsPaid = false;
        }

        public override double getPay()
        {
            throw new NotImplementedException();
        }
    }
}