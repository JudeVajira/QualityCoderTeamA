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

		[TestMethod]
		public void ShouldViewEmployeeName()
		{
			Employee	emp				= new Employee();
			emp.ImportDataFileCSV();
			Employee	employeeDetail	= emp.ViewEmployeeDetails("E00001");
			if(employeeDetail != null)
			{
				Assert.AreEqual(employeeDetail.Name, "ALLISON,  PAUL W");
			}			
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void ShouldThrowWhenEmployeeNotFound()
		{
			Employee	emp				= new Employee();
			emp.ImportDataFileCSV();
			Employee	employeeDetail	= emp.ViewEmployeeDetails("E0000111");
		}

	}
}
