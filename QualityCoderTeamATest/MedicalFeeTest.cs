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
            int noOfYearsInService = 3;
            decimal output = 0;
            MedicalFee medicalFee = new MedicalFee();
            output = medicalFee.calculateAnnualMedicalFee(noOfYearsInService);

            Assert.AreEqual(100000, output);
        }

        [TestMethod]
        public void Calculate_Annual_Medical_Fee_For_Employee_When_Id_And_No_Of_Years_Less_Than1()
        {
            int noOfYearsInService = 0;
            decimal output = 0;
            MedicalFee medicalFee = new MedicalFee();
            output = medicalFee.calculateAnnualMedicalFee(noOfYearsInService);

            Assert.AreEqual(0, output);
        }
    }
}
