﻿namespace _01._NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;
            for(int rows = 1; rows <= n; rows++)
            {
                for(int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write(current + " ");
                    current++;
                }

                Console.WriteLine();
                if (isBigger)
                    break;
            }
        }
    }
}