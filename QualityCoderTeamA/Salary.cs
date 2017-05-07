using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class Salary
    {
        public int EmpID { get; set; }
        
        public List<Benefit> Benifits { get; set; }
        public List<Deduction> Deductions { get; set; }
        public List<Leave> Leaves { get; set; }

        public Salary(Int16 EmpID )
        {

        }

    }
}