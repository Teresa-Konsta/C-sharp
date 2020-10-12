﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    //Younga Jin
    //Ilah Song
    //Tereza Konstari
    class Employee
    {
        //Fields
        private int employeeId;
        private string firstName;
        private string lastName;
        private double baseSalary = 1000.00;
        private double grossSales;
        private double comissionRate = 0.1;

        //Properties
        public int EmployeeId
        {
            //read only
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

        //Methods
        public double Earnings()
        {
            //returns employee's commission
            return ComissionRate * GrossSales + BaseSalary;
        }

        //Constructors
        public Employee()
        {
        }
        public Employee(int employeeId, string firstName, double baseSalary)
        {
            this.employeeId = employeeId;
            FirstName = firstName;
            BaseSalary = baseSalary;
        }
    }
}
