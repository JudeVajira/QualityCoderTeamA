using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class AbsenseOfWork : Leave
    {
        private string test;

        public AbsenseOfWork(bool IsPaid, int NoOfDays) : base(IsPaid, NoOfDays)
        {
        }

        public override double GetPay()
        {
            throw new NotImplementedException();
        }
    }
}