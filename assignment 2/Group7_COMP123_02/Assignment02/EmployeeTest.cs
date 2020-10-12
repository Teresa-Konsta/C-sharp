using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    //Younga Jin
    //Ilah Song
    //Tereza Konstari
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            Employee p2 = new Employee(1, "Jay", 2000);

            SetEmployeeInfo(p1);
            DisplayInfo(p1);

            SetEmployeeInfo(p2);
            DisplayInfo(p2);

        }
        //to checking
        static public void DisplayInfo(Employee p)
        {
            Console.WriteLine("        Employee Information");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Employee ID: {p.EmployeeId}");
            Console.WriteLine($"First Name: {p.FirstName}");
            Console.WriteLine($"LastName: {p.LastName}");
            Console.WriteLine($"Base Salary: {p.BaseSalary:c}");
            Console.WriteLine($"Gross Sales: {p.GrossSales:c}");
            Console.WriteLine($"ComissionRate: {p.ComissionRate*100}%");
            Console.WriteLine($"Earning: {p.Earnings():c}");
            Console.WriteLine("-------------------------------------");
        }

        static public void SetEmployeeInfo(Employee p)
        {
            Console.Write("Enter first name: ");
            p.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            p.LastName = Console.ReadLine();

            bool isProper;
            double userInput;
            do
            {
                Console.Write("Enter base salary: ");
                isProper = double.TryParse(Console.ReadLine(), out userInput);
            } while (!isProper);
            p.BaseSalary = userInput;

            //Gross sales should never be negative or zero.
            do
            {
                Console.Write("Enter gross sales. [It should be positive]: ");
                double.TryParse(Console.ReadLine(), out userInput);
            } while (userInput <= 0);
            p.GrossSales = userInput;

            //Commission rate sales should never be negative or zero.
            //Commission rate should be between 0.1 (10%) and 1.0 (100%).
            do
            {
                Console.Write("Enter comission rate. [0.1 (10%) ~ 1.0 (100%)] : ");
                double.TryParse(Console.ReadLine(), out userInput);
                
            } while (userInput < 0.1 || userInput > 1);
            p.ComissionRate = userInput;
            //After the user enters all information,
            //the application will calculate Earnings
            //and display it formatted as currency.
            Console.WriteLine($"The earning is {p.Earnings():c}");
            Console.WriteLine("-------------------------------------");
        }
    }
}
