using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualityCoderTeamA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QualityCoderTeamATest
{
    [TestClass]
    public class Salary_Process_Should
    {



        public void Generate_Basic_Salary_For_Each_Employee()
        {
            var employees = new List<Employee>() {
                new Employee() {
                    PhoneNumber = "077-7342345",
                    Name = "Customer Name 1",
                    Address = "Billing Address 1",
                    BasicSalary =Convert.ToDouble("30,000.00")
                },
                new Employee() {
                    PhoneNumber = "077-2345434",
                    Name = "Customer Name 2",
                    Address = "Billing Address 2",
                    BasicSalary =Convert.ToDouble("60,000.02")
                },
                new Employee() {
                    PhoneNumber = "077-2345343",
                    Name = "Customer Name 3",
                    Address = "Billing Address 3",
                    BasicSalary =Convert.ToDouble("25,500.30")
                },
            };


        }
        [TestMethod]
        public void Generate_Salary_Sheet_For_All_Employees()
        {
            var employees = new List<Employee>() {
                new Employee() {
                    EmpID = "1",
                    PhoneNumber = "077-7342345",
                    Name = "Customer Name 1",
                    Address = "Billing Address 1",
                    BasicSalary =Convert.ToDouble("30,000.00")
                },
                new Employee() {
                    EmpID = "2",
                    PhoneNumber = "077-2345434",
                    Name = "Customer Name 2",
                    Address = "Billing Address 2",
                    BasicSalary =Convert.ToDouble("60,000.02")
                },
                new Employee() {
                    EmpID="3",
                    PhoneNumber = "077-2345343",
                    Name = "Customer Name 3",
                    Address = "Billing Address 3",
                    BasicSalary =Convert.ToDouble("25,500.30")
                },
            };

            Assert.AreEqual(3, employees.Count);

            SalarySheet salarySheet = new SalarySheet(employees,4,2017);
          

        }


        

    }
}
