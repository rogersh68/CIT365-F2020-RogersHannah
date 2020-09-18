using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            string location = Console.ReadLine();

            // Step 3
            Console.WriteLine($"\nMy name is {name}.");
            Console.WriteLine($"I am from {location}.");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

            // Step 4
            DateTime today = DateTime.UtcNow.Date;
            Console.WriteLine($"\nThe current date is {today.ToString("MM/dd/yyyy")}.");

            // Step 5
            DateTime christmas = new DateTime(2020, 12, 25);
            TimeSpan days = christmas.Subtract(today);
            Console.WriteLine($"{days.TotalDays} days til Christmas.");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

            // Step 6 & 7
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("\nEnter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");
        }
    }
}
