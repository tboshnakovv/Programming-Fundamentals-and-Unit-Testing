﻿namespace _01._Numbers_From_N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n;  i >= 1; i-= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}