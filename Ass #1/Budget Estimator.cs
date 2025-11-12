using System;

namespace BudgetEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to the Road Trip Budget Estimator ******");

            //Get user input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many days will your trip be? ");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many miles will you drive in total? ");
            double totalMiles = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your car's MPG? ");
            double mpg = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the average gas price per gallon? ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your nightly hotel cost? ");
            double hotelPerNight = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your daily food budget? ");
            double foodPerDay = Convert.ToDouble(Console.ReadLine());

            //Calculations:
            double gasNeeded = totalMiles / mpg;
            double gasCost = gasNeeded * gasPrice;
            double hotelCost = hotelPerNight * (days - 1);
            double foodCost = foodPerDay * days;
            double totalCost = gasCost + hotelCost + foodCost;

            //Summary:
            Console.WriteLine();
            Console.WriteLine("=========== ROAD TRIP BUDGET SUMMARY ===========");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Trip Duration: {days} days");
            Console.WriteLine($"Total Miles: {totalMiles} miles");
            Console.WriteLine($"Fuel Efficiency: {mpg} MPG");
            Console.WriteLine($"Gas Price: ${gasPrice:F2}");
            Console.WriteLine();
            Console.WriteLine($"Hotel Cost/Night: ${hotelPerNight:F2}");
            Console.WriteLine($"Daily Food Budget: ${foodPerDay:F2}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Gas Needed: {gasNeeded:F2} gallons");
            Console.WriteLine($"Estimated Gas Cost: ${gasCost:F2}");
            Console.WriteLine($"Estimated Hotel Cost: ${hotelCost:F2}");
            Console.WriteLine($"Estimated Food Cost: ${foodCost:F2}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Estimated Trip Total: ${totalCost:F2}");
            Console.WriteLine("===============================================");
            Console.WriteLine("Thanks for using the Road Trip Budget Estimator!");
        }
    }
}
