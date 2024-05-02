using System;
using System.Collections.Generic;

namespace CSharpDViz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("##############################");
            Console.WriteLine("WELCOME TO THE C# DATA VISUALIZER");
            Console.WriteLine("##############################");
            List<Number> numbers = new List<Number>();

            while (numbers.Count < 3)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                try
                {
                    int value = int.Parse(input);  // Convert string to int
                    numbers.Add(new Number(value));  // Create a new Number instance and add it to the list
                    Console.WriteLine("Added new number!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }
        }
    }
}