using System;
using System.Collections.Generic;

namespace Assignment2
{
    public class ExpenseTracker
    {
        public static void Run()
        {
            Console.WriteLine("****** Welcome to Monthly Expense Tracker ******");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            double totalAmount = 0;
            int count = 0;

            string highestCategory = "";
            double highestCategoryTotal = 0;

            Dictionary<string, double> categoryTotals = new Dictionary<string, double>();

            while (true)
            {
                Console.Write("\nEnter expense category (or type 'done' to stop): ");
                string category = Console.ReadLine();

                if (category.ToLower() == "done")
                    break;

                Console.Write("Enter amount (-1 to quit): ");
                double amount = double.Parse(Console.ReadLine());

                if (amount == -1)
                    break;

                totalAmount += amount;
                count++;

                // Track per-category totals
                if (!categoryTotals.ContainsKey(category))
                    categoryTotals[category] = 0;

                categoryTotals[category] += amount;

                if (categoryTotals[category] > highestCategoryTotal)
                {
                    highestCategoryTotal = categoryTotals[category];
                    highestCategory = category;
                }
            }

            double avgExpense = (count > 0) ? totalAmount / count : 0;

            Console.WriteLine("\n========== MONTHLY EXPENSE SUMMARY ==========");
            Console.WriteLine($"Name:                    {name}");
            Console.WriteLine($"Total Entries:           {count}");
            Console.WriteLine($"Total Amount Spent:      ${totalAmount:F2}");
            Console.WriteLine($"Average Expense:         ${avgExpense:F2}");
            Console.WriteLine($"Highest Spending Category: {highestCategory}");
            Console.WriteLine("============================================");
            Console.WriteLine("Thank you for using the Monthly Expense Tracker!");
        }
    }
}
