using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec003_7_COMP123_02
{
	class EmployeeTest
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee(121212, "John", 23.99);
			Console.WriteLine($"Employee ID: {employee.EmplyeeId}");
			Console.WriteLine($"First Name: {employee.FirstName}");
			Console.WriteLine($"Base salary: {employee.BaseSalary}");
			do
			{
				Console.Write("Enter your Gross sale: ");
				employee.GrossSales = double.Parse(Console.ReadLine());
			}
			while (employee.GrossSales <= 0);

			do
			{
				do
				{
					Console.Write("Enter your Commission rate: ");
					employee.ComissionRate = double.Parse(Console.ReadLine());
				}
				while (employee.ComissionRate <= 0.1 || employee.ComissionRate >= 1.0);

			}
			while (employee.ComissionRate <= 0);

			double calComission = employee.Earnings();
			Console.WriteLine($"Your commission is {calComission:c}");


			//Second Object
			Employee employee1 = new Employee();

			Console.Write("enter First name: ");
			employee1.FirstName = Console.ReadLine();
			Console.Write("enter Last name?: ");
			employee1.LastName = Console.ReadLine();
			Console.Write("enter your Base salary: ");
			employee1.BaseSalary = double.Parse(Console.ReadLine());

			do
			{
				Console.Write("Enter your Gross sale: ");
				employee1.GrossSales = double.Parse(Console.ReadLine());
			}
			while (employee1.GrossSales <= 0);

			do
			{
				do
				{
					Console.Write("Enter your Commission rate: ");
					employee1.ComissionRate = double.Parse(Console.ReadLine());
				}
				while (employee1.ComissionRate <= 0.1 || employee1.ComissionRate >= 1.0);

			}
			while (employee1.ComissionRate <= 0);

			double calComission2 = employee1.Earnings();
			Console.WriteLine($"Your commission is {calComission2:c}");

		}

	}
}
