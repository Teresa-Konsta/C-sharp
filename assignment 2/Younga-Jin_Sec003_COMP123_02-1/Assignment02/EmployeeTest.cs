﻿using System;
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
            Employee p2 = new Employee(1,"Young",1000);

            DisplayInfo(p1);
            DisplayInfo(p2);
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
            Console.WriteLine($"Base Salary: {p.BaseSalary}");
            Console.WriteLine($"Gross Sales: {p.GrossSales}");
            Console.WriteLine($"ComissionRate: {p.ComissionRate}");
            Console.WriteLine("-------------------------------------");
        }
        static public void SetEmployeeInfo(Employee p)
        {
            Console.Write("Enter first name: ");
            p.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            p.LastName = Console.ReadLine();
            Console.Write("Enter base salary: ");
            p.BaseSalary = double.Parse(Console.ReadLine());

            //Gross sales should never be negative or zero.
            bool isProper = true;
            double userInput;
            do
            {
                Console.WriteLine("Enter gross sales.");
                Console.Write("Gross sales should be positive: ");
                isProper = Double.TryParse(Console.ReadLine(), out userInput);
                if (userInput <= 0)
                {
                    isProper = false;
                }
            } while (!isProper);
            p.GrossSales = userInput;

            //Commission rate sales should never be negative or zero.
            //Commission rate should be between 0.1 (10%) and 1.0 (100%).
            isProper = true;
            userInput = 0;
            do
            {
                Console.WriteLine("Enter comission rate.");
                Console.Write("0.1 (10%) ~ 1.0 (100%) : ");
                isProper = double.TryParse(Console.ReadLine(), out userInput);
                if (!(userInput > 0 && userInput <= 1))
                {
                    isProper = false;
                }
            } while (!isProper);
            p.ComissionRate = userInput;
            //After the user enters all information,
            //the application will calculate Earnings
            //and display it formatted as currency.
            Console.WriteLine($"The earning is {p.Earnings():c}");
        }
    }
}
