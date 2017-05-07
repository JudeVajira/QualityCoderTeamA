using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
    [TestClass]
    public class CsvDataFileShould
    {
        [TestMethod]
        public void ReturnAListOfEmployees_When_CSVFilePathGiven()
        {

            CsvDataFile csvData = new CsvDataFile();
            List<Employee> empList = csvData.importEmployeeDataFileCSV("D:\\Downloads ALT\\flatfilebackup1.csv");
        }
    }
}
