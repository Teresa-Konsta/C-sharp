using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private double baseSalary;
        private double grossSales;
        private double comissionRate;

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                baseSalary = value;
            }
        }

        public double GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                grossSales = value;
            }
        }

        public double ComisionRate
        {
            get
            {
                return comissionRate;
            }
            set
            {
                comissionRate = value;
            }
        }

        public Employee() // EmployeeId -> how to initialize?
        {
            FirstName = firstName;
            LastName = lastName;
            BaseSalary = 1000.00;
            GrossSales = grossSales;
            ComisionRate = 0.1;
        }

        public Employee(int employeeId, string firstName, double baseSalary)
        {
            this.employeeId = employeeId;
            FirstName = firstName;
            BaseSalary = baseSalary;
        }

        public double Earnings()
        {
            double employeeComission = (ComisionRate * GrossSales) + BaseSalary;
            return employeeComission;
        }
    }
}
