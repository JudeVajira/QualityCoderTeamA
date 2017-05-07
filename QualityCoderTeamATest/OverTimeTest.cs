using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
    [TestClass]
    public class OverTimeTest
    {
        [TestMethod]
        public void Calculate_Regular_OT_Allowance_For_Employee()
        {
            Employee employee = new Employee("", "", "", new DateTime(), "", 25000, 0, "", "");
            OverTime overTime = new OverTime();
            BasicSalaryRate basicSalaryRate = new BasicSalaryRate(employee);
            overTime.BasicHourlyRate = basicSalaryRate.getBasicSalaryDailyRate();
            overTime.NoOfHours = 4;
            double output = overTime.CalculateRegularOT(employee);
            Assert.AreEqual(625, output);
        }
    }
}
