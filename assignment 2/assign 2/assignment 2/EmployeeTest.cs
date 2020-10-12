using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee(); // object 1

            Console.WriteLine("Enter your first name: ");
            myEmployee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            myEmployee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your base salary: ");
            myEmployee.BaseSalary = double.Parse(Console.ReadLine());

            int counter = 0;
            while (myEmployee.GrossSales <= 0)
            {
                Console.WriteLine("Enter gross sales: ");
                myEmployee.GrossSales = double.Parse(Console.ReadLine());
                counter++;
            }

            while(myEmployee.ComisionRate <= 0.1 && myEmployee.ComisionRate >= 1)
            {
                Console.WriteLine("Enter comission rate: ");
                myEmployee.ComisionRate = double.Parse(Console.ReadLine());
                counter++;
            }

            double employeeComission = myEmployee.Earnings();
            Console.WriteLine($"Your earnings: {employeeComission:C}");

            Employee myEmployee2 = new Employee(502, "Ivan", 5000); // object 2

            Console.WriteLine($"Your ID: {myEmployee2.EmployeeId}");
            Console.WriteLine($"Your first name: {myEmployee2.FirstName}");
            Console.WriteLine("Enter your last name: ");
            myEmployee2.FirstName = Console.ReadLine();
            Console.WriteLine($"Your base salary: {myEmployee2.BaseSalary}");

            while (myEmployee2.GrossSales <= 0)
            {
                Console.WriteLine("Enter gross sales: ");
                myEmployee2.GrossSales = double.Parse(Console.ReadLine());
                counter++;
            }

            while (myEmployee2.ComisionRate <= 0.1 && myEmployee2.ComisionRate >= 1)
            {
                Console.WriteLine("Enter comission rate: ");
                myEmployee2.ComisionRate = double.Parse(Console.ReadLine());
                counter++;
            }

            double employeeComission2 = myEmployee2.Earnings();
            Console.WriteLine($"Your earnings: {employeeComission2:C}");
        }
    }
}
