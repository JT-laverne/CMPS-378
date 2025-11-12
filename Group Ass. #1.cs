using System;

namespace GroupAss1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of gas station: ");
            string gasStationName = Console.ReadLine();

            Console.Write("Enter the price of gas: ");
            double pricePerGallon = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many gallons: ");
            double gallons = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the tax percentage for this transaction: ");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            // Calculate tax & total
            double subtotal = pricePerGallon * gallons;
            double tax = subtotal * (taxRate / 100);
            double total = subtotal + tax;

            // Print Receipt
            Console.WriteLine();
            Console.WriteLine("******* " + gasStationName + " *******");
            Console.WriteLine($"Gas price: ${pricePerGallon:F2}");
            Console.WriteLine($"Number of gallons: {gallons}");
            Console.WriteLine($"Tax rate: {taxRate:F2}%");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Tax: ${tax:F2}");
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
