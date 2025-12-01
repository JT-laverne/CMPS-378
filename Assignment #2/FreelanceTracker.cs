using System;

namespace Assignment2
{
    public class FreelanceTracker
    {
        public static void Run()
        {
            Console.WriteLine("****** Welcome to Freelance Project Income Tracker ******");

            // Ask for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Number of projects
            Console.Write("How many projects would you like to enter? ");
            int projectCount = int.Parse(Console.ReadLine());

            double totalIncome = 0;
            double highestIncome = 0;
            string highestIncomeProject = "";

            // Loop through projects
            for (int i = 1; i <= projectCount; i++)
            {
                Console.WriteLine($"\nProject #{i}:");

                Console.Write("Enter project name: ");
                string projectName = Console.ReadLine();

                Console.Write("Enter hours worked: ");
                double hours = double.Parse(Console.ReadLine());

                Console.Write("Enter hourly rate: ");
                double rate = double.Parse(Console.ReadLine());

                double projectIncome = hours * rate;
                totalIncome += projectIncome;

                // Track highest income
                if (projectIncome > highestIncome)
                {
                    highestIncome = projectIncome;
                    highestIncomeProject = projectName;
                }
            }

            // Summary
            double avgIncome = totalIncome / projectCount;

            Console.WriteLine("\n========== FREELANCE INCOME SUMMARY ==========");
            Console.WriteLine($"Freelancer Name:         {name}");
            Console.WriteLine($"Projects Logged:         {projectCount}");
            Console.WriteLine();
            Console.WriteLine($"Total Income:            ${totalIncome:F2}");
            Console.WriteLine($"Average Project Income:  ${avgIncome:F2}");
            Console.WriteLine($"Highest-Earning Project: {highestIncomeProject} (${highestIncome:F2})");
            Console.WriteLine("==============================================");
            Console.WriteLine("Thank you for using the Income Tracker!");
        }
    }
}