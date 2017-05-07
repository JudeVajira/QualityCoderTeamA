using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class MaternityLeave : Leave
    {
        public MaternityLeave(int EmployeeID, DateTime Date) : base(EmployeeID, Date)
        {
            IsPaid = true;
        }

        public override bool employeeHasLeave()
        {
            throw new NotImplementedException();
        }

        public override double getPay()
        {
            throw new NotImplementedException();
        }
    }
}