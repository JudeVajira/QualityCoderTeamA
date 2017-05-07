using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityCoderTeamA
{
    public class CsvDataFile : DataFile
    {
        public List<Employee> importEmployeeDataFileCSV(string filename)
        {

            return null;
        }

        public List<Employee> getEmployeeList()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string path = currentDirectory + "../../AppData/flatfilebackup1.csv";

            return importEmployeeDataFileCSV(path);
        }
    }
}