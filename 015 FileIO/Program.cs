using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = ReadFile();

            DisplayEmployees(EmployeeList);

            //this will give an error unless the file is "released" from the read file method
            WriteDataToFile(Console.ReadLine(), Console.ReadLine());

            Console.ReadKey();
            EmployeeList = ReadFile();
            DisplayEmployees(EmployeeList);


        }

        private static void WriteDataToFile(string name, string salary)
        {
            StreamWriter sw = new StreamWriter("../../DataFile.txt", true); //the TRUE means it will Append
            sw.Write($"\n{name},{salary}");
            sw.Close();
        }

        private static List<Employee> ReadFile()
        {
            List<Employee> EmployeeList = new List<Employee>();



            ////////////////////////////////////
            string fileLocation = "../../DataFile.txt";

            StreamReader reader = new StreamReader(fileLocation);

            string Data = reader.ReadToEnd().Trim();

            string[] Records = Data.Split('\n');

            foreach (string record in Records)
            {
                string[] rc = record.Split(',');

                EmployeeList.Add(new Employee(rc[0].Trim(), float.Parse(rc[1].Trim())));
            }

            reader.Close();
            //////////////////////////////////

            return EmployeeList;
        }

        public static void DisplayEmployees(List<Employee> EmployeeList)
        {
            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine(emp.Name + " => " + emp.Salary);
            }

            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine($"Name:  {emp.Name.PadRight(20)} Salary:  ${emp.Salary}");
            }


            Console.WriteLine();
        }
    }
}
