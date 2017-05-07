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
        public List<Employee> ImportEmployeeDataFileCsv(string filepath) 
        {
            if (!File.Exists(filepath))
                throw new FileNotFoundException();

            List<Employee> empList = new List<Employee>();
            try
            {
                var parser = new CsvParser(File.OpenText(filepath));

                bool isFirstLine = true;

                while (true)
                {
                    var row = parser.Read();
                    if (string.IsNullOrWhiteSpace(row[0]))
                        break;

                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    Employee emp = getEmployeeFromStringArray(row);

                    empList.Add(emp);
                }
            }
            catch (IOException)
            {
                throw new IOException("File In Use");
            }

            return empList;
        }

        public List<Employee> getEmployeeList()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string path = currentDirectory + "../../../AppData/flatfilebackup1.csv";

            return ImportEmployeeDataFileCsv(path);
        }


        private Employee getEmployeeFromStringArray(string[] strArr)
        {
			Employee		employee		= new Employee();
            var empId = strArr[0];
            var name = strArr[1];
            var gender = strArr[2];
            DateTime dob = new DateTime();

            if (!string.IsNullOrWhiteSpace(strArr[3]))
            {
                dob = Convert.ToDateTime(strArr[3]);
            }
            var designation = strArr[4];
            var basicSalary = Convert.ToDouble(strArr[5]);
            var epfContribution = Convert.ToDouble(strArr[6].TrimEnd('%'));
            var phoneNember = strArr[7];
            var address = strArr[8];

            return  employee.AddEmployee(empId, name, gender, dob, designation, basicSalary, epfContribution, phoneNember, address);
        }
    }
}