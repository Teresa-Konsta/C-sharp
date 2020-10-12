using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    /* Younga Jin #301055699 - COMP123
     * February 02, 2020 */
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            SetEmployeeInfo(p1);
            DisplayInfo(p1);

            Employee p2 = new Employee(1,"Young",1000);
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
                Console.Write("Enter gross sales. ");
                Console.Write("Gross sales should be positive: ");
                isProper = Double.TryParse(Console.ReadLine(), out userInput);
            } while (!isProper && userInput<=0);
            p.GrossSales = userInput;

            //Commission rate sales should never be negative or zero.
            //Commission rate should be between 0.1 (10%) and 1.0 (100%).
            do
            {
                Console.Write("Enter comission rate. ");
                Console.Write("0.1 (10%) ~ 1.0 (100%) : ");
                isProper = double.TryParse(Console.ReadLine(), out userInput);
                if (!(userInput >= 0.1 && userInput <= 1))
                {
                    isProper = false;
                }
            } while (!isProper);
            p.ComissionRate = userInput;
            //After the user enters all information,
            //the application will calculate Earnings
            //and display it formatted as currency.
            Console.WriteLine($"The earning is {p.Earnings():c}");
            Console.WriteLine("-------------------------------------");
        }
    }
}
