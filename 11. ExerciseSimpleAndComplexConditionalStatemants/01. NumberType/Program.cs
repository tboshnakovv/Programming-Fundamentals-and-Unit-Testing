﻿namespace _01._NumberType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number > 0) 
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }

        }
    }
}