using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class Employee
    {
		public String EmpID { get; set; }

		public String Name { get; set; }

		public String Gender { get; set; }

		public DateTime DOB { get; set; }

		public String Designation { get; set; }

		public Double BasicSalary { get; set; }

		public Double EPFContribution { get; set; }

		public String PhoneNumber { get; set; }

		public String Address { get; set; }
		public User Use { get; set; }
		
		

        public void calculateSalary()
        {
            throw new System.NotImplementedException();
        }
    }
}

