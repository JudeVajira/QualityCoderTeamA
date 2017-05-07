using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace QualityCoderTeamA
{
    public class CsvDataFile : DataFile
    {
        public List<Employee> importEmployeeDataFileCSV(string filepath)
        {
            var parser = new CsvParser(File.OpenText(filepath));

            List<Employee> empList = new List<Employee>();
            while (true)
            {
                var row = parser.Read();
                if (row == null)
                {
                    break;
                }

                if (row[4] != "M" && row[4] != "F")
                {
                    continue;
                }


                var empId = row[0];
                var name = row[1];
                var gender = row[2];
                DateTime? dob = null;

                if (!string.IsNullOrWhiteSpace(row[3]))
                {
                    dob = Convert.ToDateTime(row[3]);
                }
                var designation = row[4];
                var basicSalary = Convert.ToDouble(row[5]);
                var test = row[6].TrimEnd('%');
                var epfContribution = Convert.ToDouble(test);
                var phoneNember = row[7];
                var address = row[8];


                Employee emp = new Employee(empId, name, gender, dob, designation, basicSalary, epfContribution, phoneNember, address);

                empList.Add(emp);


            }
            return empList;
        }

        public List<Employee> getEmployeeList()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string path = currentDirectory + "../../AppData/flatfilebackup1.csv";

            return importEmployeeDataFileCSV(path);
        }
    }
}