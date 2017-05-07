using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1Test
{
    public class Salary
    {
        public Employee Employee
        {
            get;
            set;
        }

        public Leave Leave
        {

            get;
            set;
        }

        public Benefit Benefit
        {
            get;
            set;
        }

        public QualityCoderTeamA.Deduction Deduction
        {
            get;
            set;
        }

        public void calculate()
        {
            throw new System.NotImplementedException();
        }
    }
}