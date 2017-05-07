using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
    [TestClass]
    public class MedicalFeeTest
    {
        [TestMethod]
        public void Calculate_Annual_Medical_Fee_For_Employee_When_Id_And_No_Of_Years_In_Service_Given(int noOfYears)
        {
            string employeeId = "100"; //Employee ID
            int noOfYearsInService = noOfYears;
            decimal output = 0;

            if (noOfYearsInService > 4)
                output = 500000;
            else if (noOfYearsInService > 2)
                output = 100000;
            else if (noOfYearsInService == 1)
                output = 50000;

            Assert.AreEqual(100000, output);
        }
    }
}
