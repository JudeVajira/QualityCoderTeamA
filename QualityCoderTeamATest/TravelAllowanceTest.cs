using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
    [TestClass]
    public class TravelAllowanceTest
    {
        [TestMethod]
        public void Calculate_Travel_Allowance_For_Employee()
        {
            decimal output = 0;
            TravelAllowance travelAllowance = new TravelAllowance();
            output = travelAllowance.calculateTravelAllowance();

            Assert.AreEqual(15000, output);
        }
    }
}
