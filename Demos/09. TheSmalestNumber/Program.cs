﻿namespace _08._GreatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);

                if (number < minNumber)
                {
                    minNumber = number;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}