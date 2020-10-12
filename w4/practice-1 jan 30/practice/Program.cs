using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();

            Console.Write("Enter Employee Number: ");
            myEmployee.EmployeeNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            myEmployee.Name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            myEmployee.Salary = double.Parse(Console.ReadLine());


            FileStream outFile = new FileStream("Employee.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(outFile);
            streamWriter.WriteLine($"{myEmployee.EmployeeNumber}, {myEmployee.Name}, {myEmployee.Salary}");
            streamWriter.Close();
            outFile.Close();
        }
    }
}
