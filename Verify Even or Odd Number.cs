using System;

namespace NumSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Check if your integer is Even or Odd:");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("The given number {0} is Even.", num);
            }
            else
            {
                Console.WriteLine("The given number {0} is Odd.", num);
            }
            Console.ReadLine();
        }
    }
}