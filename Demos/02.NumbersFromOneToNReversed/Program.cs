﻿using System.Threading.Channels;

namespace _02.NumbersFromOneToNReversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}