using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QualityCoderTeamA;

namespace QualityCoderTeamATest
{
	[TestClass]
	public class EmployeeTest
	{
		[TestMethod]
		public void EmployeeImportDataFileRowCount()
		{
			Employee	emp		= new Employee();
			emp.ImportDataFileCSV();
			Assert.AreEqual(emp.EmployeeList.Count, 1000);

		}
	}
}
