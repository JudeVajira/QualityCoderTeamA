using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class Employee
    {
		#region Properties
		public String EmpID { get; set; }
		public String Name { get; set; }
		public String Gender { get; set; }
		public DateTime DOB { get; set; }
		public String Designation { get; set; }
		public Double BasicSalary { get; set; }
		public Double EPFContribution { get; set; }
		public String PhoneNumber { get; set; }
		public String Address { get; set; }
		#endregion

		#region Constructor

		public Employee(string empId, string name, string gender, DateTime dob, string designation, double basicSalary, double epfContribution,
						string phoneNember, string address)
		{

		}


        public Employee()
        {
                
        }
		#endregion

	}
}

