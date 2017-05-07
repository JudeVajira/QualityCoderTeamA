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
            int employeeID = 1, year = DateTime.Now.Year, month = DateTime.Now.Month;

            LeaveManager leaveManager = new LeaveManager();
            LeaveManager.LeaveRepo = DummyLeaveList();

            List<Leave> employeeLeaves = leaveManager.viewLeave(employeeID, month, year);

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

        private List<Leave> DummyLeaveList()
        {

            int EmployeeOne = 1;
            Leave EmployeeOneLeaveOne = new PersonalLeave(EmployeeOne, DateTime.Now.AddMonths(-1));
            Leave EmployeeOneLeaveTwo = new PersonalLeave(EmployeeOne, DateTime.Now.AddDays(-14));
            Leave EmployeeOneLeaveThree = new PersonalLeave(EmployeeOne, DateTime.Now.AddDays(-16));

            int EmployeeTwo = 2;
            Leave EmployeeTwoLeaveFour = new PersonalLeave(EmployeeTwo, DateTime.Now.AddMonths(-2));
            Leave EmployeeTwoLeaveFive = new PersonalLeave(EmployeeTwo, DateTime.Now.AddDays(-4));

            return new List<Leave>()
            {
                EmployeeOneLeaveOne,
                EmployeeOneLeaveTwo,
                EmployeeOneLeaveThree,
                EmployeeTwoLeaveFour,
                EmployeeTwoLeaveFive
            };
        }
    }
}
