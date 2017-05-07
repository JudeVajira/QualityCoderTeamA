using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class MedicalLeave : Leave
    {
        public MedicalLeave(int EmployeeID, DateTime Date) : base(EmployeeID, Date)
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