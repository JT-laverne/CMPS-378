using System;

namespace LADWP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to LADWP Utility Bill Calculator ******");

            //Get user input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter electricity usage in kWh: ");
            double electricityUsage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter water usage in HCF: ");
            double waterUsage = Convert.ToDouble(Console.ReadLine());

            double electricityRate = 0;

            if (electricityUsage < 200)
                electricityRate = 0.13;
            else if (electricityUsage < 500)
                electricityRate = 0.17;
            else if (electricityUsage < 1000)
                electricityRate = 0.21;
            else
                electricityRate = 0.26;

            double waterRate = 0;

            if (waterUsage < 10)
                waterRate = 2.30;
            else if (waterUsage < 25)
                waterRate = 3.10;
            else if (waterUsage < 40)
                waterRate = 4.20;
            else
                waterRate = 5.15;

            //Calculate charges
            double electricityCharge = electricityUsage * electricityRate;
            double waterCharge = waterUsage * waterRate;
            double totalBill = electricityCharge + waterCharge;

            //Show Bill
            Console.WriteLine();
            Console.WriteLine("=========== LADWP MONTHLY BILL ===========");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Electricity Usage: {electricityUsage} kWh");
            Console.WriteLine($"Rate Applied: ${electricityRate:F2} per kWh");
            Console.WriteLine($"Electricity Charge: ${electricityCharge:F2}");
            Console.WriteLine($"Water Usage: {waterUsage} HCF");
            Console.WriteLine($"Rate Applied: ${waterRate:F2} per HCF");
            Console.WriteLine($"Water Charge: ${waterCharge:F2}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Amount Due: ${totalBill:F2}");
            Console.WriteLine("==========================================");
            Console.WriteLine("Thank you for using LADWP!");
        }
    }
}
