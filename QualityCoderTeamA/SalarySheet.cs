using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class SalarySheet
    {
        List<PaySheet> salarySheetAll = new List<PaySheet>();

        public SalarySheet(List<Employee> empList,int PayrollMonth,int PayrollYear)
        {

            salarySheetAll= getSalarysheetGenerator(empList,PayrollMonth,PayrollYear);


        }



        public List<PaySheet> getSalarysheetForAll()
        {
            return salarySheetAll;
        }
        public List<PaySheet> getSalarysheetGenerator(List<Employee> empList,int PayrollMonth,int PayrollYear)
        {
            List<PaySheet> paySheets = new List<PaySheet>();
            LeaveManager leaveForSalary = new LeaveManager();
            PaySheet paySheetTestList = new PaySheet();
            double leaveDeduction = 0; 
            foreach (Employee empLst in empList)
            {
                // leaveDeduction = leaveForSalary.getLeavePeriodSalary(empLst.EmpID,PayrollMonth,PayrollYear);
                paySheetTestList.EmpID = empLst.EmpID;
                paySheetTestList.EmployeeName = empLst.Name;
                paySheetTestList.NetSalary = Convert.ToDouble(empLst.BasicSalary);

                paySheets.Add(paySheetTestList); 
            }

            
            return paySheets;
        }

    }
}