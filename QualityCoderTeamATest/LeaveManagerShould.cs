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
            string employeeID = "1";
            int year = 2017, month = 5;

            LeaveManager leaveManager = new LeaveManager();
            LeaveManager.LeaveRepo = DummyLeaveList();

            List<Leave> employeeLeaves = leaveManager.viewLeave(employeeID, month, year);

            Assert.AreEqual(2, employeeLeaves.Count);
        }

        [TestMethod]
        public void AddLeaveForEmployee()
        {
            string employeeID = "1";
            int year = 2017, month = 5;

            LeaveManager leaveManager = new LeaveManager();
            LeaveManager.LeaveRepo = DummyLeaveList();

            leaveManager.markLeave(employeeID, "personal", new DateTime(2017, 05, 13));

            List<Leave> employeeLeaves = leaveManager.viewLeave(employeeID, month, year);

            Assert.AreEqual(3, employeeLeaves.Count);

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

            string EmployeeOne = "1";
            Leave EmployeeOneLeaveOne = new PersonalLeave(EmployeeOne, new DateTime(2017, 04, 29));
            Leave EmployeeOneLeaveTwo = new PersonalLeave(EmployeeOne, new DateTime(2017, 05, 01));
            Leave EmployeeOneLeaveThree = new PersonalLeave(EmployeeOne, new DateTime(2017, 05, 06));

            string EmployeeTwo = "2";
            Leave EmployeeTwoLeaveFour = new PersonalLeave(EmployeeTwo, new DateTime(2017, 04, 29));
            Leave EmployeeTwoLeaveFive = new PersonalLeave(EmployeeTwo, new DateTime(2017, 05, 02));

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
