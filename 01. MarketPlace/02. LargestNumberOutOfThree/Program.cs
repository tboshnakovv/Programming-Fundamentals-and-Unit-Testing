﻿namespace _02._LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            else
            {
                if(num2 > num3)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
               
        }
    }
}