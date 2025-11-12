using System;

namespace Bill Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to AT&T Fiber Internet Billing System ******");

            //Get user input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Select internet plan speed (300 / 500 / 1000 / 2000 / 5000 Mbps): ");
            int planSpeed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Would you like to add a static IP? (Y/N): ");
            string addStaticIP = Console.ReadLine().ToUpper();

            double basePrice = 0;

            switch (planSpeed)
            {
                case 300:
                    basePrice = 55.00;
                    break;
                case 500:
                    basePrice = 65.00;
                    break;
                case 1000:
                    basePrice = 80.00;
                    break;
                case 2000:
                    basePrice = 110.00;
                    break;
                case 5000:
                    basePrice = 180.00;
                    break;
                default:
                    Console.WriteLine("Invalid plan speed selected. Please restart the program.");
                    return;
            }

            double staticIPCost = (addStaticIP == "Y") ? 15.00 : 0.00;

            //Calculations:
            double subtotal = basePrice + staticIPCost;
            double tax = subtotal * 0.095; // 9.5% tax
            double total = subtotal + tax;

            //Show Bill
            Console.WriteLine();
            Console.WriteLine("=========== AT&T FIBER BILLING SUMMARY ===========");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Plan Speed: {planSpeed} Mbps");
            Console.WriteLine($"Base Price: ${basePrice:F2}");
            Console.WriteLine($"Static IP: ${(staticIPCost > 0 ? staticIPCost.ToString("F2") : "0.00")}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Tax (9.5%): ${tax:F2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Total Due: ${total:F2}");
            Console.WriteLine("==================================================");
            Console.WriteLine("Thank you for choosing AT&T Fiber!");
        }
    }
}
