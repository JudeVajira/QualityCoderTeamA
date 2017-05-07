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
            overTime.BasicHourlyRate = basicSalaryRate.getBasicSalaryHourlyRate();
            overTime.NoOfHours = 4;
            double output = overTime.CalculateRegularOT(employee);
            Assert.AreEqual(937.5, output);
        }

        [TestMethod]
        public void Calculate_Regular_OT_Allowance_For_Employee_For_More_Then_4hours()
        {
            Employee employee = new Employee("", "", "", new DateTime(), "", 25000, 0, "", "");
            OverTime overTime = new OverTime();
            BasicSalaryRate basicSalaryRate = new BasicSalaryRate(employee);
            overTime.BasicHourlyRate = basicSalaryRate.getBasicSalaryHourlyRate();
            overTime.NoOfHours = 6;
            double output = overTime.CalculateRegularOT(employee);
            Assert.AreEqual(937.5, output);
        }

        [TestMethod]
        public void Calculate_Double_OT_Allowance_For_Employee()
        {
            Employee employee = new Employee("", "", "", new DateTime(), "", 25000, 0, "", "");
            OverTime overTime = new OverTime();
            BasicSalaryRate basicSalaryRate = new BasicSalaryRate(employee);
            overTime.BasicHourlyRate = basicSalaryRate.getBasicSalaryHourlyRate();
            overTime.NoOfHours = 7;
            double output = overTime.CalculateDoubleOT(employee);
            Assert.AreEqual(2187.5, output);
        }

        [TestMethod]
        public void Calculate_Double_OT_Allowance_For_Employee_For_More_Then_8hours()
        {
            Employee employee = new Employee("", "", "", new DateTime(), "", 25000, 0, "", "");
            OverTime overTime = new OverTime();
            BasicSalaryRate basicSalaryRate = new BasicSalaryRate(employee);
            overTime.BasicHourlyRate = basicSalaryRate.getBasicSalaryHourlyRate();
            overTime.NoOfHours = 10;
            double output = overTime.CalculateDoubleOT(employee);
            Assert.AreEqual(2500, output);
        }
    }
}
