﻿namespace _7._SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 30)
                Console.WriteLine("Slow");

            else if (speed > 30)
                    Console.WriteLine("Fast");
        }
    }
}