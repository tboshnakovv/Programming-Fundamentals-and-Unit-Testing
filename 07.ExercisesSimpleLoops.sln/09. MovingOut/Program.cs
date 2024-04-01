﻿namespace _09._MovingOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            // each box is 1x1x1
            // the number of pieces is the same as the area
            int volume = width * length * height;

            while (volume >= 0)
            {
                String input = Console.ReadLine();
                if (input == "Done")
                    break;

                volume -= int.Parse(input);
            }

            if (volume >= 0)
                Console.WriteLine($"{volume} Cubic meters left.");
            else
                Console.WriteLine($"No more free space! You need {-volume} Cubic meters more.");
        }
    }
}