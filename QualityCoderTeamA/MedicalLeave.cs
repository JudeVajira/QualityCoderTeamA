using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class MedicalLeave : Leave
    {
        public MedicalLeave(bool IsPaid, int NoOfDays) : base(IsPaid, NoOfDays)
        {
        }

        public override double GetPay()
        {
            throw new NotImplementedException();
        }
    }
}