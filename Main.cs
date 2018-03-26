using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    class Main
    {
        static void Main(string[] args)
        {
                                  //Days      Brkfst  Lunch   Dinner
            string[,] calories = {{"Sunday",   "900", "750",  "1020"},
                                  {"Monday",   "300", "1000", "2700"},
                                  {"Tuesday",  "500", "700",  "2100"},
                                  {"Wednesday","400", "900",  "1780"},
                                  {"Thursday", "600", "1200", "1100"},
                                  {"Friday",   "575", "1150", "1900"},
                                  {"Saturday", "600", "1020", "1700"}};

            //AveragePerDay(calories);
            //ByMeal(calories);
            SearchDay(calories);
        }

        private static void AveragePerDay(string[,] calories)
        {
            double sum;
            double total = 0;
            double average;

            Console.WriteLine("{0,-20}Average", "Day");

            for(int i = 0; i < calories.GetLength(0); i++)
            {
                sum = int.Parse(calories[i, 1]) + int.Parse(calories[i, 2]) + int.Parse(calories[i, 3]);
                Console.WriteLine("{0,-20}{1}", calories[i, 0], sum);
                total += sum;
            }

            average = total / 21;
            Console.WriteLine("Average is {0}", average);
            Console.Read();
        }

        private static void ByMeal(string[,] calories)
        {
            double sumBrkfst = 0;
            double sumLunch = 0;
            double sumDinner = 0;

            Console.WriteLine("By Meal");

            for(int i = 0; i < calories.GetLength(0); i++)
            {
                sumBrkfst += int.Parse(calories[i, 1]);
                sumLunch += int.Parse(calories[i, 2]);
                sumDinner += int.Parse(calories[i, 3]);
            }

            Console.WriteLine("{0,-20}{1:N0}", "Breakfast average:", (sumBrkfst / 7));
            Console.WriteLine("{0,-20}{1:N0}", "Lunch average:", (sumLunch / 7));
            Console.WriteLine("{0,-20}{1:N0}", "Dinner average:", (sumDinner / 7));
            Console.Read();
        }

        private static void SearchDay(string[,] calories)
        {
            string dayToFind;
            double sum = 0;
            bool found = false;

            Console.WriteLine("*********************");
            Console.Write("Enter the day: ");
            dayToFind = Console.ReadLine();

            for(int i = 0; found == false && i < calories.GetLength(0); i++)
                if(calories[i,0].ToUpper() == dayToFind.ToUpper())
                {
                    sum = (double.Parse(calories[i, 1]) + (double.Parse(calories[i, 2]) + (double.Parse(calories[i, 3]))));
                    found = true;
                }
            Console.WriteLine(found ? sum + " calories were consummed on " + dayToFind : "No day could be found");
            Console.Read();
        }
    }
}
