using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class Employee
    {
		#region Members
		private string			empID			= String.Empty;
		private string			name			= String.Empty;
		private string			gender			= String.Empty;
		private DateTime  		dob				= DateTime.MinValue.Date;
		private string			designation		= String.Empty;
		private double			basicSalary		= 0;
		private double			epfContribution	= 0;
		private string			phoneNumber		= String.Empty;
		private string			address			= String.Empty;
		private List<Employee>	employeeList	= null;
		#endregion

		#region Properties
		public String EmpID
		{
			get { return this.empID; }
			set { this.empID = value; }
		}
		public String Name
		{
			get { return this.name; }
			set { this.name = value; }
		}
		public String Gender
		{
			get { return this.gender; }
			set { this.gender = value; }
		}
		public DateTime DOB
		{			
			get { return this.dob; }
			set { this.dob = value; }
		}
		public String Designation
		{
			get { return this.designation; }
			set { this.designation = value; }
		}
		public Double BasicSalary
		{
			get { return this.basicSalary; }
			set { this.basicSalary = value; }
		}
		public Double EPFContribution
		{
			get { return this.epfContribution; }
			set { this.epfContribution = value; }
		}
		public String PhoneNumber
		{
			get { return this.phoneNumber; }
			set { this.phoneNumber = value; }
		}
		public String Address
		{
			get { return this.address; }
			set { this.address = value; }
		}
		public List<Employee> EmployeeList
		{
			get { return this.employeeList; }
			set { this.employeeList = value; }
		}

		#endregion

		#region Constructor

		public Employee()
		{

		}
	
		public Employee(string empId, string name, string gender, DateTime dob,
						string designation, double basicSalary, double epfContribution, string phoneNember, 
						string address)
		{
			this.empID				= empId;
			this.name				= name;
			this.gender				= gender;
			this.dob				= dob;
			this.designation		= designation;
			this.basicSalary		= basicSalary;
			this.epfContribution	= epfContribution;
			this.phoneNumber		= phoneNember;
			this.address			= address;

		}

		#endregion

		#region Methods

		public void ImportDataFileCSV()
		{
			CsvDataFile		employeeData		= new CsvDataFile();
			this.employeeList					= employeeData.getEmployeeList();
		} 

		public Employee AddEmployee(string empId, string name, string gender, DateTime dob, 
								string designation,double basicSalary, double epfContribution,
								string phoneNember, string address)
		{
			Employee		employee			= new Employee(empId, name, gender, 
																dob, designation, basicSalary, 
																epfContribution, phoneNember, address);
			return employee;
		}

		public Employee ViewEmployeeDetails(string empID)
		{
			Employee		empdetail			= EmployeeList.Where(a=> a.EmpID == empID).FirstOrDefault<Employee>();

			if(empdetail != null)
			{			
				return empdetail;
			}

			throw new NullReferenceException("Employee not found");		
					
		}

		#endregion

	}
}

