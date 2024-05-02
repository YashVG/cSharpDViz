using System;
using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("##############################");
        Console.WriteLine("WELCOME TO THE C# DATA VISUALIZER");
        Console.WriteLine("##############################");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        bool continueListBuild = true;
        string input;

        while (continueListBuild)
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            try
            {
                int value = int.Parse(input);  // Convert string to int
                numbers.Add(value);  // Create a new Number instance and add it to the list
                Console.WriteLine("Added new number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }

            Console.Write("Do you want to add more numbers [y/n]: ");
            input = Console.ReadLine();
            if (input.Equals("n"))
            {
                continueListBuild = false;
            }
        }

        Console.WriteLine();
        Console.Write("Here is your list of numbers: ");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine();
        Console.WriteLine("Do you want to search or sort [a/b]: ");
        input = Console.ReadLine();
        if (input.Equals("a"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This text is green!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This text is red!");

        }


    }
}