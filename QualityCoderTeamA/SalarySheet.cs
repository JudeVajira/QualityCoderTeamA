using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class SalarySheet
    {
        public SalarySheet(List<Employee> empList,int PayrollMonth,int PayrollYear)
        {

            getSalarysheetGenerator(empList,PayrollMonth,PayrollYear);


        }



        public void getSalarysheetForAll()
        {

        }
        public List<PaySheet> getSalarysheetGenerator(List<Employee> empList,int PayrollMonth,int PayrollYear)
        {
            List<PaySheet> paySheets = new List<PaySheet>();
            LeaveManager leaveForSalary = new LeaveManager();
            double leaveDeduction = 0; 
            foreach (Employee empLst in empList)
            {
               // leaveDeduction = leaveForSalary.getLeavePeriodSalary(empLst.EmpID,PayrollMonth,PayrollYear);

                 
            }
            return paySheets;
        }

    }
}