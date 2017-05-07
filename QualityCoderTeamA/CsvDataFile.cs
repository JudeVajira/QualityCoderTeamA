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
            while (true)
            {
                var row = parser.Read();
                if (row == null)
                {
                    break;
                }


            }
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