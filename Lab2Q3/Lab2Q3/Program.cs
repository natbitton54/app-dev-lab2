using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create new list of strings
            var items = new List<string>();

            // displays lists of count and max capacity before adding elements
            Console.WriteLine("Before adding to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("red"); // appends item to the list
            items.Insert(0, "yellow"); // adds yellow to the list at index 0

            // displays list count and capacity after adding two elements
            Console.WriteLine("After adding two elements to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            // display the color in the list
            Console.Write("\nDisplay list contents with counter-controlled loop: ");
            for (var i = 0; i < items.Count; i++)
            {
                Console.Write($" {items[i]}");
            }

            // display the colors using for each loop
            Console.Write("\nDisplay list contents with foreach statement:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            items.Add("green"); // adds green to the end of list 
            items.Add("yellow"); // adds yellow to the end of the list ... after green

            // display List’s Count and Capacity after adding two more elements 
            Console.Write("\n\nAfter adding two more elements to item: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            // display the list 
            Console.Write("\nList with two new elements:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            items.Remove("yellow"); // removes the first yellow

            // display the list
            Console.Write("\n\nRemove first instance of yellow:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            items.RemoveAt(1); // removes item at index 1 which is green

            // display the list
            Console.Write("\nRemove second list element (green):");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            // display count and capacity after removing two elems
            Console.WriteLine("\nAfter removing two elements from items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            // check if value (red) is in the list
            Console.WriteLine("\n\"red\" is " + $"{(items.Contains("red") ? string.Empty : "Not ")}found in the list");

            items.Add("orange"); // adds orange to end of list
            items.Add("violet"); // adds violet at end of the list after orange
            items.Add("blue"); // adds blue at end of list after violet

            // display List’s Count and Capacity after adding three elements
            Console.WriteLine("\nAfter adding three more elements to items: " + $"Count = {items.Count}; Capacity = {items.Capacity}");
            // display the List
            Console.Write("List with three new elements:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();
        }
    }
}
