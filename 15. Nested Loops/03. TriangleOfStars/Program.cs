﻿namespace _03._TriangleOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row ++)
            {
                for (int numberOfStar = 1; numberOfStar <= row; numberOfStar += 1)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}