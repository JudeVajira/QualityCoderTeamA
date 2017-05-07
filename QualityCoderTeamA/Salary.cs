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
            get => default(Employee);
            set
            {
            }
        }

        public Leave Leave
        {
            get => default(Leave);
            set
            {
            }
        }

        public Benefit Benefit
        {
            get => default(Benefit);
            set
            {
            }
        }

        public QualityCoderTeamA.Deduction Deduction
        {
            get => default(QualityCoderTeamA.Deduction);
            set
            {
            }
        }

        public void calculate()
        {
            throw new System.NotImplementedException();
        }
    }
}