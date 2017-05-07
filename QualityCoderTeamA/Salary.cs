using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class Salary
    {
        public string EmpID { get; set; }
        
        public List<Benefit> Benifits { get; set; }
        public List<Deduction> Deductions { get; set; }
        public List<Leave> Leaves { get; set; }

        public Salary(string EmpID )
        {

        }

    }
}