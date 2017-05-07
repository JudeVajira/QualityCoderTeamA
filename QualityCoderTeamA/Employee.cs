using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1Test
{
    public class Employee : User
    {
		public User Use { get; set; }
		

        public void calculateSalary()
        {
            throw new System.NotImplementedException();
        }
    }
}