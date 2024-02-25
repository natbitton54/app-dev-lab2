using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates an interger array
            var values = new[] {2, 9, 5, 0, 3, 7, 1, 4, 8, 5};

            //DisplayNameAttribute og values
            Console.Write("Original Array");
            foreach(var element in values)
            {
                Console.Write($" {element}");
            }
            
            // linq query that obtains values greater than 4 from array
            var filtered = 
                from value in values // data source is values
                where value > 4
                select value;

            // display filtered results
            Console.Write("\nArray values greater than 4:");
            foreach (var element in filtered)
            {
                Console.Write($"  {element}"); 
            }

            // use orderby clause to sort og values in ascending order
            var sorted =
                from value in values // data source in values
                orderby value
                select value;

            // display sorted results
            Console.Write("\nOrginal array, sorted:");
            foreach(var element in sorted)
            {
                Console.Write($"  {element}");
            }
            
            // sort filtered results into descending order
            var sortFilteredResults = 
                from value in filtered
                orderby value descending
                select value;

            // display the sorted results
            Console.Write(
             "\nValues greater than 4, descending order (two queries):");
            foreach (var element in sortFilteredResults)
            {
                Console.Write($" {element}");
            }

            // filter og array and sort results in descending order
            var sortAndFilter = 
                from value in values
                where value > 4
                orderby value descending
                select value;

            // display the filtered and sorted results
            Console.Write(
                    "\nValues greater than 4, descending (one query):");
            foreach (var element in sortAndFilter)
            {
                Console.Write($" {element}");
            }

            Console.WriteLine();
        }
    }
}
