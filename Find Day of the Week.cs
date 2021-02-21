//9th January, 2016 is the provided date
using System;

namespace DateTime3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime t1 = new DateTime(2016, 1, 9);
            Console.WriteLine("The day of the week for {0:d} is {1}", t1, t1.DayOfWeek);
            Console.ReadLine();
        }
    }
}