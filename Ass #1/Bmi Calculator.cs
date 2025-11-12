using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your gender (male/female): ");
            string gender = Console.ReadLine();

            Console.Write("Please enter your height in feet: ");
            int heightFeet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your height in inches: ");
            int heightInches = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your weight in pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //Convert height to inches ---
            int totalInches = (heightFeet * 12) + heightInches;

            //Calculate BMI ---
            double bmi = (703 * weight) / (totalInches * totalInches);

            string category;
            if (bmi < 16)
                category = "Severe Thinness";
            else if (bmi >= 16 && bmi < 17)
                category = "Moderate Thinness";
            else if (bmi >= 17 && bmi < 18.5)
                category = "Mild Thinness";
            else if (bmi >= 18.5 && bmi < 25)
                category = "Normal";
            else if (bmi >= 25 && bmi < 30)
                category = "Overweight";
            else if (bmi >= 30 && bmi < 35)
                category = "Obese Class I";
            else if (bmi >= 35 && bmi < 40)
                category = "Obese Class II";
            else
                category = "Obese Class III";

            //Results
            Console.WriteLine();
            Console.WriteLine($"Hi {name},");
            Console.WriteLine($"You are a {gender}. You are {age} years old.");
            Console.WriteLine($"You are currently {heightFeet}'{heightInches}\" and you currently weigh {weight} pounds.");
            Console.WriteLine($"Your BMI is {bmi:F1}, which is {category}.");
            Console.WriteLine("Thank you for using the BMI Calculator!");
        }
    }
}
