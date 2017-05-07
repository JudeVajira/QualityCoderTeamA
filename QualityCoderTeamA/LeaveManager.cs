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

        public List<Leave> viewLeave(int employeeID, int month)
        {
            throw new NotImplementedException();
        }

        public double getLeavePeriodSalary(int employeeID, int month)
        {
            double leavePeriodSalary = 0;

            foreach(Leave leave in viewLeave(employeeID, month))
            {
                leavePeriodSalary += leave.getPay();
            }

            return leavePeriodSalary;
        }

        public void markLeave(int employeeID, string leaveType, int month)
        {
            
        }
    }
}
