using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CMPS 378 - Assignment 2 =====");
            Console.WriteLine("1. Freelance Project Income Tracker");
            Console.WriteLine("2. Monthly Expense Tracker");
            Console.Write("Choose a program (1 or 2): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                FreelanceTracker.Run();
            }
            else if (choice == "2")
            {
                ExpenseTracker.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting program.");
            }
        }
    }
}