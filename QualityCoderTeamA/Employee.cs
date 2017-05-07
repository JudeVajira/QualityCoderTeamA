using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1Test
{
    public class Employee : User
    {
        public User User
        {
            get => default(User);
            set
            {
            }
        }

        public void calculateSalary()
        {
            throw new System.NotImplementedException();
        }
    }
}