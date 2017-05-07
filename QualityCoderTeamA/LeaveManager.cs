using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityCoderTeamA
{
    public class LeaveManager
    {
        public static List<Leave> LeaveRepo = new List<Leave>();

        public List<Leave> viewLeave(string employeeID, int month, int year)
        {
            List<Leave> EmployeeLeave = LeaveRepo.Where(l => (l.EmployeeID == employeeID) &&
                                                             (l.Date.Month == month) &&
                                                             (l.Date.Year == year)).
                                                             ToList();
            return EmployeeLeave;
        }

        public double getLeavePeriodSalary(string employeeID, int month, int year)
        {
            double leavePeriodSalary = 0;

            foreach(Leave leave in viewLeave(employeeID, month, year))
            {
                if (leave.IsPaid)
                {
                    leavePeriodSalary += leave.getPay();
                }
            }

            return leavePeriodSalary;
        }

        public void markLeave(int employeeID, string leaveType, DateTime date)
        {
            Leave leave = null;

            switch (leaveType.ToLower())
            {
                case "personal":
                    leave = new MedicalLeave(employeeID, date);
                    break;
            }
        }
        
    }
}
