using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class PaySheet
    {
        public string EmpID { get; set; }
        public string EmployeeName { get; set; }
        public double Duration { get; set; }

        public string Designation { get; set; }
        public double BasicSalary { get; set; }

        public List<Benefit> Benifits { get; set; }
        public List<Deduction> Deductions { get; set; }
        public double NetSalary { get; set; }
                                           // public List<Leave> Leaves { get; set; }

        public PaySheet()
        {

        }

    }
}