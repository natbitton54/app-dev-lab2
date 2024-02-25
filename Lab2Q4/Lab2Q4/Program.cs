using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // populate a list of strings
            var items = new List<string>();
            items.Add("aQua"); // adds aQua to the end of list
            items.Add("RusT"); // adds RusT to end of list
            items.Add("yElLow"); // add "yElLow" to the end of the List
            items.Add("rEd"); // add "rEd" to the end of the List

            // display initial list
            Console.Write("items contains: ");
            foreach(var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line 

            // convert to uppercase, select those starting with R and sort
            var startsWithR =
                from item in items
                let uppercaseString = item.ToUpper()
                where uppercaseString.StartsWith("R") 
                orderby uppercaseString
                select uppercaseString;

            // display query result
            Console.Write("results of query startsWithR:");
            foreach(var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line

            items.Add("rUbY"); // add "rUbY" to the end of the List
            items.Add("SaFfRon"); // add "SaFfRon" to the end of the List

            // display initial list
            Console.Write("items contains: ");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line

            // display updated query results
            Console.Write("results of query startsWithR:");
            foreach (var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line
        }
    }
}
