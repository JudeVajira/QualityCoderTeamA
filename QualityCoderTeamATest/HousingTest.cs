using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
    /// <summary>
    /// Summary description for HousingTest
    /// </summary>
    [TestClass]
    public class HousingTest
    {
        [TestMethod]
        public void Calculate_Housing_Allowance_For_Employee()
        {
            decimal output = 0;
            Housing housing = new Housing();
            output = housing.calculateHousingAllowance();

            Assert.AreEqual(0, output);
        }
    }
}
