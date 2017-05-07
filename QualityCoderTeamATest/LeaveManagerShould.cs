using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;
using System.Collections.Generic;

namespace QualityCoderTeamATest
{
    [TestClass]
    public class LeaveManagerShould
    {
        [TestMethod]
        public void ReturnEmployeeLeaveListWhenGivenAnEmployeeID()
        {
            int employeeID = 1, month = 9;

            LeaveManager leaveManager = new LeaveManager();
            List<Leave> employeeLeaves = leaveManager.viewLeave(employeeID, month);

        }

        [TestMethod]
        public void ThrowAnExceptionWhenGivenANonExistentEmployeeID()
        {
        }

        [TestMethod]
        public void AddLeaveForEmployee()
        {
        }

        [TestMethod]
        public void ThrowExceptionWhenAddingLeaveForNonExistentEmployeeID()
        {
        }

        [TestMethod]
        public void ThrowExceptionWhenAddingLeaveForNonExistentLeaveType()
        {
        }

        [TestMethod]
        public void ThrowExceptionWhenAddingLeaveWithoutHavingLeaveAllowence()
        {
        }

        private List<Leave> DummyLeaveList() {

            return new List<Leave>()
            {


            };
        }
    }
}
