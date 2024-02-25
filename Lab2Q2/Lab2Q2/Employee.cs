using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2Q2
{
    internal class Employee
    {
        public string FirstName { get; } // read only automated implemented property
        public string LastName { get; } // read only auto implemented property
        private decimal monthlySalary; // monthly salary of employee

        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        // property that gets and sets the employee's monthly salary
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value >= 0m)
                {
                    monthlySalary = value;
                }
            }
        }

        // return a string containing the employee's info
        public override string ToString() => 
            $"{FirstName, -10} {LastName, -10} {MonthlySalary, -10:C}";
    }
}
