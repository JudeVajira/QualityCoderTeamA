﻿using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
    /// <summary>
    /// Summary description for CsvDataFileShould
    /// </summary>
    [TestClass]
    public class CsvDataFileShould
    {
        [TestMethod]
        public void ReturnAListOfEmployees_When_CSVFilePathGiven()
        {
            CsvDataFile csvData = new CsvDataFile();
            List<Employee> empList = csvData.ImportEmployeeDataFileCsv("D:\\Downloads ALT\\flatfilebackup1.csv");

            Assert.IsNotNull(empList);
            Assert.IsInstanceOfType(empList[0], typeof(Employee));

        }

        [TestMethod]
        public void ReturnAListOfEmployees_When_EmployeeListRequested()
        {

            CsvDataFile csvData = new CsvDataFile();
            List<Employee> empList = csvData.getEmployeeList();

            Assert.IsNotNull(empList);
            Assert.IsInstanceOfType(empList[0], typeof(Employee));

        }
    }
}
