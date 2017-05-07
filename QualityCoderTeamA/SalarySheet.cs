using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class SalarySheet
    {
        public PaySheet PaySheet
        {
            get;
            set;
        }

        public List<Salary> getSalarysheetForAll(List<Employee> empList)
        {
            List<Salary> salarySheet = new List<Salary>();
            foreach(var empLst in empList)
            {
               

                 
            }
            return salarySheet;
        }

    }
}