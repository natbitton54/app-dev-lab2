using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize array of employees
            var employees = new[]
            {
                new Employee("Jason", "Red", 5000M),
                new Employee("Ashley", "Green", 7600M),
                new Employee("Matthew", "Indigo", 3587.5M),
                new Employee("James", "Indigo", 4700.77M),
                new Employee("Luke", "Indigo", 6200M),
                new Employee("Jason", "Blue", 3200M),
                new Employee("Wendy", "Brown", 4236.4M)};

            // display all employees
            Console.WriteLine("Original array:");
            foreach (var element in employees) {
                Console.WriteLine(element);
            }

            //filter a range of salaries btw 4k6k using && in a linq query
            var between4K6K =
                from e in employees
                where (e.MonthlySalary >= 4000m) && (e.MonthlySalary <= 6000M)
                select e;

            // display employees making between 4k and 6k per month
            Console.WriteLine("\nEmployees earning in the range" +
            $"{4000:C}-{6000:C} per month:");
            foreach (var element in between4K6K)
            {
                Console.WriteLine(element);
            }

            // order the employees by last name, then first name with LINQ
            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            // header
            Console.WriteLine("\nFirst employee when sorted by name:");
            // attempts to display the first result of the above linq query
            if (nameSorted.Any()){
                Console.WriteLine(nameSorted.First());
            } else
            {
                Console.WriteLine("Not found");
            }

            // use linq to select employee last names
            var lastName =
                from e in employees
                select e.LastName;

            // use method distinct to select unique last names
            Console.WriteLine("\nUnique employee last names:");
            foreach (var element in lastName.Distinct())
            {
                Console.WriteLine(element);
            }

            // use linq to select first and last names
            var names =
                from e in employees
                select new{e.FirstName, e.LastName};

            //Display full names
            Console.WriteLine("\nNames only:");
            foreach(var element in names)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }
    }
}

