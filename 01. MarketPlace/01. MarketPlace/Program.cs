﻿namespace _01._MarketPlace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var day = Console.ReadLine();

            if (product == "Banana")
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("2.50");
                }
                else
                {
                    Console.WriteLine("2.70");
                }
            }
            else if (product == "Apple")
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("1.30");
                }
                else
                {
                    Console.WriteLine("1.60");
                }
            }
            else if (product == "Kiwi")
            {
                if (day == "Weekday")
                {
                    Console.WriteLine("2.20");
                }
                else
                {
                    Console.WriteLine("3.00");
                }
            }

        }
    }
}