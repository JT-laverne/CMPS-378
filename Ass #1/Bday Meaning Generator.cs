using System;

namespace BdayMeaningGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain = "Y";

            Console.WriteLine("Welcome to Birthday Date Meaning Generator!");

            while (tryAgain.ToUpper() == "Y")
            {
                Console.Write("Please enter the month of your birthday (1-12): ");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the day of your birthday (1-31): ");
                int day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the year of your birthday (2000-2023): ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                string monthMeaning = "";
                string dayMeaning = "";
                string yearMeaning = "";

                switch (month)
                {
                    case 1: monthMeaning = "The month of January means new beginnings and ambition."; break;
                    case 2: monthMeaning = "The month of February means creativity and compassion."; break;
                    case 3: monthMeaning = "The month of March means energy and growth."; break;
                    case 4: monthMeaning = "The month of April means strength and determination."; break;
                    case 5: monthMeaning = "The month of May means curiosity and adaptability."; break;
                    case 6: monthMeaning = "The month of June means charm and communication."; break;
                    case 7: monthMeaning = "The month of July means confidence and loyalty."; break;
                    case 8: monthMeaning = "The month of August means leadership and generosity."; break;
                    case 9: monthMeaning = "The month of September means intelligence and organization."; break;
                    case 10: monthMeaning = "The month of October means balance and mystery."; break;
                    case 11: monthMeaning = "The month of November means passion and determination."; break;
                    case 12: monthMeaning = "The month of December means wisdom and generosity."; break;
                    default: monthMeaning = "Invalid month entered."; break;
                }

                switch (day)
                {
                    case 1: dayMeaning = "The 1st of the month means you are a self-starter and independent."; break;
                    case 2: dayMeaning = "The 2nd of the month means you are cooperative and sensitive."; break;
                    case 3: dayMeaning = "The 3rd of the month means you are creative and optimistic."; break;
                    case 4: dayMeaning = "The 4th of the month means you are practical and reliable."; break;
                    case 5: dayMeaning = "The 5th of the month means you are adventurous and adaptable."; break;
                    default: dayMeaning = "That day represents uniqueness and individuality."; break;
                }

                switch (year)
                {
                    case 2000: yearMeaning = "The year 2000 means you are a Millennial — optimistic and tech-savvy."; break;
                    case 2001: yearMeaning = "The year 2001 means you value creativity and freedom."; break;
                    case 2002: yearMeaning = "The year 2002 means you are balanced and cooperative."; break;
                    case 2003: yearMeaning = "The year 2003 means you are imaginative and driven."; break;
                    case 2004: yearMeaning = "The year 2004 means you are logical and dependable."; break;
                    case 2005: yearMeaning = "The year 2005 means you are curious and energetic."; break;
                    case 2006: yearMeaning = "The year 2006 means you are compassionate and loyal."; break;
                    case 2007: yearMeaning = "The year 2007 means you are analytical and thoughtful."; break;
                    case 2008: yearMeaning = "The year 2008 means you are resilient and focused."; break;
                    case 2009: yearMeaning = "The year 2009 means you are artistic and intuitive."; break;
                    case 2010: yearMeaning = "The year 2010 means you are bold and forward-thinking."; break;
                    case 2015: yearMeaning = "The year 2015 means you are innovative and expressive."; break;
                    case 2020: yearMeaning = "The year 2020 means you are adaptable and strong-minded."; break;
                    case 2023: yearMeaning = "The year 2023 means you are optimistic and future-focused."; break;
                    default: yearMeaning = "That year represents creativity and individuality."; break;
                }

                //Display results
                Console.WriteLine(monthMeaning);
                Console.WriteLine(dayMeaning);
                Console.WriteLine(yearMeaning);

                //Ask to try again
                Console.WriteLine();
                Console.Write("Would you like to try another one? (Y/N): ");
                tryAgain = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
 