using System;

namespace TacoPos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu:
            Console.WriteLine("****** Welcome to Taco Loco POS System ******");
            Console.WriteLine("Menu:");
            Console.WriteLine("A - 3 Tacos Combo - $7.00 / $9.00 with drink");
            Console.WriteLine("B - Burrito Meal - $8.50 / $10.50 with drink");
            Console.WriteLine("C - Quesadilla Special - $6.00 / $8.00 with drink");
            Console.WriteLine("D - Loaded Nachos - $5.75 / $7.75 with drink");

            //Get Customer Input
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your package code (A/B/C/D): ");
            string code = Console.ReadLine().ToUpper();

            Console.Write("Would you like to add a drink? (Y/N): ");
            string drinkChoice = Console.ReadLine().ToUpper();

            Console.Write("How many combos would you like? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            string comboName = "";
            double pricePerItem = 0.0;

            //Get Combos
            switch (code)
            {
                case "A":
                    comboName = "3 Tacos Combo";
                    pricePerItem = (drinkChoice == "Y") ? 9.00 : 7.00;
                    break;
                case "B":
                    comboName = "Burrito Meal";
                    pricePerItem = (drinkChoice == "Y") ? 10.50 : 8.50;
                    break;
                case "C":
                    comboName = "Quesadilla Special";
                    pricePerItem = (drinkChoice == "Y") ? 8.00 : 6.00;
                    break;
                case "D":
                    comboName = "Loaded Nachos";
                    pricePerItem = (drinkChoice == "Y") ? 7.75 : 5.75;
                    break;
                default:
                    Console.WriteLine("Invalid package code. Please restart the program.");
                    return;
            }

            //Calculate totals
            double subtotal = pricePerItem * quantity;
            double tax = subtotal * 0.095; // 9.5% tax
            double total = subtotal + tax;
            bool freeDessert = subtotal >= 20.00;

            //Reciept:
            Console.WriteLine("\n=========== TACO LOCO RECEIPT ===========");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Combo Ordered: {comboName}");
            Console.WriteLine($"Drink Included: {(drinkChoice == "Y" ? "Yes" : "No")}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Price Per Item: ${pricePerItem:F2}");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Tax (9.5%): ${tax:F2}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Total Cost: ${total:F2}");

            if (freeDessert)
            {
                Console.WriteLine("Congratulations! You get a free dessert!");
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("Thank you for supporting Taco Loco!");
        }
    }
}
