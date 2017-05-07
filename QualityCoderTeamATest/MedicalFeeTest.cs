using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
    [TestClass]
    public class MedicalFeeTest
    {
        [TestMethod]
        public void Calculate_Annual_Medical_Fee_For_Employee_When_Id_And_No_Of_Years_In_Service_Given()
        {
            string employeeId = "100"; //Employee ID
            int noOfYearsInService = 2;
            decimal output = 0;
            MedicalFee medicalFee = new MedicalFee();
            output = medicalFee.calculateAnnualMedicalFee(employeeId, noOfYearsInService);

            Assert.AreEqual(500000, output);
        }
    }
}
