using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the year you want checked");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("The given year {0} is a Leap Year", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("The Given year {0} is not an Leap year", year);

            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("The given year {0} is a Leap year", year);
            }
            else
                Console.WriteLine("The given year is not a Leap Year");
            Console.WriteLine("Press any key to Quit");
            Console.ReadLine();
        }
    }
}