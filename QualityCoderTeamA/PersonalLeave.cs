using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class PersonalLeave : Leave
    {
        public PersonalLeave(int EmployeeID, int NoOfDays) : base(EmployeeID, NoOfDays)
        {
            IsPaid = true;
        }

        public override double getPay()
        {
            throw new NotImplementedException();
        }
    }
}