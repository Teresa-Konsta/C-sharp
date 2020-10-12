using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteJsonFile();
        }

        public static void WriteJsonFile()
        {
            Employee myEmployee = new Employee();

            Console.Write("Enter Employee Number: ");
            myEmployee.EmployeeNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            myEmployee.Name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            myEmployee.Salary = double.Parse(Console.ReadLine());

            FileStream outFile = new FileStream("Employee.json", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(outFile);

            string json = JsonConvert.SerializeObject(myEmployee); // serialize employee

            streamWriter.WriteLine(json);
            streamWriter.Close();
            outFile.Close();
        }

        public static void ReadTextFile()
        {
            FileStream inFile = new FileStream("EmployeeInfo.json",
                FileMode.Open,
                FileAccess.Read);

            StreamReader streamReader = new StreamReader(inFile);
            string line = streamReader.ReadLine();
            Employee myEmployee = JsonConvert.DeserializeObject<Employee>(line);

            Console.WriteLine($"Employee number: {myEmployee.EmployeeNumber}");
            Console.WriteLine($"Employee name: {myEmployee.Name}");
            Console.WriteLine($"Employee salary: {myEmployee.Salary:C}");

            streamReader.Close();
            inFile.Close();
        }


    }
}
