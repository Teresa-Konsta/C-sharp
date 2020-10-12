using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec003_7_COMP123_02
{
	class Employee
	{
		private int employeeId;
		private string firstName;
		private string lastName;
		private double baseSalary;
		private double grossSales;
		private double comissionRate;

		public int EmplyeeId
		{
			get { return employeeId; }
		}
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
		public double BaseSalary
		{
			get { return baseSalary; }
			set { baseSalary = value; }
		}
		public double GrossSales
		{
			get { return grossSales; }
			set { grossSales = value; }
		}
		public double ComissionRate
		{
			get { return comissionRate; }
			set { comissionRate = value; }
		}
		public double Earnings()
		{
			double commission;
			commission = comissionRate * grossSales + baseSalary;
			return commission;
		}
		public Employee()
		{
			FirstName = firstName;
			LastName = lastName;
			BaseSalary = 1000.00;
			GrossSales = grossSales;
			ComissionRate = 0.1;

		}
		public Employee(int employeeId, string firstName, double baseSalary)
		{
			this.employeeId = employeeId;
			this.firstName = firstName;
			this.baseSalary = baseSalary;
		}
	}

	
}
